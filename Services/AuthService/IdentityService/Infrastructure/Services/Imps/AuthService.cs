using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using IdentityService.DTOs.Requests;
using IdentityService.DTOs.Responses;
using IdentityService.Helpers.Constants;
using IdentityService.Helpers.Extensions;
using IdentityService.Infrastructure.GTAS_MENU;
using IdentityService.Infrastructure.GTAS_MENU.Models;
using IdentityService.Infrastructure.GTAS_PERMISSION.Models;
using IdentityService.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace IdentityService.Infrastructure.Services.Imps
{
    public class AuthService: IAuthService
    {
        private readonly IConfiguration _configuration;
        private readonly IRefeshTokenRepository _refreshToken;
        private readonly GTAS_MENUContext _menuContext;
        private readonly IMapper _mapper;

        public AuthService(IConfiguration configuration, IRefeshTokenRepository rftokenRepository, GTAS_MENUContext menuContext, IMapper mapper)
        {
            _configuration=configuration;
            _refreshToken=rftokenRepository;
            _menuContext=menuContext;
            _mapper = mapper;
        }

        public UserResDTO Login(UserLoginReqDTO requestUser, out string message)
        {
            var pHash = PasswordExtension.Encrypt(requestUser.Password, true, _configuration["Jwt:Secret"]);
            var data = _menuContext.TblUsers.Where(u => u.UserLogin == requestUser.Username && u.PasswordChar == pHash).FirstOrDefault();

            var user = _mapper.Map<User>(data);

            message = "User not found";
            
            if (user == null)
            {
                return new UserResDTO { Message = message };
            }

            message = "Success";

            string token = GenerateToken(user);
            string rfToken = GenerateRefreshToken(user);

            var rs = _refreshToken.Create(new TblRefreshToken { RefreshToken = rfToken, ID = Guid.NewGuid(), UserId = user.UserId });
            //string token = GenerateTokenOld(user);
            var userResult = _mapper.Map<UserResDTO>(user);
            userResult.Message = message;
            userResult.Token = token;
            userResult.RefreshToken = rfToken;

            return userResult;
        }
        public UserResDTO Register(UserRegisterReqDTO registerUser, out string message)
        {
            message = "nothing";
            return null;
        }
        public bool RevokeToken(string refreshToken, out string message)
        {
            if (String.IsNullOrEmpty(refreshToken))
            {
                message = "success";
                return true;
            }
            var result = _refreshToken.RevokeToken(refreshToken);
            message = result ? "success" : "maybe refresh token is wrong";
            return result;
        }
        public UserResDTO RefreshToken(string refreshToken, string oldToken, out string message)
        {
            if (!ValidateCurrentToken(refreshToken))
            {
                message = "refreshToken too old or not correct";
                return null;
            }

            var newtoken = GenerateToken(oldToken);
            var newRefreshToken = GenerateRefreshToken(oldToken);

            _refreshToken.UpdateRefreshToken(refreshToken, newRefreshToken);

            var result = new UserResDTO();
            result.Token = newtoken;
            result.RefreshToken = newRefreshToken;
            message = "success!";
            return result;
        }

        private string GenerateToken(string oldToken)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            List<Claim> claims = GetClaims(oldToken);
                        var tokenDescriptor = NewSecurityTokenDescriptor(claims);

            var token = tokenHandler.CreateToken(tokenDescriptor);


            return tokenHandler.WriteToken(token);
        }

        private string GenerateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            List<Claim> claims = GetClaims(user);
                        var tokenDescriptor = NewSecurityTokenDescriptor(claims);

            var token = tokenHandler.CreateToken(tokenDescriptor);


            return tokenHandler.WriteToken(token);
        }

        private string GenerateRefreshToken(string oldToken)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            List<Claim> claims = new List<Claim>() { GetClaims(oldToken).First() };
            SecurityTokenDescriptor tokenDescriptor = NewSecurityTokenDescriptor(claims);
            var token = tokenHandler.CreateToken(tokenDescriptor);


            return tokenHandler.WriteToken(token);
        }


        private List<Claim> GetClaims(string oldToken)
        {
            var p = GetPrincipalFromExpiredToken(oldToken);
            return p.Claims.ToList();
        }

        private string GenerateRefreshToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            List<Claim> claims = GetClaims(user);
            var tokenDescriptor = NewSecurityTokenDescriptor(claims);
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public List<Claim> GetClaims(User user)
        {
            var claims = new List<Claim> {
                            new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                            new Claim(ClaimTypes.Name, user.FullName??"null"),
                            new Claim(ClaimTypes.Email, user.Email??"null"),
                            //new Claim(Constants.ClaimTypes.IsAdmin,user.IsAdminFlg.ToString()),
                        };
          
            //try
            //{
            //    if (user.Factories != null)
            //    {
            //        bool first = true;
            //        user.Permission.Groups.ForEach(f =>
            //        {
            //            claims.Add(new Claim(Constants.ClaimTypes.Factory, f.FactoryId.ToString()));
            //            if (first)
            //            {
            //                var functions = f.Groups.ToResultFunctions();
            //                functions.ForEach(f => claims.Add(new Claim(Constants.ClaimTypes.Permission, $"{f.FunctionID}:[{string.Join(",", f.Actions)}]")));
            //                first = false;
            //            }
            //        });
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("co loi IED.Server.Services.AuthService GetClaim roi ");
            //}


            return claims;
        }

        public bool CheckPermisionOfUser(IEnumerable<string> permisions, string param)
        {
            var listParam = param.Split(new char[] { ':', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var functionId = listParam[0];
            var action = listParam[1];

            var permission = permisions.SingleOrDefault(x => x.Contains(functionId));

            var result = permission == null ? permission.Contains(action) : false;

            return result;

        }
        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Secret"]);

            return new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature);
        }

        private ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt.Secret"]);

            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = true,
                ValidateIssuer = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateLifetime = false,
                ValidIssuer = _configuration["Jwt:ValidIssuer"],
                ValidAudience = _configuration["Jwt:ValidAudience"],
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256,
                StringComparison.InvariantCultureIgnoreCase))
            {
                throw new SecurityTokenException("Invalid token");
            }

            return principal;
        }

        private bool CustomLifetimeValidator(DateTime? notBefore, DateTime? expires, SecurityToken tokenToValidate, TokenValidationParameters @param)
        {
            if (expires != null)
            {
                return expires > DateTime.UtcNow;
            }
            return false;
        }

        public bool ValidateCurrentToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            try
            {
                var principal = tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidIssuer = _configuration["Jwt.ValidIssuer"],
                    ValidAudience = _configuration["Jwt.ValidAudience"],
                    LifetimeValidator = CustomLifetimeValidator,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["Jwt.Secret"]))
                }, out SecurityToken validatedToken);

                return _refreshToken.CheckExist(token);
            }
            catch
            {
                return false;
            }
        }


        
        private SecurityTokenDescriptor NewSecurityTokenDescriptor(List<Claim> claims)
        {
            return new SecurityTokenDescriptor
            {
                Issuer = _configuration["Jwt.ValidIssuer"],
                Audience = _configuration["Jwt.ValidAudience"],
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(int.Parse(_configuration["Jwt.ValidAudience"])),
                SigningCredentials = GetSigningCredentials()
            };
        }

        public Guid? ValidateToken(string token)
        {
            if (token == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt.Secret"]);
            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                Guid.TryParse(jwtToken.Claims.First(x => x.Type == Constants.ClaimTypes.NameIdentifier).Value, out Guid userId);

                // return user id from JWT token if validation successful
                return userId;
            }
            catch
            {
                // return null if validation fails
                return null;
            }
        }
    }
}
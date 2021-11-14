using IdentityService.DTOs;
using IdentityService.DTOs.Requests;
using IdentityService.DTOs.Responses;
using IdentityService.Helpers;
using IdentityService.Infanstructure.Repositories;
using IdentityService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace IdentityService.Infanstructure.Services.Imps
{
    public class AuthService : IAuthService
    {
        private readonly AppSettings _appSettings;
        private readonly IUserRepository _repo;
        private static string key = "ttpsolutions";

        public AuthService(IUserRepository repo, IConfiguration configuration)
        {
            _repo = repo;
            _appSettings = new AppSettings();
            configuration.GetSection(AppSettings.Section).Bind(_appSettings);
        }

        public UserResDTO Login(UserLoginReqDTO userInput, out string message)
        {
            var passHash = CipherExtensions.Encrypt(userInput.Password, false, key);
            Func<DbSet<TblUser>, Task<TblUser>> func = entity => entity.Where(x => x.UserLogin == userInput.Username && x.PasswordChar == userInput.Password).FirstOrDefaultAsync();
            var user = _repo.Invoke(func);
            if (user != null)
            {

                //return new UserResDTO();
            }
            message = "Username or password not correct!";
            return new UserResDTO();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        private string GenerateToken(string oldToken)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            List<Claim> claims = GetClaims(oldToken);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = _appSettings.JwtIssuer,
                Audience = _appSettings.JwtAudience,
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(_appSettings.JwtExpiryInMinutes),
                SigningCredentials = GetSigningCredentials()
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);


            return tokenHandler.WriteToken(token);
        }

        private string GenerateToken(TblUser user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            List<Claim> claims = GetClaims(user);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = _appSettings.JwtIssuer,
                Audience = _appSettings.JwtAudience,
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(_appSettings.JwtExpiryInMinutes),
                SigningCredentials = GetSigningCredentials()
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);


            return tokenHandler.WriteToken(token);
        }

        private string GenerateRefreshToken(string oldToken)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            List<Claim> claims = new List<Claim>() { GetClaims(oldToken).First() };
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = _appSettings.JwtIssuer,
                Audience = _appSettings.JwtAudience,
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(int.Parse(_appSettings.RefreshTokenExpiryTimeInMinutes)),
                SigningCredentials = GetSigningCredentials()
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);


            return tokenHandler.WriteToken(token);
        }

        private List<Claim> GetClaims(TblUser user)
        {
            var claims = new List<Claim> {
                            new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                            new Claim(ClaimTypes.Name, user.FullName??"null"),
                            new Claim(ClaimTypes.Email, user.EmailAddress1??"null"),
                        };
            return claims;
        }

        private List<Claim> GetClaims(string oldToken)
        {
            var p = GetPrincipalFromExpiredToken(oldToken);
            return p.Claims.ToList();
        }

        private string GenerateRefreshToken(TblUser user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            List<Claim> claims = new List<Claim>() { GetClaims(user).First() };
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = _appSettings.JwtIssuer,
                Audience = _appSettings.JwtAudience,
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(int.Parse(_appSettings.RefreshTokenExpiryTimeInMinutes)),
                SigningCredentials = GetSigningCredentials()
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.ASCII.GetBytes(_appSettings.JwtSecret);

            return new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature);
        }

        private ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var key = Encoding.ASCII.GetBytes(_appSettings.JwtSecret);

            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = true,
                ValidateIssuer = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateLifetime = false,
                ValidIssuer = _appSettings.JwtIssuer,
                ValidAudience = _appSettings.JwtAudience
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
        bool IAuthService.Logout()
        {
            throw new NotImplementedException();
        }

        public UserResDTO RefreshToken(string refreshToken, out string message)
        {
            throw new NotImplementedException();
        }
    }
}

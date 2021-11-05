using QCService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace QCService.Helpers.Extensions
{
    public static class ClaimsExtensions
    {
        public static User ParseUserFromClaimsServer(this ClaimsPrincipal value)
        {
            try
            {
                var result = new User
                {
                    FullName = value.FindFirst(ClaimTypes.Name)?.Value,
                };
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(" GWD.Client.Data.Extensions.ClaimsExtensions.cs CANN'T CLAIMS");
                Console.WriteLine(e.Message);
                return null;
            }

        }


        public static User ParseUserFromClaimsClient(this ClaimsPrincipal value)
        {
            try
            {
                var result = new User
                {
                    
                    FullName = value.FindFirst(QCService.Helpers.Constants.Constants.ClaimTypes.Name)?.Value
                                ?? "Unknow",
                    
                };
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(" GWD.Client.Data.Extensions.ClaimsExtensions.cs CANN'T CLAIMS");
                Console.WriteLine(e.Message);
                return null;
            }
        }


        public static List<Claim> GetClaims(this User user)
        {
            var claims = new List<Claim> {
                            new Claim(ClaimTypes.Name, user.FullName??"null"),
                        };


            return claims;
        }

    }
}

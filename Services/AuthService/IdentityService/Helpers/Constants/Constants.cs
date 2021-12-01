using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityService.Helpers.Constants
{
    public static class Constants
    {
        public static class ClaimTypes
        {
            public const string Permission = "permission";
            public const string NameIdentifier = "nameid";
            public const string Name = "unique_name";
            public const string Email = "email";
            public const string IsAdmin = "is_admin";
            public const string ExpirationTime = "exp";
            public const string Factory = "factory";
            public const string Role = "role";
            public const string UserLogin = "userlogin";
        }
    }
}

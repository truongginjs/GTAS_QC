using System;
using System.Collections.Generic;
using System.Security.Claims;

#nullable disable

namespace IdentityService.Infrastructure.GTAS_MENU.Models
{
    public partial class TblUser
    {
        public int UserId { get; set; }
        public string UserLogin { get; set; }
        public int UserMenuTypeId { get; set; }
        public string PasswordChar { get; set; }
        public string Pincode { get; set; }
        public bool IsLockedFlg { get; set; }
        public string FullName { get; set; }
        public string PhoneNo1 { get; set; }
        public string PhoneNo2 { get; set; }
        public string EmailAddress1 { get; set; }
        public string EmailAddress2 { get; set; }
        public string SocialNetworkAccount { get; set; }
        public string Remarks { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public bool IsInactiveFlg { get; set; }

        internal List<Claim> GetClaims()
        {
            throw new NotImplementedException();
        }
    }
}

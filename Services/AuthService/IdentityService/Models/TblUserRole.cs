using System;
using System.Collections.Generic;

#nullable disable

namespace IdentityService.Models
{
    public partial class TblUserRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public bool IsInactiveFlg { get; set; }
    }
}

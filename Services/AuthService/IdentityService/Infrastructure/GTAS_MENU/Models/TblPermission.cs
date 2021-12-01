﻿using System;
using System.Collections.Generic;

#nullable disable

namespace IdentityService.Infrastructure.GTAS_MENU.Models
{
    public partial class TblPermission
    {
        public int PermissionId { get; set; }
        public string PermissionCode { get; set; }
        public string PermissionName { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public bool IsInactiveFlg { get; set; }
    }
}

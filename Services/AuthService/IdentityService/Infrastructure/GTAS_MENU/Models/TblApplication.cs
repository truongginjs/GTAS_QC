using System;
using System.Collections.Generic;

#nullable disable

namespace IdentityService.Infrastructure.GTAS_MENU.Models
{
    public partial class TblApplication
    {
        public int AppId { get; set; }
        public string AppName { get; set; }
        public byte[] AppImage { get; set; }
        public string AppDescription { get; set; }
        public string AppLink { get; set; }
        public bool IsClickOnce { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public bool IsInactiveFlg { get; set; }
        public string PublisherName { get; set; }
        public string SuiteName { get; set; }
        public string ProductName { get; set; }
        public string SupportUrl { get; set; }
        public string ErrorUrl { get; set; }
        public string AppGroup { get; set; }
    }
}

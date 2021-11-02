using System;
using System.Collections.Generic;

#nullable disable

namespace IdentityService.Models
{
    public partial class TblClass
    {
        public int ClassCode { get; set; }
        public string ClassName { get; set; }
        public string ClassFieldName { get; set; }
        public string ClassDescription { get; set; }
        public byte[] ClassImg { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public bool IsInactiveFlg { get; set; }
        public bool? IsSystemLib { get; set; }
    }
}

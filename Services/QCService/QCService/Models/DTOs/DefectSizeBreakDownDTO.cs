using System;

namespace QCService.Models.DTOs
{
    public class DefectSizeBreakDownDTO
    {
        public string ColorCode { get; set; }
        public string SizeCode { get; set; }
        public int OkQty { get; set; }
        public int BGroupQty { get; set; }
        public int RejectQty { get; set; }
    }
}

using System;

namespace QCService.Models.DTOs
{
    public class InspectionBySizeDTO
    {
        public string ColorCode { get; set; }
        public string SizeCode { get; set; }
        public int Qty { get; set; }
        public int OkQty { get; set; }
        public int BGroupQty { get; set; }
        public int RejectQty { get; set; }
    }
}

using System;

namespace QCService.Models.DTOs
{
    public class InspectionBySizeDTO
    {
        public string ColorCode { get; set; }
        public string SizeCode { get; set; }
        public double Qty { get; set; }
        public double OkQty { get; set; }
        public double BGroupQty { get; set; }
        public double RejectQty { get; set; }
    }
}

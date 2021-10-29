namespace QCService.Models.DTOs
{
    public class SizeBreakDownDTO
    {
        public string SizeCode { get; set; }
        public string SizeName { get; set; }
        public string Shade { get; set; }
        public double QCQty { get; set; }
        public double InspectionQty { get; set; }
    }
}
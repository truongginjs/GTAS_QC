namespace QCService.Models.DTOs
{
    public class InspectionBySizeFinalDTO
    {
        public string OCNumber { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int OrderQty { get; set; }
        public int OfferedQty { get; set; }
        public int InspectionQty { get; set; }
        public int AcceptedQty { get; set; }
    }
}
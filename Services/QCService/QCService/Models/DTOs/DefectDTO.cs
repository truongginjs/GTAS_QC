namespace QCService.Models.DTOs
{
    public class DefectDTO
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public int Low { get; set; }
        public int High { get; set; }
        public int Serious { get; set; }
    }
}
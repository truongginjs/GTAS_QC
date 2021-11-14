using System.Collections.Generic;

namespace QCService.Models.DTOs
{
    public class DefectDTO
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public int Minor { get; set; }
        public int Major { get; set; }
        public int Serious { get; set; }
        public List<string> Solutions { get; set; }
        public List<string> Handlers { get; set; }
        public List<string> Reasons { get; set; }
    }
}
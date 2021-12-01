using System.Collections.Generic;

namespace QCService.Models.DTOs
{
    public class DefectDTO
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public int Minor { get; set; } = 0;
        public int Major { get; set; } = 0;
        public int Critical { get; set; } = 0;
        public List<string> Solutions
        {
            get; set;
        }
        public List<string> DefectTypes { get; set; }

        public List<string> Handlers { get; set; }
        public List<string> Reasons { get; set; }
        public string Timeline { get; set; }
        public string Comment { get; set; }
    }
}
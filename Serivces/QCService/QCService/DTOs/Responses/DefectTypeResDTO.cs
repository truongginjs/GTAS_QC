using System;
using System.Collections.Generic;

namespace QCService.DTOs.Responses
{
    public class DefectTypeResDTO
    {
        public Guid Id{get;set;}
        public string Code { get; set; }
        public string Name { get; set; }
        
        public List<string> Reasons { get; set; }
        public List<string> Solutions { get; set; }
        public List<string> Handlers { get; set; }
        public string CompletionTime { get; set; }

    }
}
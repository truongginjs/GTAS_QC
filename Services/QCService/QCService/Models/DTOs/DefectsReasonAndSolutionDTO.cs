using System.Collections.Generic;

namespace QCService.Models.DTOs
{
    public class DefectsReasonAndSolutionDTO
    {
        public string Code{get;set;}
        public string Description{get;set;}
        public List<string> Solutions {get;set;}
        public List<string> ReasonsJson {get;set;}
        public List<string> HandlersJson {get;set;}
        public string TimeFixed {get;set;}
    }
}
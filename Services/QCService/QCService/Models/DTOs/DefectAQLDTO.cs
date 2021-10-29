using System.Collections.Generic;

namespace QCService.Models.DTOs
{
    public class DefectAQLDTO
    {
        public List<AQLDTO> AQLs{get;set;}
        public List<DefectDTO> Defects{get;set;}

        public string Result{get;set;}
    }
}
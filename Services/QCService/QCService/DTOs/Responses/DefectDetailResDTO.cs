using QCService.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QCService.DTOs.Responses
{
    public class DefectDetailResDTO
    {
        public string CategoryAQL { get; set; }
        //public List<AQLLib> AQLLibs { get; set; } 
        public List<DefectDTO> Defects { get; set; }
    }
}

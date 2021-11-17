using QCService.Helpers.Extensions;
using QCService.Models.L01;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QCService.Models.DTOs
{
    public class DefectDetailDTO
    {
        public string CategoryAQL { get; set; }
        public List<DefectDTO> Defects { get; set; }
    }
}
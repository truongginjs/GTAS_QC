using QCService.Helpers.Extensions;
using QCService.Models.L01;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QCService.Models.DTOs
{
    public class DefectDetailDTO
    {
        public string CategoryAQL { get; set; }
        //public List<AQLLib> AQLLibs { get; set; } 

        private List<DefectDTO> defects;
        [NotMapped]
        public List<DefectDTO> Defects
        {
            get => DefectsJson.GetJsonProperty<List<DefectDTO>>(ref defects);
            set => DefectsJson = defects.SetJsonProperty(value, out string json);
        }
        public string DefectsJson { get; set; }
    }
}
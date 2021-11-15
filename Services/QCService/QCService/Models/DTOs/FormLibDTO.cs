using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using QCService.Models.Enums;

namespace QCService.Models.DTOs
{
    public class FormLibDTO
    {
        public FormEnum FormType { get; set; }
        public Dictionary<string,bool> FilterForm { get; set; }
        public List<string> Fields { get; set; }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using QCService.Models.Enums;

namespace QCService.Models.DTOs
{
    public class FormLibDTO
    {
        public FormEnum FormType { get; set; }
        [NotMapped]
        public List<string> Fields { get; set; }
        public string FieldsJson { get; set; }
    }
}
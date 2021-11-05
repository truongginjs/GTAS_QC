using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using LibraryService.Models.Enums;

namespace LibraryService.Models.DTOs
{
    public class FormLibDTO
    {
        public FormEnum FormType { get; set; }
        public List<string> Fields { get; set; }
    }
}
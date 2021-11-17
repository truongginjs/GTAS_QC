using LibraryService.Models.Enums;
using System.Collections.Generic;

namespace LibraryService.DTOs.Responses
{
    public class FormLibResDTO
    {
        public string FormType { get; set; }
        public Dictionary<string, bool> FilterForm { get; set; }
        public List<string> Fields { get; set; }
    }
}
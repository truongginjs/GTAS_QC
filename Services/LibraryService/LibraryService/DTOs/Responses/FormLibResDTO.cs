using System.Collections.Generic;

namespace LibraryService.DTOs.Responses
{
    public class FormLibResDTO
    {
        public string FormType { get; set; }
        public List<string> Fields { get; set; }
    }
}
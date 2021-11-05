using System.Collections.Generic;

namespace LibraryService.DTOs.Requests
{
    public class FormLibReqDTO
    {
        public string FormType { get; set; }
        public List<string> Fields { get; set; }
    }
}
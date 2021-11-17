using System.Collections.Generic;

namespace LibraryService.DTOs.Requests
{
    public class FormLibReqDTO
    {
        public string FormType { get; set; }
        public Dictionary<string, bool> FilterForm { get; set; }
        public List<string> Fields { get; set; }
    }
}
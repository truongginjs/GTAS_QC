using LibraryService.Models.DTOs;
using System;
using System.Collections.Generic;

namespace LibraryService.DTOs.Requests
{
    public class QCZoneTypeReqDTO
    {
        public string Description { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string GroupType { get; set; }
        public FormLibReqDTO Forms { get; set; }
        public string Prefix { get; set; }
        public int No { get; set; }

    }
}

using System;

namespace LibraryService.DTOs.Requests
{
    public class SiteReqDTO
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}

using System;

namespace LibraryService.DTOs.Requests
{
    public class TimelineDefectReqDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}
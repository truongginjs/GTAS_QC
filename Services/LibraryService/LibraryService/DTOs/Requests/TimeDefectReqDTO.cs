using System;

namespace LibraryService.DTOs.Requests
{
    public class TimeDefectReqDTO
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}
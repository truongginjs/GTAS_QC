using System;

namespace LibraryService.DTOs.Requests
{
    public class HandlerDefectReqDTO
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}
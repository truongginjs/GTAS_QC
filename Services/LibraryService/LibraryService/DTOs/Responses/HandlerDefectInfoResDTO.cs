using System;

namespace LibraryService.DTOs.Responses
{
    public class HandlerDefectInfoResDTO
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public Guid ZoneTypeId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
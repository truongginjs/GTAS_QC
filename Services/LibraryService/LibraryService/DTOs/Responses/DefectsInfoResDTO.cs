using System;
using System.Collections.Generic;

using DSSType = System.Collections.Generic.Dictionary<string, string>;
using LDType = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>;
namespace LibraryService.DTOs.Responses
{
    public class DefectsInfoResDTO
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public LDType Reasons { get; set; }
        public LDType Solutions { get; set; }
        public LDType DefectTypes { get; set; }
        public Guid? ZoneTypeId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
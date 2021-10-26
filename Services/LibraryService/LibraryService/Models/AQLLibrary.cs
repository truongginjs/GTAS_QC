using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryService.Models
{
    public class AQLLibrary : BaseModel
    {
        [Required]
        [StringLength(500)]
        public string Name{get;set;}


        [Required]
        public Guid ZoneTypeId{get;set;}
        public ZoneType ZoneType{get;set;}
    }
}
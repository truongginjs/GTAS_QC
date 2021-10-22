using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryService.Models
{
    public class Defective : BaseModel
    {
        [Required]
        [StringLength(500)]
        public string Code { get; set; }
        [Required]
        [StringLength(500)]
        public string Name { get; set; }
        [NotMapped]
        public List<string> Defectives { get; set; }
        public string DefectivesJson { get; set; }
        [NotMapped]
        public List<string> Solutions { get; set; }
        public string SolutionsJson { get; set; }
        [Required]
        public Guid ZoneTypeId { get; set; }
        public ZoneType ZoneType { get; set; }
    }
}
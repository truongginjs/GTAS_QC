using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QCService.Models
{
    [Index(nameof(Code),nameof(Name))]
    public class Defect : BaseModel
    {
        [Required]
        [StringLength(500)]
        public string Code { get; set; }
        [Required]
        [StringLength(500)]
        public string Name { get; set; }
        [NotMapped]
        public List<string> Defects { get; set; }
        public string DefectsJson { get; set; }
        [NotMapped]
        public List<string> Solutions { get; set; }
        public string SolutionsJson { get; set; }
        [Required]
        public Guid ZoneTypeId { get; set; }
        public QCZoneType ZoneType { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using QCService.Models.C01;

namespace QCService.Models.C01
{
    [Table("C01_DefectLib")]
    [Index(nameof(Code), nameof(Name))]
    public class DefectLib : BaseModel
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
        public Guid? ZoneTypeId { get; set; }
        public QCZoneTypeLib ZoneType { get; set; }
    }
}
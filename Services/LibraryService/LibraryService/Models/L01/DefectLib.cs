using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LibraryService.Models.L01
{
    [Table("L01_DefectLib")]
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
        public List<string> Reasons { get; set; }
        public string ReasonsJson { get; set; }
        [NotMapped]
        public List<string> Solutions { get; set; }
        public string SolutionsJson { get; set; }
         [NotMapped]
        public List<string> Handlers { get; set; }
        public string HandlersJson { get; set; }
        public Guid? ZoneTypeId { get; set; }
        public QCZoneTypeLib ZoneType { get; set; }
    }
}
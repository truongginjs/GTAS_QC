using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;

namespace QCService.Models.C01
{
    [Table("C01_DefectTypeLib")]
    [Index(nameof(Code), nameof(Name))]
    public class DefectTypeLib : BaseModel
    {
        [Required]
        [StringLength(500)]
        public string Code { get; set; }
        [Required]
        [StringLength(500)]
        public string Name { get; set; }
        public string ReasonsJson { get; set; }
        public string SolutionsJson { get; set; }
        public string HandlersJson { get; set; }

        public Guid? ZoneTypeId { get; set; }
        public QCZoneTypeLib ZoneType { get; set; }
    }
}
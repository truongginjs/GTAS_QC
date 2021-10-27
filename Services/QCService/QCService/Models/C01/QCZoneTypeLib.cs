using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using QCService.Models.DTOs;
using QCService.Models.Enums;

namespace QCService.Models.C01
{
    [Table("C01_QCZoneTypeLib")]
    [Index(nameof(Code), nameof(Name))]
    public class QCZoneTypeLib : BaseModel
    {
        [Required]
        [StringLength(255)]
        public string Code { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public QCZoneTypeGroupEnum GroupType { get; set; }
        [NotMapped]
        public List<FormLibDTO> Forms {get;set;}
        public string FormsJson { get; set; }
    }
}
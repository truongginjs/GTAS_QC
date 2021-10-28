using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using QCService.Models.DTOs;

namespace QCService.Models.C02
{
    [Table("C02_QCTicket")]

    [Index(nameof(Code),nameof(Name))]
    public class QCTicket
    {
        [Key] 
        [ForeignKey("QCRequest")]
        public Guid Id { get; set; }
        public QCRequest QCRequest { get; set; }
        
        [Required]
        [MaxLength(255)]
        public string Code { get; set; }

        [Required]
        [MaxLength(500)]
        public string Name { get; set; }
        public string ProductLine { get; set; }
        [NotMapped]
        public List<DefectDTO> Defects { get; set; }

        public string DefectsJson { get; set; }
        [NotMapped]
        public DefectSizeBreakDownDTO DefectSizeBreakDown { get; set; }
        public string DefectSizeBreakDownJson { get; set; }
        [NotMapped]
        public List<DefectTypeDTO> DefectRepairs { get; set; }
        public string DefectRepairsJson { get; set; }
        [NotMapped]
        public object PrivateDetail { get; set; }
        public string PrivateDetailJson { get; set; }

    }
}
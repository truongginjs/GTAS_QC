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
        public DefectAQLDTO DefectAQL { get; set; }

        public string DefectAQLJson { get; set; }
        [NotMapped]
        public DefectSizeBreakDownDTO DefectSizeBreakDown { get; set; }
        public string DefectSizeBreakDownJson { get; set; }
        [NotMapped]
        public List<DefectsReasonAndSolutionDTO> DefectsReasonAndSolutions { get; set; }
        public string DefectsReasonAndSolutionsJson { get; set; }
        [NotMapped]
        public object PrivateDetail { get; set; }
        public string PrivateDetailJson { get; set; }

    }
}
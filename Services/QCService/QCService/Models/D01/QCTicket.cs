using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using QCService.Models.DTOs;

namespace QCService.Models.D01
{
    [Table("D01_QCTicket")]

    [Index(nameof(Code), nameof(Name))]
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

        private DefectAQLDTO defectAQL;
        [NotMapped]
        public DefectAQLDTO DefectAQL 
        {
            get
            {
                defectAQL ??= JsonSerializer.Deserialize<DefectAQLDTO>(DefectAQLJson);
                return defectAQL;
            }
            set
            {
                defectAQL = value;
                DefectAQLJson= JsonSerializer.Serialize(defectAQL);
            }
        }

        public string DefectAQLJson { get; set; }

        private DefectSizeBreakDownDTO defectSizeBreakDown;
        [NotMapped]
        public DefectSizeBreakDownDTO DefectSizeBreakDown
        {
            get
            {
                defectSizeBreakDown ??= JsonSerializer.Deserialize<DefectSizeBreakDownDTO>(DefectSizeBreakDownJson);
                return defectSizeBreakDown;
            }
            set
            {
                defectSizeBreakDown = value;
                DefectAQLJson = JsonSerializer.Serialize(defectSizeBreakDown);
            }
        }
        public string DefectSizeBreakDownJson { get; set; }

        private List<DefectsReasonAndSolutionDTO> defectsReasonAndSolutions;
        [NotMapped]
        public List<DefectsReasonAndSolutionDTO> DefectsReasonAndSolutions 
        {
            get
            {
                defectsReasonAndSolutions ??= JsonSerializer.Deserialize<List<DefectsReasonAndSolutionDTO>>(DefectsReasonAndSolutionsJson);
                return defectsReasonAndSolutions;
            }
            set
            {
                defectsReasonAndSolutions = value;
                DefectsReasonAndSolutionsJson = JsonSerializer.Serialize(defectSizeBreakDown);
            }
        }
        public string DefectsReasonAndSolutionsJson { get; set; }

        private object privateDetail;
        [NotMapped]
        public object PrivateDetail
        {
            get
            {
                privateDetail ??= JsonSerializer.Deserialize<object>(PrivateDetailJson);
                return privateDetail;
            }
            set
            {
                privateDetail = value;
                PrivateDetailJson = JsonSerializer.Serialize(privateDetail);
            }
        }
        public string PrivateDetailJson { get; set; }
        public bool IsDeleted { get; set; }
    }
}
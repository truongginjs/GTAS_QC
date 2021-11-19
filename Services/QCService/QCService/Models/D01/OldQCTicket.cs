using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using QCService.Models.DTOs;

namespace QCService.Models.D01
{

    [Index(nameof(Code), nameof(Name))]
    public class OldQCTicket
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
                defectAQL ??= string.IsNullOrWhiteSpace(DefectAQLJson) ? null:JsonSerializer.Deserialize<DefectAQLDTO>(DefectAQLJson);
                return defectAQL;
            }
            set
            {
                defectAQL = value;
                DefectAQLJson= defectAQL==null? string.Empty: JsonSerializer.Serialize(defectAQL);
            }
        }

        public string DefectAQLJson { get; set; }

        private InspectionBySizeDTO defectSizeBreakDown;
        [NotMapped]
        public InspectionBySizeDTO DefectSizeBreakDown
        {
            get
            {
                defectSizeBreakDown ??= string.IsNullOrWhiteSpace(DefectSizeBreakDownJson) ? null : JsonSerializer.Deserialize<InspectionBySizeDTO>(DefectSizeBreakDownJson);
                return defectSizeBreakDown;
            }
            set
            {
                defectSizeBreakDown = value;
                DefectAQLJson = defectSizeBreakDown == null ? string.Empty : JsonSerializer.Serialize(defectSizeBreakDown);
            }
        }
        public string DefectSizeBreakDownJson { get; set; }

        private List<DefectsReasonAndSolutionDTO> defectsReasonAndSolutions;
        [NotMapped]
        public List<DefectsReasonAndSolutionDTO> DefectsReasonAndSolutions 
        {
            get
            {
                defectsReasonAndSolutions ??= string.IsNullOrWhiteSpace(DefectsReasonAndSolutionsJson) ? null : JsonSerializer.Deserialize<List<DefectsReasonAndSolutionDTO>>(DefectsReasonAndSolutionsJson);
                return defectsReasonAndSolutions;
            }
            set
            {
                defectsReasonAndSolutions = value;
                DefectsReasonAndSolutionsJson = defectsReasonAndSolutions == null ? string.Empty : JsonSerializer.Serialize(defectSizeBreakDown);
            }
        }
        public string DefectsReasonAndSolutionsJson { get; set; }

        private object privateDetail;
        [NotMapped]
        public object PrivateDetail
        {
            get
            {
                privateDetail ??= string.IsNullOrWhiteSpace(PrivateDetailJson) ? null : JsonSerializer.Deserialize<object>(PrivateDetailJson);
                return privateDetail;
            }
            set
            {
                privateDetail = value;
                PrivateDetailJson = privateDetail == null ? string.Empty : JsonSerializer.Serialize(privateDetail);
            }
        }
        public string PrivateDetailJson { get; set; }
        public bool IsDeleted { get; set; }
    }
}
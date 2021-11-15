using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using QCService.Models.L01;

namespace QCService.Models.L01
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

        private List<string> reasons;
        [NotMapped]
        public List<string> Reasons
        {
            get
            {
                reasons = string.IsNullOrWhiteSpace(ReasonsJson) ? null : JsonSerializer.Deserialize<List<string>>(ReasonsJson);
                return reasons;
            }
            set
            {
                reasons = value;
                ReasonsJson = reasons == null ? string.Empty : JsonSerializer.Serialize(reasons);
            }
        }
        public string ReasonsJson { get; set; }

        private List<string> solutions;
        [NotMapped]
        public List<string> Solutions
        {
            get
            {
                solutions = string.IsNullOrWhiteSpace(SolutionsJson) ? null : JsonSerializer.Deserialize<List<string>>(SolutionsJson);
                return solutions;
            }
            set
            {
                solutions = value;
                SolutionsJson = solutions == null ? string.Empty : JsonSerializer.Serialize(solutions);
            }
        }
        public string SolutionsJson { get; set; }
        private List<string> handlers;
        [NotMapped]
        public List<string> Handlers
        {
            get
            {
                handlers = string.IsNullOrWhiteSpace(HandlersJson) ? null : JsonSerializer.Deserialize<List<string>>(HandlersJson);
                return handlers;
            }
            set
            {
                handlers = value;
                HandlersJson = handlers == null ? string.Empty : JsonSerializer.Serialize(handlers);
            }
        }
        public string HandlersJson { get; set; }

        public List<string> defectType;
        [NotMapped]
        public List<string> DefectType
        {
            get
            {
                defectType = string.IsNullOrWhiteSpace(DefectTypeJson) ? null : JsonSerializer.Deserialize<List<string>>(DefectTypeJson);
                return defectType;
            }
            set
            {
                defectType = value;
                HandlersJson = defectType == null ? string.Empty : JsonSerializer.Serialize(defectType);
            }
        }
        public string DefectTypeJson { get; set; }

        public Guid? ZoneTypeId { get; set; }
        public QCZoneTypeLib ZoneType { get; set; }
    }
}
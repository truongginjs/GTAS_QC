using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using QCService.Models.L01;

using DSSType = System.Collections.Generic.Dictionary<string, string>;
using LDType = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>;
using QCService.Helpers.Extensions;

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

        private LDType reasons;
        [NotMapped]
        public LDType Reasons
        {
            get => ReasonsJson.GetJsonProperty(ref reasons);
            set => ReasonsJson = reasons.SetJsonProperty(value, out string json);
        }
        public string ReasonsJson { get; set; }

        private LDType solutions;
        [NotMapped]
        public LDType Solutions
        {
            get => SolutionsJson.GetJsonProperty(ref solutions);
            set => SolutionsJson = solutions.SetJsonProperty(value, out string json);
        }
        public string SolutionsJson { get; set; }

        private LDType defectTypes;
        [NotMapped]
        public LDType DefectTypes
        {
            get => DefectTypesJson.GetJsonProperty(ref defectTypes);
            set => DefectTypesJson = defectTypes.SetJsonProperty(value, out string json);
        }
        public string DefectTypesJson { get; set; }

        public Guid? ZoneTypeId { get; set; }
        public QCZoneTypeLib ZoneType { get; set; }
    }
}
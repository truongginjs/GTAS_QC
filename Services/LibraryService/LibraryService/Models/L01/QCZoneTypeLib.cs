using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using LibraryService.Models.DTOs;
using LibraryService.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace LibraryService.Models.L01
{ 
    [Table("L01_QCZoneTypeLib")]
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

        private FormLibDTO forms;
        [NotMapped]
        public FormLibDTO Forms
        {
            get
            {
                forms ??= string.IsNullOrWhiteSpace(FormsJson) ? null : JsonSerializer.Deserialize<FormLibDTO>(FormsJson);
                return forms;
            }
            set
            {
                forms = value;

                FormsJson = forms == null ? string.Empty : JsonSerializer.Serialize(forms);
            }
        }
        public string FormsJson { get; set; }
    }
}
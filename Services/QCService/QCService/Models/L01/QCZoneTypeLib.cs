using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using QCService.Models.DTOs;
using QCService.Models.Enums;

namespace QCService.Models.L01
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
        
        private List<FormLibDTO> forms;
        [NotMapped]
        public List<FormLibDTO> Forms
        {
            get { forms ??= JsonSerializer.Deserialize<List<FormLibDTO>>(FormsJson); return forms; }
            set { forms = value; FormsJson = JsonSerializer.Serialize(forms); }
        }
        public string FormsJson { get; set; }
    }
}
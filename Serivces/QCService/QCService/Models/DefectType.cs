using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;

namespace QCService.Models
{
    [Index(nameof(Code),nameof(Name))]
    public class DefectType : BaseModel
    {
        [Required]
        [StringLength(500)]
        public string Code { get; set; }
        [Required]
        [StringLength(500)]
        public string Name { get; set; }
        
        [NotMapped]
        public List<string> Reasons { get; set; }
        // public List<string> Reasons { get=>JsonSerializer.Deserialize<List<string>>(ReasonsJson); set=>ReasonsJson=JsonSerializer.Serialize(value); }
        public string ReasonsJson { get; set; }
        [NotMapped]
        public List<string> Solutions { get; set; }
        public string SolutionsJson { get; set; }
        [NotMapped]
        public List<string> Handlers { get; set; }
        public string HandlersJson { get; set; }
        public string CompletionTime { get; set; }

    }
}
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using QCService.Models.Enums;

namespace QCService.Models
{
    [Index(nameof(Code), nameof(Name))]

    public class QCZoneType : BaseModel
    {
        [Required]
        [StringLength(500)]
        public string Code { get; set; }
        [Required]
        [StringLength(500)]
        public string Name { get; set; }

        public QCZoneTypeGroupEnum GroupType { get; set; }

    }
}
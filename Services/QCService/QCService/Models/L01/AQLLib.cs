using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QCService.Models.L01
{
    [Table("L01_AQLLib")]
    public class AQLLib : BaseModel
    {
        // [Required]
        // [StringLength(500)]
        // public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Category { get; set; }
        public int SeqNo { get; set; }
        [Required]
        [StringLength(100)]
        public string LotSize { get; set; }
        public Guid? ZoneTypeId { get; set; }
        public QCZoneTypeLib ZoneType { get; set; }
    }
}
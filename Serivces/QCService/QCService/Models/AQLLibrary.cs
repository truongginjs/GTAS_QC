using System;
using System.ComponentModel.DataAnnotations;

namespace QCService.Models
{
    public class AQLLibrary : BaseModel
    {
        // [Required]
        // [StringLength(500)]
        // public string Name { get; set; }

        [Required]
        [StringLength(500)]
        public string Category { get; set; }
        public int SeqNo { get; set; }
        [Required]
        [StringLength(100)]
        public string LotSize { get; set; }
        public int SampleSize { get; set; }
        public int Accept { get; set; }
        public int Reject { get; set; }
        // [Required]
        // public Guid ZoneTypeId{get;set;}
        // public ZoneType ZoneType{get;set;}
    }
}
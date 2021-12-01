using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryService.Models.L01
{
    //Timeline
    [Table("L01_TimeDefectLib")]
    public class TimelineDefectLib:BaseModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public Guid? ZoneTypeId { get; set; }
        public QCZoneTypeLib ZoneType { get; set; }
    }
}

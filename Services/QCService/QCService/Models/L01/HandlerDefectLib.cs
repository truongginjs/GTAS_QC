using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QCService.Models.L01
{
    //Person in change
    [Table("L01_HandlerDefectLib")]
    public class HandlerDefectLib:BaseModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public Guid? ZoneTypeId { get; set; }
        public QCZoneTypeLib ZoneType { get; set; }
    }
}

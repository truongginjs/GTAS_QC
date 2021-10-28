using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using QCService.Models.C01;

namespace QCService.Models.C02
{
    [Table("C02_QCRequest")]
    [Index(nameof(ZoneTypeId), nameof(QCNumber), nameof(QCType))]
    public class QCRequest : BaseModel
    {
        [Required]
        public Guid ZoneTypeId { get; set; }
        public QCZoneTypeLib ZoneType { get; set; }
        [NotMapped]
        public QCTicket QCTicket {get;set;}

        [StringLength(25)]
        public string QCNumber { get; set; }
        [StringLength(25)]
        public string GRNNumber { get; set; }
        [StringLength(25)]
        public string Category { get; set; }
        [StringLength(255)]
        public string ArticleCode { get; set; }
        [StringLength(255)]
        public string ArticleName { get; set; }
        public DateTime QCRequestDate { get; set; }
        [StringLength(255)]
        public string StyleName { get; set; }
        [StringLength(255)]
        public string StyleCode { get; set; }
        [StringLength(255)]
        public string OCNumber { get; set; }
        [StringLength(255)]
        public string QCDefinition { get; set; }
        [StringLength(255)]
        public string SamplePlan { get; set; }
        public int SamplePercentage { get; set; }
        [StringLength(255)]
        public string ColorCode { get; set; }
        [StringLength(25)]
        public string ColorName { get; set; }
        [StringLength(25)]
        public string SizeCode { get; set; }
        [StringLength(25)]
        public string SizeName { get; set; }
        [StringLength(10)]
        public string Shade { get; set; }
        public double QCQty { get; set; }
        public double InspectionQty { get; set; }
        [StringLength(15)]
        public string QCType { get; set; }

    }
}
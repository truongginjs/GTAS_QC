using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using QCService.Models.L01;
using QCService.Models.DTOs;
using QCService.Models.Enums;
using System.Text.Json;

namespace QCService.Models.D01
{
    [Table("D01_QCRequest")]
    [Index(nameof(ZoneTypeId), nameof(QCNumber), nameof(QCType))]
    public class QCRequest : BaseModel
    {
        [Required]
        public Guid ZoneTypeId { get; set; }
        [NotMapped]
        public QCZoneTypeLib ZoneType { get; set; }
        [NotMapped]
        public QCDetail QCDetail { get; set; }

        public TransferStatusEnum TransferStatus { get; set; }
        public DocStatusEnum DocStatus { get; set; }


        [StringLength(255)]
        public string Site { get; set; }
        [StringLength(255)]
        public string Buyer { get; set; }
        [StringLength(255)]
        public string Supplier { get; set; }
        [StringLength(255)]
        public string QCNumber { get; set; }
        [StringLength(255)]
        public string GRNNumber { get; set; }
        [StringLength(255)]
        public string PONo { get; set; }
        [StringLength(255)]
        public string OCNumber { get; set; }
        [StringLength(255)]
        public string Category { get; set; }
        [StringLength(255)]
        public string ArticleName { get; set; }
        public DateTime QCRequestDate { get; set; }
        [StringLength(255)]
        public string StyleName { get; set; }
        [StringLength(255)]
        public string QCDefinition { get; set; }
        [StringLength(255)]
        public string SamplePlan { get; set; }
        public int QCQty { get; set; }

        public int GRNQty { get; set; }
        public bool DefectResult { get; set; } = false;
        public bool FinalResult {get;set; } = false;

        [StringLength(255)]
        public string DeliveryBuyerOrderRef { get; set; }




        [StringLength(255)]
        public string ArticleCode { get; set; }

        [StringLength(255)]
        public string StyleCode { get; set; }

        public double SamplePercentage { get; set; }
        [StringLength(255)]
        public string ColorCode { get; set; }
        [StringLength(25)]
        public string ColorName { get; set; }

        [StringLength(15)]
        public string QCType { get; set; }

        private List<SizeBreakDownDTO> sizeBreakDowns;
        [NotMapped]
        public List<SizeBreakDownDTO> SizeBreakDowns
        {
            get
            {
                sizeBreakDowns ??= string.IsNullOrWhiteSpace(SizeBreakDownsJson) ? null : JsonSerializer.Deserialize<List<SizeBreakDownDTO>>(SizeBreakDownsJson);
                return sizeBreakDowns;
            }
            set
            {
                sizeBreakDowns = value;
                SizeBreakDownsJson = JsonSerializer.Serialize(sizeBreakDowns);
            }
        }
        public string SizeBreakDownsJson { get; set; }

        public string QCNumberRef { get; set; }
        [NotMapped]
        public User UserApprove { get; set; }
        public int UserApproveId { get; set; }


    }
}
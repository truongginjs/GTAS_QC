using QCService.Models;
using QCService.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QCService.DTOs.Responses
{
    public class QCRequestResDBDTO : BaseModel
    {
        public Guid ZoneTypeId { get; set; }
        public TransferStatusEnum TransferStatus { get; set; }
        public DocStatusEnum DocStatus { get; set; }
        public string Site { get; set; }
        public string Buyer { get; set; }
        public string Supplier { get; set; }
        public string QCNumber { get; set; }
        public string GRNNumber { get; set; }
        public string PONo { get; set; }
        public string OCNumber { get; set; }
        public string Category { get; set; }
        public string ArticleName { get; set; }
        public DateTime QCRequestDate { get; set; }
        public string StyleName { get; set; }
        public string QCDefinition { get; set; }
        public string SamplePlan { get; set; }
        public int QCQty { get; set; }
        public string DeliveryBuyerOrderRef { get; set; }
        public string ArticleCode { get; set; }
        public string StyleCode { get; set; }
        public double SamplePercentage { get; set; }
        public string ColorCode { get; set; }
        public string ColorName { get; set; }
        public string QCType { get; set; }
        public User UserApprove { get; set; }
        public int UserApproveId { get; set; }
    }
}

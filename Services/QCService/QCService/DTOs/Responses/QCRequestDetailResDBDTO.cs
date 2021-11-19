using QCService.Models;
using QCService.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QCService.DTOs.Responses
{
    public class QCRequestDetailResDBDTO : BaseModel
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
        public string Code { get; set; }
        public string Name { get; set; }
        public string ProductLine { get; set; }
        public List<InspectionBySizeDTO> InspectionBySizes { get; set; } = null;
        public List<InspectionBySizesPerOCDTO> InspectionBySizesPerOC { get; set; } = null;
        public DefectDetailResDTO DefectDetail { get; set; }
        public object PrivateDetail { get; set; }


        //public string Id { get; set; }
        //public string ZoneTypeId { get; set; }
        //public string QCNumber { get; set; }
        //public string GRNNumber { get; set; }
        //public string Category { get; set; }
        //public string ArticleCode { get; set; }
        //public string ArticleName { get; set; }
        //public DateTime QCRequestDate { get; set; }
        //public string StyleName { get; set; }
        //public string StyleCode { get; set; }
        //public string OCNumber { get; set; }
        //public string QCDefinition { get; set; }
        //public string SamplePlan { get; set; }
        //public double SamplePercentage { get; set; }
        //public string ColorCode { get; set; }
        //public string ColorName { get; set; }
        //public string QCType { get; set; }
        //public int UserApproveId { get; set; }
        //public int TransferStatus { get; set; }
        //public string Description { get; set; }
        //public int CreateUserId { get; set; }
        //public DateTime CreateDate { get; set; }
        //public int UpdateUserId { get; set; }
        //public DateTime UpdateDate { get; set; }
        //public bool IsDeleted { get; set; }
        //public string Buyer { get; set; }
        //public string DeliveryBuyerOrderRef { get; set; }
        //public int DocStatus { get; set; }
        //public string PONo { get; set; }
        //public int QCQty { get; set; }
        //public string Site { get; set; }
        //public string Supplier { get; set; }
        //public string Code { get; set; }
        //public string Name { get; set; }
        //public string ProductLine { get; set; }
        ////public string InspectionBySizes { get; set; }
        ////public string DefectDetail { get; set; }
        ////public string PrivateDetail { get; set; }
    }
}

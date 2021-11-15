using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCService.DTOs.Responses
{
    public class QCRequestsResDTO
    {
        public string TransferStatus { get; set; }
        public string DocStatus { get; set; }
        public string Site { get; set; }
        public string Buyer { get; set; }
        public string QCNumber { get; set; }
        public string GRNNumber { get; set; }
        public string PONo { get; set; }
        public string OCNumber { get; set; }
        public string Category { get; set; }
        public string ArticleName { get; set; }
        public string QCRequestDate { get; set; }
        public string StyleName { get; set; }
        public string QCDefinition { get; set; }
        public string SamplePlan { get; set; }
        public string QCQty { get; set; }
        public string DeliveryBuyerOrderRef { get; set; }
        public string LatestUpdateOn { get; set; }
        public string TransferredOn { get; set; }
    }
}

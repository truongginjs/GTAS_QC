using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QCService.DTOs.Responses
{
    public class FindQCRequestResDTO
    {
        public string Site { get; set; }
        public string Buyer { get; set; }
        public string QCNumber { get; set; }
        public string GRNNumber { get; set; }
        public string PONo { get; set; }
        public string OCNumber { get; set; }
        public string Category { get; set; }
        public string ArticleName { get; set; }
        public string StyleName { get; set; }
        public double GRNQty { get; set; }
    }
}

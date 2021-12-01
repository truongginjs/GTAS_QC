using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QCService.DTOs.Requests
{
    public class FindQCRequestReqDTO
    {
        public string QCNumber { get; set; }
        public string OCNumber { get; set; }
        public string Buyer { get; set; }
        public string PONo { get; set; }
        public string GRNNumber { get; set; }
        public Guid ZonetypeID { get; set; }
    }
}

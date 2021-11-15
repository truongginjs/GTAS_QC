using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCService.DTOs.Requests
{
    public class QCRequestFinalReqDTO
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string QCRequestNo { get; set; }
        public string OCNo { get; set; }
        public string Buyer { get; set; }
        public string PONo { get; set; }
        public string GRNNo { get; set; }
    }
}

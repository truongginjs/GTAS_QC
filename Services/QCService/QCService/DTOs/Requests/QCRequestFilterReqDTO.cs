using System;

namespace QCService.DTOs.Requests
{
    public class QCRequestFilterReqDTO
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string QCNumber { get; set; }
        public string OCNumber { get; set; }
    }
}
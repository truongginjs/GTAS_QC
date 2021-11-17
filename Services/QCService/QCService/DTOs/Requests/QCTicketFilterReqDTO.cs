using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QCService.DTOs.Requests
{
    public class QCTicketFilterReqDTO
    {
        public Guid ZoneTypeId { get; set; }
        public string StringSearch { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

    }
}

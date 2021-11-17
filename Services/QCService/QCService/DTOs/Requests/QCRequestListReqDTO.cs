using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QCService.DTOs.Requests
{
    public class QCRequestListReqDTO
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public List<Guid> ZoneTypeIds { get; set; }
        public List<string> SiteCodes { get; set; }
        public string StringSearch { get; set; }
    }
}

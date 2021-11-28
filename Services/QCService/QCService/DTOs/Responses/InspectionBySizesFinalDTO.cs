using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QCService.DTOs.Responses
{
    public class InspectionBySizesFinalDTO
    {
        public string OCNumber { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public double OrderQty { get; set; }
        public double OfferedQty { get; set; }
        public double InspectionQty { get; set; }
        public double AcceptedQty { get; set; }
    }
}

using QCService.Models.DTOs;
using System;
using System.Collections.Generic;

namespace QCService.DTOs.Responses
{

    public class QCTicketResDTO
    {
        public Guid QCTicketId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ProductLine { get; set; }
        public DefectAQLDTO DefectAQL { get; set; }
        public DefectSizeBreakDownDTO DefectSizeBreakDown { get; set; }
        public List<DefectsReasonAndSolutionDTO> DefectsReasonAndSolutions { get; set; }
        public object PrivateDetail { get; set; }

    }

}
using QCService.DTOs.Responses;
using QCService.Models.DTOs;
using System;
using System.Collections.Generic;

namespace QCService.DTOs.Requests
{
    public class QCRequestUpdateResDTO
    {
        public Guid Id { get; set; }
        public QCTicketResDTO QCTicket { get; set; }

        public Guid ZoneTypeId { get; set; }
        public string Description { get; set; }
        public string QCNumber { get; set; }
        public string GRNNumber { get; set; }
        public string Category { get; set; }
        public string ArticleCode { get; set; }
        public string ArticleName { get; set; }
        public DateTime QCRequestDate { get; set; }
        public string StyleName { get; set; }
        public string StyleCode { get; set; }
        public string OCNumber { get; set; }
        public string QCDefinition { get; set; }
        public string SamplePlan { get; set; }
        public int SamplePercentage { get; set; }
        public string ColorCode { get; set; }
        public string ColorName { get; set; }
        public string QCType { get; set; }
        public List<SizeBreakDownDTO> SizeBreakDowns { get; set; }
        public string SizeBreakDownsJson { get; set; }
        public int UserApproveId { get; set; }

        public string Status { get; set; }
    }
}
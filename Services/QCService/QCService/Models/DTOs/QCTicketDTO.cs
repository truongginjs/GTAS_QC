using QCService.Models.D01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace QCService.Models.DTOs
{
    public class QCTicketDTO
    {
        public Guid Id { get; set; }
        private QCRequest qCRequest { get; set; }
        public QCRequest QCRequest
        {
            get
            {
                qCRequest ??= string.IsNullOrWhiteSpace(QCRequestJson) ? null : JsonSerializer.Deserialize<QCRequest>(QCRequestJson);
                return qCRequest;
            }
            set
            {
                qCRequest = value;
                QCRequestJson = qCRequest == null ? string.Empty : JsonSerializer.Serialize(qCRequest);
            }
        }

        public string QCRequestJson { get; set; }

        public string Code { get; set; }
        public string Name { get; set; }
        public string ProductLine { get; set; }

        private DefectAQLDTO defectAQL;
        public DefectAQLDTO DefectAQL
        {
            get
            {
                defectAQL ??= string.IsNullOrWhiteSpace(DefectAQLJson) ? null : JsonSerializer.Deserialize<DefectAQLDTO>(DefectAQLJson);
                return defectAQL;
            }
            set
            {
                defectAQL = value;
                DefectAQLJson = defectAQL == null ? string.Empty : JsonSerializer.Serialize(defectAQL);
            }
        }

        public string DefectAQLJson { get; set; }

        private InspectionBySizeDTO defectSizeBreakDown;
        public InspectionBySizeDTO DefectSizeBreakDown
        {
            get
            {
                defectSizeBreakDown ??= string.IsNullOrWhiteSpace(DefectSizeBreakDownJson) ? null : JsonSerializer.Deserialize<InspectionBySizeDTO>(DefectSizeBreakDownJson);
                return defectSizeBreakDown;
            }
            set
            {
                defectSizeBreakDown = value;
                DefectAQLJson = defectSizeBreakDown == null ? string.Empty : JsonSerializer.Serialize(defectSizeBreakDown);
            }
        }
        public string DefectSizeBreakDownJson { get; set; }

        private List<DefectsReasonAndSolutionDTO> defectsReasonAndSolutions;
        public List<DefectsReasonAndSolutionDTO> DefectsReasonAndSolutions
        {
            get
            {
                defectsReasonAndSolutions ??= string.IsNullOrWhiteSpace(DefectsReasonAndSolutionsJson) ? null : JsonSerializer.Deserialize<List<DefectsReasonAndSolutionDTO>>(DefectsReasonAndSolutionsJson);
                return defectsReasonAndSolutions;
            }
            set
            {
                defectsReasonAndSolutions = value;
                DefectsReasonAndSolutionsJson = defectsReasonAndSolutions == null ? string.Empty : JsonSerializer.Serialize(defectSizeBreakDown);
            }
        }
        public string DefectsReasonAndSolutionsJson { get; set; }

        private object privateDetail;
        public object PrivateDetail
        {
            get
            {
                privateDetail ??= string.IsNullOrWhiteSpace(PrivateDetailJson) ? null : JsonSerializer.Deserialize<object>(PrivateDetailJson);
                return privateDetail;
            }
            set
            {
                privateDetail = value;
                PrivateDetailJson = privateDetail == null ? string.Empty : JsonSerializer.Serialize(privateDetail);
            }
        }
        public string PrivateDetailJson { get; set; }
        public bool IsDeleted { get; set; }
    }
}

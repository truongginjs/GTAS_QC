using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using LibraryService.Models.DTOs;

namespace LibraryService.Models.L01
{
    [Table("L01_AQLLib")]
    public class AQLLib : BaseModel
    {
        [Required]
        public int RatingMajor { get; set; }=1;
        [Required]
        public int RatingMinor { get; set; } = 1;
        public Guid? ZoneTypeId { get; set; }
        public QCZoneTypeLib ZoneType { get; set; }
        private List<QCRageDTO> qCRages;
        [NotMapped]
        public List<QCRageDTO> QCRages {

            get
            {
                qCRages = string.IsNullOrWhiteSpace(QCRagesJson) ? null : JsonSerializer.Deserialize<List<QCRageDTO>>(QCRagesJson);
                return qCRages;
            }
            set
            {
                qCRages = value;
                QCRagesJson = qCRages == null ? string.Empty : JsonSerializer.Serialize(qCRages);
            }
        }
        public string QCRagesJson { get; set; }
    }
}
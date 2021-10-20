using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QCService.Models
{

    public class QCTicket : BaseModel
    {

        [Required]
        [MaxLength(500)]
        public string Name { get; set; }
        [NotMapped]
        public Factory Factory { get; set; }
        [NotMapped]
        public Buyer Buyer { get; set; }
        public Guid ZoneTypeId { get; set; }
        [NotMapped]
        public ZoneType ZoneType { get; set; }
        public DateTime InputDate { get; set; }
        public DateTime CheckDate { get; set; }
        public int TesterCheckId { get; set; }
        [NotMapped]
        public Tester TesterCheck { get; set; }
        public string ProductLine { get; set; }
        public double Quantity { get; set; }
        [NotMapped]
        public List<Defect> Defects { get; set; }

        public string DefectsJson { get; set; }
        [NotMapped]
        public DefectSizeBreakDown DefectSizeBreakDown { get; set; }
        public string DefectSizeBreakDownJson { get; set; }
        [NotMapped]
        public List<SolutionDefactive> DefectRepairs { get; set; }
        public string DefectRepairsJson { get; set; }
        [NotMapped]
        public object PrivateDetail { get; set; }
        public string PrivateDetailJson { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.DTOs.Requests
{
    public class DefectReqDTO
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public List<string> Reasons { get; set; }
        public List<string> Solutions { get; set; }
        public List<string> DefectTypes { get; set; }
        public Guid? ZoneTypeId { get; set; }
    }
}

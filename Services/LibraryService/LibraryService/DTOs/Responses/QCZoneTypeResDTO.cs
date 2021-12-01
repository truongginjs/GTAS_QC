using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.DTOs.Responses
{
    public class QCZoneTypeResDTO
    {
        public Guid Id { get; set; }
        public int No { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }

        public string Name { get; set; }
        public string GroupType { get; set; }
        public FormLibResDTO Forms { get; set; }

        public string Prefix { get; set; }

    }
}

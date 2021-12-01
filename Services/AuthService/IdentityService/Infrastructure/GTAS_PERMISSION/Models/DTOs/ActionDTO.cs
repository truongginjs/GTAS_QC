using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityService.Infrastructure.GTAS_PERMISSION.Models.DTOs
{
    public class ActionDTO
    {
        public bool Create { get; set; } = false;
        public bool Read { get; set; } = false;
        public bool Update { get; set; } = false;
        public bool Delete { get; set; } = false;
        public bool Approve { get; set; } = false;
        public bool Lock { get; set; } = false;
        public bool Unlock { get; set; } = false;
        public bool Import { get; set; } = false;
        public bool Export { get; set; } = false;
        public bool Admin { get; set; } = false;
        public static readonly string[] ActiveType = new string[] {
        "Create",
        "Read",
        "Update",
        "Delete",
        "Approve",
        "Lock",
        "Unlock",
        "Import",
        "Export",
        "Admin"
        };
    }
}

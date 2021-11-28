using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Models.L01
{
    [Table("L01_DepartmentLib")]
    public class DepartmentLib : BaseModel
    {
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
    }
}

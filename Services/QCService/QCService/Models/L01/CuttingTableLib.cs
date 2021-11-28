using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QCService.Models.L01
{
    [Table("L01_CuttingTableLib")]
    public class CuttingTableLib : BaseModel
    {
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdentityService.Infrastructure.GTAS_PERMISSION.Models
{
    [Table("P01_Page")]
    public class Page : BaseModel
    {
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
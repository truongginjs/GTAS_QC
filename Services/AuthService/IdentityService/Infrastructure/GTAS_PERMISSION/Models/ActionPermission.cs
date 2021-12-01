using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdentityService.Infrastructure.GTAS_PERMISSION.Models
{
    [Table("P01_Action")]
    public class ActionPermission : BaseModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

    }
}
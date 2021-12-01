using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IdentityService.Infrastructure.GTAS_PERMISSION.Models.DTOs;

namespace IdentityService.Infrastructure.GTAS_PERMISSION.Models
{

    [Table("P01_Group")]
    public class GroupPermission : BaseModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public FunctionsDTO Functions { get; set; }
    }
}
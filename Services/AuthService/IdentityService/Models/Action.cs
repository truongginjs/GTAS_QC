using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdentityService.Models;
[Table("P01_Action")]
public class Action : BaseModel
{
    [Required]
    [StringLength(50)]
    public string Code { get; set; }

}
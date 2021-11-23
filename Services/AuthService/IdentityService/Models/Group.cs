using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IdentityService.Models.DTOs;

namespace IdentityService.Models;
[Table("P01_Group")]
public class Group : BaseModel
{
    [Required]
    [StringLength(50)]
    public string Code { get; set; }

    public FunctionsDTO Functions { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace IdentityService.Models;

public class Page : BaseModel
{
    [Required]
    [StringLength(50)]
    public string Code { get; set; }
    [Required]
    [StringLength(100)]
    public string Name { get; set; }
}
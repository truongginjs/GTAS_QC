using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IdentityService.Models.DTOs;

namespace IdentityService.Models;

public class User : BaseModel
{
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string FullName { get; set; }

    public string PermissionJson {get;set;}
    private PermissionDTO permission{get;set;}
    [NotMapped]
    public PermissionDTO Permission{get;set;}
}

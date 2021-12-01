using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IdentityService.Infrastructure.GTAS_MENU.Models;
using IdentityService.Infrastructure.GTAS_PERMISSION.Models.DTOs;

namespace IdentityService.Infrastructure.GTAS_PERMISSION.Models
{
    [Table("P01_User")]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        [NotMapped]
        public TblUser UserInfo { get; set; }
        public string PermissionJson { get; set; }
        private PermissionDTO permission { get; set; }
        [NotMapped]
        public PermissionDTO Permission { get; set; }
    }
}
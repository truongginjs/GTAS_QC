using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdentityService.Infrastructure.GTAS_PERMISSION.Models
{
    [Table("P01_RefreshToken")]
    public class TblRefreshToken
    {
        [Key]
        public Guid ID { get; set; }
        public string RefreshToken { get; set; }
        public int UserId { get; set; }
    }
}
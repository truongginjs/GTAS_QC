using System;
using System.ComponentModel.DataAnnotations;

namespace IdentityService.Infrastructure.GTAS_PERMISSION.Models
{
    public class BaseModel
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public Guid CreateUserId { get; set; }
        public User CreateUser { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public Guid UpdateUserId { get; set; }
        public User UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
    }
}
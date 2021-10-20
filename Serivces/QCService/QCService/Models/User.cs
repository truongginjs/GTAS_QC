using System.ComponentModel.DataAnnotations;

namespace QCService.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public int FullName { get; set; }
        public int UserLogin { get; set; }
    }
}
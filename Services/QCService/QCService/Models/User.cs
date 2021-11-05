using System.ComponentModel.DataAnnotations;

namespace QCService.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string UserLogin { get; set; }
    }
}
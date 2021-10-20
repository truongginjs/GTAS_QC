using System.ComponentModel.DataAnnotations;

namespace LibraryService.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public int FullName { get; set; }
        public int UserLogin { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace LibraryService.Models
{
    public class ZoneType : BaseModel
    {
        [Required]
        [StringLength(500)]
        public string Name{get;set;}
        
    }
}
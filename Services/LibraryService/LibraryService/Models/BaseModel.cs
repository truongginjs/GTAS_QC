using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryService.Models
{
    public abstract class BaseModel
    {
        [Key]
        public Guid Id{get;set;}
        [StringLength(500)]
        public string Description {get;set;}
        // public int CreateUserId {get;set;}
        // [NotMapped]
        // public User CreateUser {get;set;}
        // public DateTime CreateDate {get;set;}
        // public int UpdateUserId {get;set;}
        // [NotMapped]
        // public User UpdateUser {get;set;}

        // public DateTime UpdateDate {get;set;}

    }
}
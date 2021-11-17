using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QCService.Models
{
    public abstract class BaseModel
    {
        [Key]
        public virtual Guid Id{get;set;}
        [StringLength(500)]
        public virtual string Description {get;set;}
        public virtual int CreateUserId {get;set;}
        // [NotMapped]
        // public virtual User CreateUser {get;set;}
        public virtual DateTime CreateDate { get; set; } = DateTime.Now;
        public virtual int UpdateUserId {get;set;}
        // [NotMapped]
        // public virtual User UpdateUser {get;set;}
        public virtual DateTime UpdateDate {get;set;} = DateTime.Now;
        public bool IsDeleted { get; set; } = false;

    }
}
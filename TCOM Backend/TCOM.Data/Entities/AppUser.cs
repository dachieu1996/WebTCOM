using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TCOM.Core.Enums;
using TCOM.Core.SharedCore;

namespace TCOM.Data.Entities
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser<Guid>, IDomainEntity
    {
        public string Email { get; set; }
        //public string PhoneNumber { get; set; }
      //  public string PasswordHash { get; set; }
       // public string UserName { get; set; }
        public Guid RoleId { get; set; }
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
    }
}

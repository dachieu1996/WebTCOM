using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TCOM.Core.SharedCore;

namespace TCOM.Data.Entities
{
    [Table("UserRole")]
    public class UserRole : DomainEntity<int>
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
    }
}

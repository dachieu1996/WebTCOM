using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using TCOM.Core.SharedCore;

namespace TCOM.Data.Entities
{
    [Table("RolePermission")]
    public class RolePermisson : DomainEntity<int>
    {
        public Guid RoleId { get; set; }
        public int PermissionId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using TCOM.Core.SharedCore;

namespace TCOM.Data.Entities
{
    [Table("Permisson")]
    public class Permisson : DomainEntity<int>
    {
        public string Key { get; set; }
        public string Name { get; set; }
    }
}

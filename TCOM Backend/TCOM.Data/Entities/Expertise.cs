using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TCOM.Core.SharedCore;

namespace TCOM.Data.Entities
{
    [Table("Expertise")] 
    public class Expertise : DomainEntity<int>
    {
    
        public string Content { get; set; }
        public int Order { get; set; }
        public int ServiceTypeDetailId { get; set; }
        public int LanguageId { get; set; }
    }
}

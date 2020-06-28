using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TCOM.Core.SharedCore;

namespace TCOM.Data.Entities
{ 
    [Table("Partner")] 
    public class Partner : DomainEntity<int>
    {
        public string Name { get; set; }
        public int ImgId { get; set; }
        public string ImgUrl { get; set; }
        public int Order { get; set; }
    }
}

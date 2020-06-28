using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TCOM.Core.SharedCore;

namespace TCOM.Data.Entities
{
    [Table("ProgrammingLanguage")]
    public class ProgrammingLanguage : DomainEntity<int>
    {
        public string Label { get; set; }
        public string ImgUrl { get; set; }
        public int ImgId { get; set; }
        public int Order { get; set; }
        public int ServiceTypeId { get; set; }
    }
}

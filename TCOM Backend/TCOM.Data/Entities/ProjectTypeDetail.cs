using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TCOM.Core.SharedCore;

namespace TCOM.Data.Entities
{
    [Table("ProjectTypeDetail")]
    public class ProjectTypeDetail : DomainEntity<int>
    {
        public string Description { get; set; }
        public int LanguageId { get; set; }
        public int ProjectTypeId { get; set; }
    }
}


using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TCOM.Core.Enums;
using TCOM.Core.SharedCore;

namespace TCOM.Data.Entities
{
    [Table("Library")] 
    public class Library : DomainEntity<int>
    {
        public string StorageLocation { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public Type Type { get; set; }
    }
}

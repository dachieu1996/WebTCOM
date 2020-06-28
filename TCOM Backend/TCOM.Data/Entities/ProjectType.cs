using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TCOM.Core.SharedCore;

namespace TCOM.Data.Entities
{
    [Table("ProjectType")]
    public class ProjectType : DomainEntity<int>
    {
        public string Header { get; set; }
        public string Task { get; set; }
        public string Customer { get; set; }
        public string Url { get; set; }
        public string Technology { get; set; }
        public string Platform { get; set; }
        public string ImgUrl { get; set; }
        public int ImgId { get; set; }
        public ICollection<ProjectTypeDetail> ProjectTypeDetails { get; set; }
    }
}

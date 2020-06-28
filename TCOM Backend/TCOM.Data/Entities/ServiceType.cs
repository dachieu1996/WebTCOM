using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TCOM.Core.SharedCore;

namespace TCOM.Data.Entities
{
    [Table("ServiceType")]
    public class ServiceType : DomainEntity<int>
    {
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public string SmallImgUrl { get; set; }
        public string IconUrl { get; set; }
        public ICollection<ServiceTypeDetail> ServiceTypeDetails { get; set; }
        public ICollection<ProgrammingLanguage> ProgrammingLanguages { get; set; }
    }
}

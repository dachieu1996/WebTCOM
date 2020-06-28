using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using TCOM.Core.SharedCore;

namespace TCOM.Data.Entities
{
    [Table("ServiceTypeDetail")]
    public class ServiceTypeDetail : DomainEntity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string MainHeader { get; set; }
        public string MainContent { get; set; }
        public string ExpertiseHeader { get; set; }
        public string ExpertiseContent { get; set; }
        public ICollection<Expertise> Expertises { get; set; }
        public ICollection<ServiceSubDetail> ServiceSubDetails { get; set; }
        public int LanguageId { get; set; }
        public int ServiceTypeId { get; set; }
       
    }
}

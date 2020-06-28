using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TCOM.Core.SharedCore;

namespace TCOM.Data.Entities
{
   
    [Table("ServiceSubDetail")]
    public class ServiceSubDetail : DomainEntity<int>
    {
        public string Content { get; set; }
        public int Order { get; set; }
        public int ServiceTypeDetailId { get; set; }
        public int LanguageId { get; set; }
    }
}

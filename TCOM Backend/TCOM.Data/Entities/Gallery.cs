using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TCOM.Core.SharedCore;

namespace TCOM.Data.Entities
{
    [Table("Gallery")]
    public class Gallery : DomainEntity<int>
    {
        public int ImgId { get; set; }
        public string ImgUrl { get; set; }
        public int Order { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TCOM.Core.SharedCore;

namespace TCOM.Data.Entities
{
    [Table("ServiceHome")]
    public class ServiceHome : DomainEntity<int>
    {
        public string Title { get; set; }
        public string SubContent { get; set; }
        public string MainHeader { get; set; }
        public string ImgUrl { get; set; }
        public int ImgId { get; set; }
        public string MainContent { get; set; }
        public string SecondHeader { get; set; }
        public int LanguageId { get; set; }
    }
}

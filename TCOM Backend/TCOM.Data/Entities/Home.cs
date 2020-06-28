using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TCOM.Core.SharedCore;

namespace TCOM.Data.Entities
{
    [Table("Home")]
    public class Home : DomainEntity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string MainHeader { get; set; }
        public string MainContent { get; set; }
        public string ServiceHeader { get; set; }
        public string ServiceContent { get; set; }
        public string TechHeader { get; set; }
        public string TechContent { get; set; }
        public string PartnerHeader { get; set; }
        public string PartnerContent { get; set; }
        public string FirstImgUrl { get; set; }
        public int FirstImgId { get; set; }
        public string SencondImgUrl { get; set; }
        public int SencondImgId { get; set; }
        public int LanguageId { get; set; }
    }
}

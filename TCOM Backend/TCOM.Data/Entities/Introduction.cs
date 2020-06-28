using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TCOM.Core.SharedCore;

namespace TCOM.Data.Entities
{
    [Table("Introduction")]
    public class Introduction : DomainEntity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string MainHeader { get; set; }
        public string MainContent { get; set; }
        public string SubContent { get; set; }
        public string LeftHeader { get; set; }
        public string LeftContent { get; set; }
        public string LeftImgUrl { get; set; }
        public int LeftImgId { get; set; }
        public string RightHeader { get; set; }
        public string RightContent { get; set; }
        public string RightImgUrl { get; set; }
        public int RightImgId { get; set; }
        public int LanguageId { get; set; }
    }
}

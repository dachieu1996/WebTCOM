using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TCOM.Core.SharedCore;

namespace TCOM.Data.Entities
{
    [Table("Project")]
    public class Project : DomainEntity<int>
    {
        public string Title { get; set; }
        public string SubContent { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public int ImgId { get; set; }
        public int LanguageId { get; set; }
    }
}

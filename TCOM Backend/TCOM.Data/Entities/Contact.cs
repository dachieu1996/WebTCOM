using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TCOM.Core.SharedCore;

namespace TCOM.Data.Entities
{
    [Table("Contact")]
    public class Contact : DomainEntity<int>
    {
        public string Title { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public int ImgId { get; set; }
        public string ImgUrl { get; set; }
        public int LanguageId { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string  Phone { get; set; }
        public string MapUrl { get; set; }
        public string Official { get; set; }
        public string SubContent { get; set; }
    }
}

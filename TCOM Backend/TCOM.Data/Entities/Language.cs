using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TCOM.Core.SharedCore;

namespace TCOM.Data.Entities
{
    [Table("Language")]
    public class Language : DomainEntity<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public ICollection<Home> Homes { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<ProjectType> ProjectTypes { get; set; }
        public ICollection<Introduction> Introductions { get; set; }
        public ICollection<ServiceHome> Services { get; set; }
        public ICollection<ServiceTypeDetail> ServiceTypes { get; set; }
        public ICollection<Contact> Contacts { get; set; }
        public ICollection<ServiceSubDetail> ServiceSubDetails { get; set; }
        public ICollection<Expertise> Expertises { get; set; }
        public ICollection<Engagement> Engagements { get; set; }
        public ICollection<ProjectTypeDetail> ProjectTypeDetails { get; set; }
    }
}

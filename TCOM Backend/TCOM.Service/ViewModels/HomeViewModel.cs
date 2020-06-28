using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Data.Entities;

namespace TCOM.Service.ViewModels
{
    public class HomeViewModel
    {
        public int Id { get; set; }
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

    public class HomeCreateViewModel
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

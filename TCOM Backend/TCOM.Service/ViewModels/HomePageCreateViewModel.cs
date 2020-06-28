using System;
using System.Collections.Generic;
using System.Text;

namespace TCOM.Service.ViewModels
{
    public class HomePageCreateViewModel
    {
        public string Title { get; set; }
        public string ServiceContent { get; set; }
        public string TechContent { get; set; }
        public string PartnerContent { get; set; }
        public string FirstImg { get; set; }
        public string SencondImg { get; set; }
        public int LanguageId { get; set; }
    }
}

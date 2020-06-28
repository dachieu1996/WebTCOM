using System;
using System.Collections.Generic;
using System.Text;

namespace TCOM.Service.ViewModels
{
    public class ServiceTypeDetailViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MainHeader { get; set; }
        public string MainContent { get; set; }
        public string ExpertiseHeader { get; set; }
        public string ExpertiseContent { get; set; }
        public string ImgUrl { get; set; }
        public string SmallImgUrl { get; set; }
        public string IconIUrl { get; set; }
        public int ServiceTypeId { get; set; }
        public int LanguageId { get; set; }
        public List<ExpertiseViewModel> Expertises { get; set; }
        public List<ServiceSubDetailViewModel> ServiceSubDetails { get; set; }
    }

    public class ServiceTypeDetailCreateViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string MainHeader { get; set; }
        public string MainContent { get; set; }
        public string ExpertiseHeader { get; set; }
        public string ExpertiseContent { get; set; }
        public int ServiceTypeId { get; set; }
        public int LanguageId { get; set; }
    }
}

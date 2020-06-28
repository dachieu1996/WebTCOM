using System;
using System.Collections.Generic;
using System.Text;

namespace TCOM.Service.ViewModels
{
    public class ServiceSubDetailViewModel
    {
        public string Id { set; get; }
        public string Content { get; set; }
        public int ServiceTypeDetailId { get; set; }
        public int Order { get; set; }
        public int LanguageId { get; set; }
    }
    public class ServiceSubDetailCreateViewModel
    {
        public string Content { get; set; }
        public int ServiceTypeDetailId { get; set; }
        public int Order { get; set; }
        public int LanguageId { get; set; }
    }
}

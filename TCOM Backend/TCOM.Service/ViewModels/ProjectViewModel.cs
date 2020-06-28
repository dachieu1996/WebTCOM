using System;
using System.Collections.Generic;
using System.Text;

namespace TCOM.Service.ViewModels
{
    public class ProjectViewModel
    {
        public int Id { set; get; }
        public string Title { get; set; }
        public string SubContent { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public int LanguageId { get; set; }
        public int ImgId { get; set; }
    }
    public class ProjectCreateViewModel
    {
        public string Title { get; set; }
        public string SubContent { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public int LanguageId { get; set; }
        public int ImgId { get; set; }
    }
}

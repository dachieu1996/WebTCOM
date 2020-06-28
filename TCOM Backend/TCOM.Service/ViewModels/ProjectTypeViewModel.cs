using System;
using System.Collections.Generic;
using System.Text;

namespace TCOM.Service.ViewModels
{
    public class ProjectTypeViewModel
    {
        public int Id { set; get; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string Task { get; set; }
        public string Customer { get; set; }
        public string Url { get; set; }
        public string Technology { get; set; }
        public string Platform { get; set; }
        public string ImgUrl { get; set; }
        public int ImgId { get; set; }
    }
    public class ProjectTypeCreateViewModel
    {
        public string Header { get; set; }
        public string Description { get; set; }
        public string Task { get; set; }
        public string Customer { get; set; }
        public string Url { get; set; }
        public string Technology { get; set; }
        public string Platform { get; set; }
        public string ImgUrl { get; set; }
        public int ImgId { get; set; }
    }
}

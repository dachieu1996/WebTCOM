using System;
using System.Collections.Generic;
using System.Text;

namespace TCOM.Service.ViewModels
{
    public class SerViewModel
    {
        public int Id  { get; set; }
        public string Title { get; set; }
        public string SubContent { get; set; }
        public string MainHeader { get; set; }
        public string ImgUrl { get; set; }
        public string MainContent { get; set; }
        public string SecondHeader { get; set; }
        public int LanguageId { get; set; }
        public int ImgId { get; set; }
    }
    public class SerCreateViewModel
    {
        public string Title { get; set; }
        public string SubContent { get; set; }
        public string MainHeader { get; set; }
        public string ImgUrl { get; set; }
        public string MainContent { get; set; }
        public string SecondHeader { get; set; }
        public int LanguageId { get; set; }
        public int ImgId { get; set; }
    }
}

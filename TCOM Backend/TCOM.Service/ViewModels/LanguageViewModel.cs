using System;
using System.Collections.Generic;
using System.Text;

namespace TCOM.Service.ViewModels
{
    public class LanguageViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ImgUrl { get; set; }
    }
    public class LanguageCreateViewModel
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string ImgUrl { get; set; }
    }
}

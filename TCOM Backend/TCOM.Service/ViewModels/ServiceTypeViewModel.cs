using System;
using System.Collections.Generic;
using System.Text;

namespace TCOM.Service.ViewModels
{
    public class ServiceTypeViewModel
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public string SmallImgUrl { get; set; }
        public string IconUrl { get; set; }
    }
    public class ServiceTypeCreateViewModel
    {
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public string SmallImgUrl { get; set; }
        public string IconUrl { get; set; }
    }
}

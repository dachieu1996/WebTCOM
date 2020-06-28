using System;
using System.Collections.Generic;
using System.Text;

namespace TCOM.Service.ViewModels
{
    public class GalleryViewModel
    {
        public int Id { set; get; }
        public int ImgId { get; set; }
        public string ImgUrl { get; set; }
        public int Order { get; set; }
    }
    public class GalleryCreateViewModel
    {
        public int ImgId { get; set; }
        public string ImgUrl { get; set; }
        public int Order { get; set; }
    }
}

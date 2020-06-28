using System;
using System.Collections.Generic;
using System.Text;

namespace TCOM.Service.ViewModels
{
    public class PartnerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ImgId { get; set; }
        public string ImgUrl { get; set; }
        public int Order { get; set; }
    }

    public class PartnerCreateViewModel
    {
        public string Name { get; set; }
        public int ImgId { get; set; }
        public string ImgUrl { get; set; }
        public int Order { get; set; }
    }
}

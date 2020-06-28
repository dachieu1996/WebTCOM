using System;
using System.Collections.Generic;
using System.Text;

namespace TCOM.Service.ViewModels
{
        public class ProgrammingLanguageViewModel
        {
            public int Id { get; set; }
            public string Label { get; set; }
            public string ImgUrl { get; set; }
            public int ImgId { get; set; }
            public int Order { get; set; }
            public int ServiceTypeId { get; set; }
        }
        public class ProgrammingLanguageCreateViewModel
        {
            public string Label { get; set; }
            public string ImgUrl { get; set; }
            public int ImgId { get; set; }
            public int Order { get; set; }
            public int ServiceTypeId { get; set; }
        }
    }

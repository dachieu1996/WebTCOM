using System;
using System.Collections.Generic;
using System.Text;

namespace TCOM.Service.ViewModels
{
    public class ExpertiseViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Order { get; set; }
        public int ServiceTypeDetailId { get; set; }
        public int LanguageId { get; set; }
    }
    public class ExpertiseCreateViewModel
    {
        public string Content { get; set; }
        public int Order { get; set; }
        public int ServiceTypeDetailId { get; set; }
        public int LanguageId { get; set; }
    }
}

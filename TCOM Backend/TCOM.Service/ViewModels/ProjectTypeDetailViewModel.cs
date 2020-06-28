using System;
using System.Collections.Generic;
using System.Text;

namespace TCOM.Service.ViewModels
{
    public class ProjectTypeDetailViewModel
    {
        public int Id { set; get; }
        public string Description { get; set; }
        public int LanguageId { get; set; }
        public int ProjectTypeId { get; set; }
    }

    public class ProjectTypeDetailCreateViewModel
    {
        public string Description { get; set; }
        public int LanguageId { get; set; }
        public int ProjectTypeId { get; set; }
    }
}

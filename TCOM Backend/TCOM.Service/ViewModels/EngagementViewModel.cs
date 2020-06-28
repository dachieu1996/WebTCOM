using System;
using System.Collections.Generic;
using System.Text;

namespace TCOM.Service.ViewModels
{
    public class EngagementViewModel
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class EngagementCreateViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

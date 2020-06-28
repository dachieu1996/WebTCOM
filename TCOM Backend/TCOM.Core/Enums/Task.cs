using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TCOM.Core.Enums
{
    public enum Task
    {
        [Display(Name = "Mobile App")] mobileapp = 1,
        [Display(Name = "Windows")] windows = 2,
        [Display(Name = "Desktop Software")] desktopsoftware = 3,
        [Display(Name = "IOS")] IOS = 4,
        [Display(Name = "Android")] android = 5,
        [Display(Name = "Service")] service = 6,
        [Display(Name = "Web")] web = 7,
        [Display(Name = "Platform")] platform = 8,
    }
}

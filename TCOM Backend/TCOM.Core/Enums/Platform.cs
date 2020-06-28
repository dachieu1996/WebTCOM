using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TCOM.Core.Enums
{
    public enum Platform
    {
        [Display(Name = "Window")] Window = 1,
        [Display(Name = "MacOS")] MacOS = 2,
        [Display(Name = "iOS")] iOS = 3,
        [Display(Name = "Android")] Android = 4,
        [Display(Name = "Mobile")] Mobile = 5,
        [Display(Name = "Web")] Web = 6,
    }
}

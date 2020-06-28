using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace TCOM.Core.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status
    {
        [Display(Name = "Active")] Active = 1,
        [Display(Name = "Inactive")] Inactive = 0,
    }
}

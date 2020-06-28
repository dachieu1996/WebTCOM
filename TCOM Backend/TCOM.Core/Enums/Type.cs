using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace TCOM.Core.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type
    {
        [Display(Name = "Image")] Image = 1,
        [Display(Name = "Video")] Video = 2,
        [Display(Name = "Document")] Document = 3,
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TCOM.Core.SharedCore;

namespace TCOM.Data.Entities
{
    public class Engagement : DomainEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int LanguageId { get; set; }
    }
}

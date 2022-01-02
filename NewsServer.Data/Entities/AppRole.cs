using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsServer.Data.Entities
{
    public class AppRole : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<AppUser> AppUser { get; set; }
    }
}

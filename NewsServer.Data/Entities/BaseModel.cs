using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsServer.Data.Entities
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }

        public Guid Created_by { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }
}

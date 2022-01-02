using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsServer.Data.Entities
{
    public class Saved : BaseModel
    {
        public Guid NewsId { get; set; }
        public int Status { get; set; }
    }
}

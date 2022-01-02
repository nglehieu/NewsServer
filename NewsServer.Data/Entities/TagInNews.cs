using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsServer.Data.Entities
{
    public class TagInNews
    {
        public Guid Id { get; set; }
        public Guid TagId { get; set; } 
        public Guid NewsId { get; set; }

    }
}

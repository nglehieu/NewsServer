using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsServer.Data.Entities
{
     public class Subscribe : BaseModel
    {
        public string Email { get; set; }
        public Guid Subscribe_at { get; set; }
        public int Status { get; set; }

        
    }
}

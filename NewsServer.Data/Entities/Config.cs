using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsServer.Data.Entities
{
    public class Config : BaseModel
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public int Status { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsServer.Data.Entities
{
    public class News : BaseModel
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public string Description { get; set; }
        public int ViewCount { get; set; }
        public string Tags { get; set; }
        public int Status { get; set; }
        public string locked { get; set; }
        public Guid Category_id { get; set; }
    }
}

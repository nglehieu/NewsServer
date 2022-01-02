using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewsServer.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsServer.Data.Configuration
{
    public class TagInNewsConfiguration : IEntityTypeConfiguration<TagInNews>
    {
        public void Configure(EntityTypeBuilder<TagInNews> builder)
        {
            builder.ToTable("TagInNews");
            builder.HasKey(t => t.Id);
        }
    }
}

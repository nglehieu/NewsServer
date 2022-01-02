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
    public class SavedConfiguration : IEntityTypeConfiguration<Saved>
    {
        public void Configure(EntityTypeBuilder<Saved> builder)
        {
            builder.ToTable("Saveds");
            builder.HasKey(x => x.Id);
        }
    }
}

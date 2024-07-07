using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WOU.Core.Models;

namespace WOU.EF.ModelsConfiguration
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(e=>e.Name).HasMaxLength(18);
            builder.Property(e => e.LastSeen)
                .HasAnnotation("DefaultValue", "getdate()");
        }
    }
}

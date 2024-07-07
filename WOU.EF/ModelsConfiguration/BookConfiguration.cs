using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WOU.Core.Models;

namespace WOU.EF.ModelsConfiguration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(e=>e.Name).HasMaxLength(18);
            
            builder.Property(e => e.RealseDate)
                .HasAnnotation("DefaultValue", "getdate()");
            
            builder.HasOne(e => e.Author)
                .WithMany(e=>e.Books)
                .HasForeignKey(e => e.AuthorId);
        }
    }}

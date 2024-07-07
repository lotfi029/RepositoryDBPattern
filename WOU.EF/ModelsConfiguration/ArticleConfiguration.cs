using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WOU.Core.Models;

namespace WOU.EF.ModelsConfiguration
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(e=>e.Title).HasMaxLength(18);
            
            builder.Property(e => e.RealseDate)
                .HasAnnotation("DefaultValue", "getdate()");

            builder.HasOne(e => e.Author)
                .WithMany(e => e.Articles)
                .HasForeignKey(e => e.AuthorId);


        }
    }
}

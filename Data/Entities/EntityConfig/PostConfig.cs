using System;
using System.Data.Entity.ModelConfiguration;

namespace Data.Entities.EntityConfig
{
    public class PostConfig : EntityTypeConfiguration<Post>
    {
        public PostConfig()
        {
            ToTable("Posts");

            HasKey(e => e.Id);

            Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(150);

            Property(e => e.ShortDescription)
                .IsRequired()
                .HasMaxLength(250);

            Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(10000);

            Property(e => e.UrlSlug)
                .IsRequired()
                .HasMaxLength(160);
        }
    }
}

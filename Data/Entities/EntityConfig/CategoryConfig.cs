using Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.EntityConfig
{
    public class CategoryConfig : EntityTypeConfiguration<Category>
    {
        public CategoryConfig()
        {
            ToTable("Categories");

            HasKey(e => e.Id);

            Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(250);

            Property(e => e.UrlSlug)
                .IsRequired()
                .HasMaxLength(60);
        }
    }
}

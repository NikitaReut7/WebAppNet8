using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Context.Configurations
{
    public class DerivedEntityBConfiguration : IEntityTypeConfiguration<DerivedEntityB>
    {
        public void Configure(EntityTypeBuilder<DerivedEntityB> builder)
        {
            builder.ToTable("DerivedEntitiesB");
            builder.Property(e => e.PropertyB).IsRequired().HasMaxLength(300);

        }
    }
}

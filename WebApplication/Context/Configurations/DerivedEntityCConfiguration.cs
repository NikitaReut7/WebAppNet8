using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Context.Configurations
{
    public class DerivedEntityCConfiguration : IEntityTypeConfiguration<DerivedEntityC>
    {
        public void Configure(EntityTypeBuilder<DerivedEntityC> builder)
        {
            builder.ToTable("DerivedEntitiesC");
            builder.Property(e => e.PropertyC).IsRequired().HasMaxLength(300);

            builder.OwnsOne(c => c.Point, point => {
                point.Property(c => c.Id).HasColumnName("Id");
                point.Property(c => c.Value).HasColumnName("Value");

            });
            builder.ComplexProperty(c => c.Money, point => {
                point.Property(c => c.Count).HasColumnName("Count");
                point.Property(c => c.MoneyString).HasColumnName("MoneyString");

            });
        }
    }
}

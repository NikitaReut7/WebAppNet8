using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Context.Configurations
{
    public class DerivedEntityAConfiguration : IEntityTypeConfiguration<DerivedEntityA>
    {
        public void Configure(EntityTypeBuilder<DerivedEntityA> builder)
        {
            builder.ToTable("DerivedEntitiesA");
            builder.Property(e => e.PropertyA).IsRequired().HasMaxLength(200);

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

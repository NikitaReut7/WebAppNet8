using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Context.Configurations
{
    public class BaseEntityConfiguration : IEntityTypeConfiguration<BaseEntity>
    {
        public void Configure(EntityTypeBuilder<BaseEntity> builder)
        {
            builder.ToTable("BaseEntities");
            builder.HasKey(e => e.BaseNumber);
            builder.Property(e => e.Name).IsRequired().HasMaxLength(100);


        }
    }
}

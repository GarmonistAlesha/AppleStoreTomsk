using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartphonesStoreTomskInfrastrutcture.Entites;

namespace SmartphonesStoreTomskInfrastrutcture.Configuration
{
    internal class SamsungConfiguration : IEntityTypeConfiguration<SamsungEntity>
    {
        public void Configure(EntityTypeBuilder<SamsungEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(b => b.Model)
                .IsRequired();
            builder.Property(b => b.Description)
                .IsRequired();
            builder.Property(b => b.Quantity)
                .IsRequired();
        }
    }
}

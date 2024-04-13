using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartphonesStoreTomskInfrastrutcture.Entites;

namespace SmartphonesStoreTomskInfrastrutcture.Configuration
{
    public class AppleConfiguration : IEntityTypeConfiguration<AppleEntity>
    {
        public void Configure(EntityTypeBuilder<AppleEntity> builder)
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

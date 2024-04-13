using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartphonesStoreTomskInfrastrutcture.Entites;

namespace SmartphonesStoreTomskInfrastrutcture.Configuration
{
    public class XiaomiConfiguration  : IEntityTypeConfiguration<XiaomiEntity>
    {
        public void Configure(EntityTypeBuilder<XiaomiEntity> builder)
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

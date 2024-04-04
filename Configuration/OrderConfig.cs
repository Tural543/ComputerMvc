using ComputerStore.Class;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComputerStore.Configuration
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
               .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .UseIdentityColumn(1, 1);

            builder
                .Property(x => x.Address)
                .IsRequired()
                .HasColumnName("ADDRESS");

            builder.Property(x => x.CustomerId)
                .ValueGeneratedNever();

            builder.Property(x => x.OrderDate)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}

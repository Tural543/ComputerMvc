using ComputerStore.Class;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComputerStore.Configuration
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
               .HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn(1, 1);

            builder
                .Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .HasMany(x => x.Orders)
                .WithOne(x => x.Customer)
                .HasForeignKey(x => x.CustomerId);
        }
    }
}

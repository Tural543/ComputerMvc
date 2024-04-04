using ComputerStore.Class;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComputerStore.Configuration
{
    public class ComputerConfig : IEntityTypeConfiguration<Computer>
    {
        public void Configure(EntityTypeBuilder<Computer> builder)
        {
            builder
               .HasKey(x => x.Id);

            builder.HasOne(x => x.Marka).WithOne(x => x.Computer).HasForeignKey<Computer>(x => x.MarkaId);


            builder.Property(x => x.Id)
                .UseIdentityColumn(1, 1);

            builder
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("NAME");
        }
    }
}
    


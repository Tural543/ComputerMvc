using ComputerStore.Class;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComputerStore.Configuration
{
    public class MarkaConfig : IEntityTypeConfiguration<Marka>
    {
        public void Configure(EntityTypeBuilder<Marka> builder)
        {
            builder
               .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .UseIdentityColumn(1, 1);

            builder.
                Property(x => x.Name)
                .IsRequired(true)
                .HasColumnName("NAME");
        }
    }
}

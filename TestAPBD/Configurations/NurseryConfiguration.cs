using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestAPBD.Entities;

namespace TestAPBD.Configurations
{
    public class NurseryConfiguration : IEntityTypeConfiguration<Nursery>
    {
        public void Configure(EntityTypeBuilder<Nursery> builder)
        {
            builder.HasKey(n => n.NurseryId);
            builder.Property(n => n.Name).HasMaxLength(100);
            builder.HasData(
                new Nursery { NurseryId = 1, Name = "Green Thumb Nursery", EstablishedDate = new DateTime(2000, 5, 15) },
                new Nursery { NurseryId = 2, Name = "Sunny Seeds Nursery", EstablishedDate = new DateTime(2010, 3, 10) }
            );
        }
    }
}

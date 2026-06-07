using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestAPBD.Entities;

namespace TestAPBD.Configurations
{
    public class Tree_SpeciesConfiguration : IEntityTypeConfiguration<Tree_Species>
    {
        public void Configure(EntityTypeBuilder<Tree_Species> builder)
        {
            builder.HasKey(ts => ts.SpeciesId);
            builder.Property(ts => ts.LatinName).HasMaxLength(100);
            builder.HasData(
                new Tree_Species { SpeciesId = 1, LatinName = "Quercus robur", GrowthTimeInYears = 50 },
                new Tree_Species { SpeciesId = 2, LatinName = "Pinus sylvestris", GrowthTimeInYears = 30 }
            );
        }
    }
}

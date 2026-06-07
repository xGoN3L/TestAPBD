using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestAPBD.Entities;

namespace TestAPBD.Configurations
{
    public class Seedling_BatchConfiguration : IEntityTypeConfiguration<Seedling_Batch>
    {
        public void Configure(EntityTypeBuilder<Seedling_Batch> builder)
        {
            builder.HasKey(s => s.BatchId);
            builder.HasOne(r => r.Nursery).WithMany(e => e.SeedlingBatches).HasForeignKey(r => r.NurseryId);
            builder.HasOne(r => r.Species).WithMany(e => e.SeedlingBatches).HasForeignKey(r => r.SpeciesId);
            builder.HasData(
                new Seedling_Batch
                {
                    BatchId = 1,
                    NurseryId = 1,
                    SpeciesId = 1,
                    Quantity = 100,
                    SownDate = new DateTime(2024, 1, 1),
                    ReadyDate = new DateTime(2024, 3, 1)
                },
                new Seedling_Batch
                {
                    BatchId = 2,
                    NurseryId = 1,
                    SpeciesId = 2,
                    Quantity = 150,
                    SownDate = new DateTime(2024, 2, 1),
                    ReadyDate = new DateTime(2024, 4, 1)
                }
            );
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestAPBD.Entities;

namespace TestAPBD.Configurations
{
    public class ResponsibleConfiguration : IEntityTypeConfiguration<Responsible>
    {
        public void Configure(EntityTypeBuilder<Responsible> builder)
        {
            builder.HasOne(r => r.Employee).WithMany(e => e.Responsibles).HasForeignKey(r => r.EmployeeId);
            builder.HasOne(r => r.Batch).WithMany(b => b.Responsibles).HasForeignKey(r => r.BatchId);
            builder.HasKey(r => new { r.EmployeeId, r.BatchId });
            builder.Property(r => r.Role).HasMaxLength(100);
            builder.HasData(
                new Responsible { EmployeeId = 1, BatchId = 1, Role = "Manager" },
                new Responsible { EmployeeId = 2, BatchId = 1, Role = "Worker" }
            );
        }
    }
}

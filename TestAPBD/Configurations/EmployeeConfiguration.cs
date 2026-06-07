using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestAPBD.Entities;

namespace TestAPBD.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.EmployeeId);
            builder.Property(e => e.FirstName).HasMaxLength(100);
            builder.Property(e => e.LastName).HasMaxLength(100);
            builder.HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    HireDate = new DateTime(2020, 1, 1)
                },
                new Employee
                {
                    EmployeeId = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    HireDate = new DateTime(2021, 6, 15)
                }
            );
        }
    }
}

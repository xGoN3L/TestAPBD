using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestAPBD.Migrations
{
    /// <inheritdoc />
    public partial class addSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "FirstName", "HireDate", "LastName" },
                values: new object[,]
                {
                    { 1, "John", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doe" },
                    { 2, "Jane", new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smith" }
                });

            migrationBuilder.InsertData(
                table: "Nursery",
                columns: new[] { "NurseryId", "EstablishedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Green Thumb Nursery" },
                    { 2, new DateTime(2010, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunny Seeds Nursery" }
                });

            migrationBuilder.InsertData(
                table: "Tree_Species",
                columns: new[] { "SpeciesId", "GrowthTimeInYears", "LatinName" },
                values: new object[,]
                {
                    { 1, 50, "Quercus robur" },
                    { 2, 30, "Pinus sylvestris" }
                });

            migrationBuilder.InsertData(
                table: "Seedling_Batch",
                columns: new[] { "BatchId", "NurseryId", "Quantity", "ReadyDate", "SownDate", "SpeciesId" },
                values: new object[,]
                {
                    { 1, 1, 100, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 1, 150, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "Responsible",
                columns: new[] { "BatchId", "EmployeeId", "Role" },
                values: new object[,]
                {
                    { 1, 1, "Manager" },
                    { 1, 2, "Worker" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Nursery",
                keyColumn: "NurseryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Responsible",
                keyColumns: new[] { "BatchId", "EmployeeId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Responsible",
                keyColumns: new[] { "BatchId", "EmployeeId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Seedling_Batch",
                keyColumn: "BatchId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seedling_Batch",
                keyColumn: "BatchId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tree_Species",
                keyColumn: "SpeciesId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Nursery",
                keyColumn: "NurseryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tree_Species",
                keyColumn: "SpeciesId",
                keyValue: 1);
        }
    }
}

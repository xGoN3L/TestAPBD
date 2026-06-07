using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestAPBD.Migrations
{
    /// <inheritdoc />
    public partial class fixPrimaryKeysInResponsibleEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Responsible",
                table: "Responsible");

            migrationBuilder.DropIndex(
                name: "IX_Responsible_EmployeeId",
                table: "Responsible");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Responsible",
                table: "Responsible",
                columns: new[] { "EmployeeId", "BatchId" });

            migrationBuilder.CreateIndex(
                name: "IX_Responsible_BatchId",
                table: "Responsible",
                column: "BatchId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Responsible",
                table: "Responsible");

            migrationBuilder.DropIndex(
                name: "IX_Responsible_BatchId",
                table: "Responsible");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Responsible",
                table: "Responsible",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Responsible_EmployeeId",
                table: "Responsible",
                column: "EmployeeId");
        }
    }
}

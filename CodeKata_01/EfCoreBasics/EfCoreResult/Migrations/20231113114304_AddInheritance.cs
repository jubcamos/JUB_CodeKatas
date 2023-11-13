using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreResult.Migrations
{
    /// <inheritdoc />
    public partial class AddInheritance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LearnGroup",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Titel",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "LearnGroup",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Titel",
                table: "Teachers");
        }
    }
}

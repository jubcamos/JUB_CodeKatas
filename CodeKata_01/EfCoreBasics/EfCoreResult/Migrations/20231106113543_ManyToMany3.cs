using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreResult.Migrations
{
    /// <inheritdoc />
    public partial class ManyToMany3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Publishers_DeveloperStudios_CustomerDeveloperStudioId",
                table: "Publishers");

            migrationBuilder.DropIndex(
                name: "IX_Publishers_CustomerDeveloperStudioId",
                table: "Publishers");

            migrationBuilder.DropColumn(
                name: "CustomerDeveloperStudioId",
                table: "Publishers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerDeveloperStudioId",
                table: "Publishers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Publishers_CustomerDeveloperStudioId",
                table: "Publishers",
                column: "CustomerDeveloperStudioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Publishers_DeveloperStudios_CustomerDeveloperStudioId",
                table: "Publishers",
                column: "CustomerDeveloperStudioId",
                principalTable: "DeveloperStudios",
                principalColumn: "DeveloperStudioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

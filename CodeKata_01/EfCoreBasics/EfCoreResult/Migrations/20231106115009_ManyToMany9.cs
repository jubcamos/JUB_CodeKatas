using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreResult.Migrations
{
    /// <inheritdoc />
    public partial class ManyToMany9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partnerships_DeveloperStudios_DeveloperStudioId",
                table: "Partnerships");

            migrationBuilder.DropForeignKey(
                name: "FK_Partnerships_Publishers_PublisherId",
                table: "Partnerships");

            migrationBuilder.DropIndex(
                name: "IX_Partnerships_DeveloperStudioId",
                table: "Partnerships");

            migrationBuilder.DropColumn(
                name: "DeveloperStudioId",
                table: "Partnerships");

            migrationBuilder.CreateIndex(
                name: "IX_Partnerships_DeveloperId",
                table: "Partnerships",
                column: "DeveloperId");

            migrationBuilder.AddForeignKey(
                name: "FK_Partnerships_DeveloperStudios_DeveloperId",
                table: "Partnerships",
                column: "DeveloperId",
                principalTable: "DeveloperStudios",
                principalColumn: "DeveloperStudioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Partnerships_Publishers_PublisherId",
                table: "Partnerships",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partnerships_DeveloperStudios_DeveloperId",
                table: "Partnerships");

            migrationBuilder.DropForeignKey(
                name: "FK_Partnerships_Publishers_PublisherId",
                table: "Partnerships");

            migrationBuilder.DropIndex(
                name: "IX_Partnerships_DeveloperId",
                table: "Partnerships");

            migrationBuilder.AddColumn<int>(
                name: "DeveloperStudioId",
                table: "Partnerships",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Partnerships_DeveloperStudioId",
                table: "Partnerships",
                column: "DeveloperStudioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Partnerships_DeveloperStudios_DeveloperStudioId",
                table: "Partnerships",
                column: "DeveloperStudioId",
                principalTable: "DeveloperStudios",
                principalColumn: "DeveloperStudioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Partnerships_Publishers_PublisherId",
                table: "Partnerships",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

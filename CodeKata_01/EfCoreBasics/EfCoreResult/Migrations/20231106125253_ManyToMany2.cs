using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreResult.Migrations
{
    /// <inheritdoc />
    public partial class ManyToMany2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeveloperStudioPublisher",
                columns: table => new
                {
                    DeveloperStudioId = table.Column<int>(type: "int", nullable: false),
                    PublishersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeveloperStudioPublisher", x => new { x.DeveloperStudioId, x.PublishersId });
                    table.ForeignKey(
                        name: "FK_DeveloperStudioPublisher_DeveloperStudios_DeveloperStudioId",
                        column: x => x.DeveloperStudioId,
                        principalTable: "DeveloperStudios",
                        principalColumn: "DeveloperStudioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeveloperStudioPublisher_Publishers_PublishersId",
                        column: x => x.PublishersId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeveloperStudioPublisher_PublishersId",
                table: "DeveloperStudioPublisher",
                column: "PublishersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeveloperStudioPublisher");
        }
    }
}

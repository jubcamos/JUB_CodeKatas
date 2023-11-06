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
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Budged = table.Column<double>(type: "float", nullable: false),
                    CustomerDeveloperStudioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Publishers_DeveloperStudios_CustomerDeveloperStudioId",
                        column: x => x.CustomerDeveloperStudioId,
                        principalTable: "DeveloperStudios",
                        principalColumn: "DeveloperStudioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Partnerships",
                columns: table => new
                {
                    DeveloperStudioId = table.Column<int>(type: "int", nullable: false),
                    PublisherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partnerships", x => new { x.PublisherId, x.DeveloperStudioId });
                    table.ForeignKey(
                        name: "FK_Partnerships_DeveloperStudios_DeveloperStudioId",
                        column: x => x.DeveloperStudioId,
                        principalTable: "DeveloperStudios",
                        principalColumn: "DeveloperStudioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Partnerships_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Partnerships_DeveloperStudioId",
                table: "Partnerships",
                column: "DeveloperStudioId");

            migrationBuilder.CreateIndex(
                name: "IX_Publishers_CustomerDeveloperStudioId",
                table: "Publishers",
                column: "CustomerDeveloperStudioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Partnerships");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}

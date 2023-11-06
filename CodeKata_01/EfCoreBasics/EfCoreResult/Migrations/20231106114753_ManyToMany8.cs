using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreResult.Migrations
{
    /// <inheritdoc />
    public partial class ManyToMany8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partnerships_DeveloperStudios_DId",
                table: "Partnerships");

            migrationBuilder.DropForeignKey(
                name: "FK_Partnerships_Publishers_PId",
                table: "Partnerships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Partnerships",
                table: "Partnerships");

            migrationBuilder.RenameColumn(
                name: "DId",
                table: "Partnerships",
                newName: "DeveloperStudioId");

            migrationBuilder.RenameColumn(
                name: "PId",
                table: "Partnerships",
                newName: "DeveloperId");

            migrationBuilder.RenameIndex(
                name: "IX_Partnerships_DId",
                table: "Partnerships",
                newName: "IX_Partnerships_DeveloperStudioId");

            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "Partnerships",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Partnerships",
                table: "Partnerships",
                columns: new[] { "PublisherId", "DeveloperId" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partnerships_DeveloperStudios_DeveloperStudioId",
                table: "Partnerships");

            migrationBuilder.DropForeignKey(
                name: "FK_Partnerships_Publishers_PublisherId",
                table: "Partnerships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Partnerships",
                table: "Partnerships");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "Partnerships");

            migrationBuilder.RenameColumn(
                name: "DeveloperStudioId",
                table: "Partnerships",
                newName: "DId");

            migrationBuilder.RenameColumn(
                name: "DeveloperId",
                table: "Partnerships",
                newName: "PId");

            migrationBuilder.RenameIndex(
                name: "IX_Partnerships_DeveloperStudioId",
                table: "Partnerships",
                newName: "IX_Partnerships_DId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Partnerships",
                table: "Partnerships",
                columns: new[] { "PId", "DId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Partnerships_DeveloperStudios_DId",
                table: "Partnerships",
                column: "DId",
                principalTable: "DeveloperStudios",
                principalColumn: "DeveloperStudioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Partnerships_Publishers_PId",
                table: "Partnerships",
                column: "PId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebDevelopment.Data.Migrations
{
    /// <inheritdoc />
    public partial class add7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_models_makes_MakeId1",
                table: "models");

            migrationBuilder.DropIndex(
                name: "IX_models_MakeId1",
                table: "models");

            migrationBuilder.DropColumn(
                name: "MakeId1",
                table: "models");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MakeId1",
                table: "models",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_models_MakeId1",
                table: "models",
                column: "MakeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_models_makes_MakeId1",
                table: "models",
                column: "MakeId1",
                principalTable: "makes",
                principalColumn: "Id");
        }
    }
}

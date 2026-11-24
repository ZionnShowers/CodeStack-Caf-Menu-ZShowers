using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class categories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cafes",
                table: "Cafes");

            migrationBuilder.RenameTable(
                name: "Cafes",
                newName: "Cafe");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cafe",
                table: "Cafe",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cafe",
                table: "Cafe");

            migrationBuilder.RenameTable(
                name: "Cafe",
                newName: "Cafes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cafes",
                table: "Cafes",
                column: "Id");
        }
    }
}

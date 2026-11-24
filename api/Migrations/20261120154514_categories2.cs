using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class categories2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

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
    }
}

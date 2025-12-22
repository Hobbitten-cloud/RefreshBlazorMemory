using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RefreshBlazorMemory.Migrations
{
    /// <inheritdoc />
    public partial class Newnit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Musics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlbumTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseYear = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musics", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Musics",
                columns: new[] { "Id", "AlbumTitle", "Artist", "Description", "ReleaseYear" },
                values: new object[,]
                {
                    { 1, "Pepe", "Mic Pepper", "Dope nok", 1999 },
                    { 2, "MoreDance", "Jens Musikmand", "Vildt Nok", 2000 },
                    { 3, "SuperDanse", "Danse Mus", "Jeg er træt", 2001 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musics");
        }
    }
}

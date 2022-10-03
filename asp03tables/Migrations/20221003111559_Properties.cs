using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace asp03tables.Migrations
{
    public partial class Properties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "GenreId", "Name" },
                values: new object[] { 1, 1, "Avatar" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1);
        }
    }
}

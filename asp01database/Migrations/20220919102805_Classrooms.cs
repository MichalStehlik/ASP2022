using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace asp01database.Migrations
{
    public partial class Classrooms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassroomId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Classroom",
                columns: table => new
                {
                    ClassroomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classroom", x => x.ClassroomId);
                });

            migrationBuilder.InsertData(
                table: "Classroom",
                columns: new[] { "ClassroomId", "Name" },
                values: new object[] { 1, "P3" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "ClassroomId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassroomId",
                table: "Students",
                column: "ClassroomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classroom_ClassroomId",
                table: "Students",
                column: "ClassroomId",
                principalTable: "Classroom",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classroom_ClassroomId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Classroom");

            migrationBuilder.DropIndex(
                name: "IX_Students_ClassroomId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ClassroomId",
                table: "Students");
        }
    }
}

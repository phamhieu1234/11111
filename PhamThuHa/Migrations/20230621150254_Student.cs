using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhamThuHa.Migrations
{
    /// <inheritdoc />
    public partial class Student : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    MaStudent = table.Column<string>(type: "TEXT", nullable: false),
                    NameStudent = table.Column<string>(type: "TEXT", nullable: true),
                    DiaChiStudent = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.MaStudent);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}

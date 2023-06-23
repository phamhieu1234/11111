using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Baithuchanh.Migrations
{
    /// <inheritdoc />
    public partial class Student : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    MaStudent = table.Column<string>(type: "TEXT", nullable: false),
                    NameStudent = table.Column<string>(type: "TEXT", nullable: true),
                    PhonumberStudent = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.MaStudent);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhamThuHa.Migrations
{
    /// <inheritdoc />
    public partial class KhachSan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachSan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameStudent = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    DiachiStudent = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachSan", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KhachSan");
        }
    }
}

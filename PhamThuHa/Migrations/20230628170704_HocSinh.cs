using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhamThuHa.Migrations
{
    /// <inheritdoc />
    public partial class HocSinh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KhachSan");

            migrationBuilder.CreateTable(
                name: "HocSinh",
                columns: table => new
                {
                    MaLopHoc = table.Column<int>(type: "INTEGER", maxLength: 10, nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TenLopHoc = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    DiaLopHoc = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocSinh", x => x.MaLopHoc);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HocSinh");

            migrationBuilder.CreateTable(
                name: "KhachSan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AddressStudent = table.Column<string>(type: "TEXT", nullable: true),
                    NameStudent = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachSan", x => x.Id);
                });
        }
    }
}

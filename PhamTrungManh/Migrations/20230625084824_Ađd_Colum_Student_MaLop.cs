using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhamTrungManh.Migrations
{
    /// <inheritdoc />
    public partial class Ađd_Colum_Student_MaLop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaLop",
                table: "Student",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaLop",
                table: "Student");
        }
    }
}

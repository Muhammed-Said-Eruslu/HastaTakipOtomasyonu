using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneOtomasyon.Migrations
{
    /// <inheritdoc />
    public partial class migssx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Unvan",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Unvan",
                table: "Doctors");
        }
    }
}

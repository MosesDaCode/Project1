using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectLibrary.Migrations
{
    /// <inheritdoc />
    public partial class AddedPropertieforAvgWinRate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "AvgWinrate",
                table: "RockPaperScissor",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvgWinrate",
                table: "RockPaperScissor");
        }
    }
}

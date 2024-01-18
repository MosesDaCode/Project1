using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectLibrary.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedNameforAvgWinRatepropertiewithcamelCase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AvgWinrate",
                table: "RockPaperScissor",
                newName: "AvgWinRate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AvgWinRate",
                table: "RockPaperScissor",
                newName: "AvgWinrate");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectLibrary.Migrations
{
    /// <inheritdoc />
    public partial class Addedpropertiesforplayerscoreandcomputerscore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComputerScore",
                table: "RockPaperScissor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlayerScore",
                table: "RockPaperScissor",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComputerScore",
                table: "RockPaperScissor");

            migrationBuilder.DropColumn(
                name: "PlayerScore",
                table: "RockPaperScissor");
        }
    }
}

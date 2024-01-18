using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectLibrary.Migrations
{
    /// <inheritdoc />
    public partial class ChangedpropertieAvgWinRatefromdoubletodecimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "AvgWinRate",
                table: "RockPaperScissor",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "AvgWinRate",
                table: "RockPaperScissor",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}

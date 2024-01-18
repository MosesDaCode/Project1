using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectLibrary.Migrations
{
    /// <inheritdoc />
    public partial class changedidnameforRockPaperScissor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RockPaperScissorId",
                table: "RockPaperScissor",
                newName: "RpsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RpsId",
                table: "RockPaperScissor",
                newName: "RockPaperScissorId");
        }
    }
}

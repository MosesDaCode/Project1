using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectLibrary.Migrations
{
    /// <inheritdoc />
    public partial class initialDbCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calculators",
                columns: table => new
                {
                    CalculatorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstNum = table.Column<double>(type: "float", nullable: false),
                    SecondNum = table.Column<double>(type: "float", nullable: false),
                    Operator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Result = table.Column<double>(type: "float", nullable: false),
                    CalculationDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calculators", x => x.CalculatorId);
                });

            migrationBuilder.CreateTable(
                name: "RockPaperScissor",
                columns: table => new
                {
                    RockPaperScissorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerMove = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComputerMove = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RockPaperScissor", x => x.RockPaperScissorId);
                });

            migrationBuilder.CreateTable(
                name: "Shapes",
                columns: table => new
                {
                    ShapeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShapeForm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Base = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    CathetusOne = table.Column<int>(type: "int", nullable: false),
                    CathetusTwo = table.Column<int>(type: "int", nullable: false),
                    Hypotenuse = table.Column<int>(type: "int", nullable: false),
                    Area = table.Column<double>(type: "float", nullable: false),
                    Circumference = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shapes", x => x.ShapeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calculators");

            migrationBuilder.DropTable(
                name: "RockPaperScissor");

            migrationBuilder.DropTable(
                name: "Shapes");
        }
    }
}

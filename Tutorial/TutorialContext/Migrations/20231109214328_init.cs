using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tutorial.TutorialContext.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuperHeroes",
                columns: table => new
                {
                    SuperHeroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuperHeroName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuperHeroAge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperHeroes", x => x.SuperHeroId);
                });

            migrationBuilder.CreateTable(
                name: "SuperPowers",
                columns: table => new
                {
                    SuperPowerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuperPowerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FightingSkill = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuperHeroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperPowers", x => x.SuperPowerId);
                    table.ForeignKey(
                        name: "FK_SuperPowers_SuperHeroes_SuperHeroId",
                        column: x => x.SuperHeroId,
                        principalTable: "SuperHeroes",
                        principalColumn: "SuperHeroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SuperPowers_SuperHeroId",
                table: "SuperPowers",
                column: "SuperHeroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuperPowers");

            migrationBuilder.DropTable(
                name: "SuperHeroes");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlanetExplorer.Migrations
{
    /// <inheritdoc />
    public partial class AddDestinationsToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    dest_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dest_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    planet_id = table.Column<int>(type: "int", nullable: false),
                    dest_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dest_image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dest_price = table.Column<double>(type: "float", nullable: true),
                    dest_rating = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.dest_id);
                    table.ForeignKey(
                        name: "FK_Destinations_Planets_planet_id",
                        column: x => x.planet_id,
                        principalTable: "Planets",
                        principalColumn: "planet_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_planet_id",
                table: "Destinations",
                column: "planet_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinations");
        }
    }
}

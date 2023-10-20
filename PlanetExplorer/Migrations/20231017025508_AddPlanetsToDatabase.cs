using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using Newtonsoft.Json.Linq;

#nullable disable

namespace PlanetExplorer.Migrations
{
    /// <inheritdoc />
    public partial class AddPlanetsToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    planet_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    planet_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    planet_image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    affiliation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fun_facts = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.planet_id);
                });

            string[] columns = { "planet_name", "planet_image" };
            object[,] values = { { "Endor", "images/planets/Endor.jpg" },
                                 { "Coruscant", "images/planets/Coruscant.jpg" }, 
                                 { "Naboo", "images/planets/Naboo.jpg" },
								 { "Tatooine", "images/planets/Tatooine.jpg" },
                                 { "Bespin", "images/planets/Bespin.jpg" },
                                 { "Hoth", "images/planets/Hoth.png" },
                                 { "Scarif", "images/planets/Scarif.jpg" },
                                 { "Mustafar", "images/planets/Mustafar.jpg" },
                                 { "Kamino", "images/planets/Kamino.jpg" },
                                 { "Geonosis", "images/planets/Geonosis.jpg" },
                                 { "Lothal", "images/planets/Lothal.jpg" },
                                 { "Dagobah", "images/planets/Dagobah.jpg" },
                                 { "Felucia", "images/planets/Felucia.jpg" },
                                 { "Crait", "images/planets/Crait.png" },};

            migrationBuilder.InsertData("Planets", columns, values, null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planets");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exosky.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MainStars",
                columns: table => new
                {
                    mainStarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    bf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Proper = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RA = table.Column<double>(type: "float", nullable: false),
                    Dec = table.Column<double>(type: "float", nullable: false),
                    Distance = table.Column<double>(type: "float", nullable: false),
                    ProperMotionRA = table.Column<double>(type: "float", nullable: false),
                    ProperMotionDec = table.Column<double>(type: "float", nullable: false),
                    RadialVelocity = table.Column<double>(type: "float", nullable: false),
                    ApparentMagnitude = table.Column<double>(type: "float", nullable: false),
                    AbsoluteMagnitude = table.Column<double>(type: "float", nullable: false),
                    SpectralType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorIndex = table.Column<double>(type: "float", nullable: false),
                    X = table.Column<double>(type: "float", nullable: false),
                    Y = table.Column<double>(type: "float", nullable: false),
                    Z = table.Column<double>(type: "float", nullable: false),
                    VelocityX = table.Column<double>(type: "float", nullable: false),
                    VelocityY = table.Column<double>(type: "float", nullable: false),
                    VelocityZ = table.Column<double>(type: "float", nullable: false),
                    Constellation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainStars", x => x.mainStarID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MainStars");
        }
    }
}

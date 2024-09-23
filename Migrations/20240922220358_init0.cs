using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exosky.Migrations
{
    /// <inheritdoc />
    public partial class init0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exoplanets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HostStar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistanceFromEarth = table.Column<double>(type: "float", nullable: false),
                    Radius = table.Column<double>(type: "float", nullable: false),
                    Mass = table.Column<double>(type: "float", nullable: false),
                    OrbitalPeriod = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exoplanets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BarthDay = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkyMaps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExoplanetId = table.Column<int>(type: "int", nullable: false),
                    ObservationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkyMaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkyMaps_Exoplanets_ExoplanetId",
                        column: x => x.ExoplanetId,
                        principalTable: "Exoplanets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SkyMaps_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Constellations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkyMapId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constellations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Constellations_SkyMaps_SkyMapId",
                        column: x => x.SkyMapId,
                        principalTable: "SkyMaps",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SharedSkyMaps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkyMapId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SharedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SharedSkyMaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SharedSkyMaps_SkyMaps_SkyMapId",
                        column: x => x.SkyMapId,
                        principalTable: "SkyMaps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SharedSkyMaps_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Stars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RightAscension = table.Column<double>(type: "float", nullable: false),
                    Declination = table.Column<double>(type: "float", nullable: false),
                    ApparentMagnitude = table.Column<double>(type: "float", nullable: false),
                    DistanceFromEarth = table.Column<double>(type: "float", nullable: false),
                    ConstellationId = table.Column<int>(type: "int", nullable: true),
                    SkyMapId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stars_Constellations_ConstellationId",
                        column: x => x.ConstellationId,
                        principalTable: "Constellations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Stars_SkyMaps_SkyMapId",
                        column: x => x.SkyMapId,
                        principalTable: "SkyMaps",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SharedSkyMapId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_SharedSkyMaps_SharedSkyMapId",
                        column: x => x.SharedSkyMapId,
                        principalTable: "SharedSkyMaps",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LikeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SharedSkyMapId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Likes_SharedSkyMaps_SharedSkyMapId",
                        column: x => x.SharedSkyMapId,
                        principalTable: "SharedSkyMaps",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Likes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_SharedSkyMapId",
                table: "Comments",
                column: "SharedSkyMapId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Constellations_SkyMapId",
                table: "Constellations",
                column: "SkyMapId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_SharedSkyMapId",
                table: "Likes",
                column: "SharedSkyMapId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_UserId",
                table: "Likes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SharedSkyMaps_SkyMapId",
                table: "SharedSkyMaps",
                column: "SkyMapId");

            migrationBuilder.CreateIndex(
                name: "IX_SharedSkyMaps_UserId",
                table: "SharedSkyMaps",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SkyMaps_ExoplanetId",
                table: "SkyMaps",
                column: "ExoplanetId");

            migrationBuilder.CreateIndex(
                name: "IX_SkyMaps_UserId",
                table: "SkyMaps",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Stars_ConstellationId",
                table: "Stars",
                column: "ConstellationId");

            migrationBuilder.CreateIndex(
                name: "IX_Stars_SkyMapId",
                table: "Stars",
                column: "SkyMapId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "Stars");

            migrationBuilder.DropTable(
                name: "SharedSkyMaps");

            migrationBuilder.DropTable(
                name: "Constellations");

            migrationBuilder.DropTable(
                name: "SkyMaps");

            migrationBuilder.DropTable(
                name: "Exoplanets");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

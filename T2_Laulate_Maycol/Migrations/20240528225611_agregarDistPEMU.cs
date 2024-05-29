using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace T2_Laulate_Maycol.Migrations
{
    /// <inheritdoc />
    public partial class agregarDistPEMU : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DistribuidorMUNDO",
                columns: table => new
                {
                    IdMundo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDistribuidorMundo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RazonSocialMundo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonoMundo = table.Column<int>(type: "int", nullable: false),
                    AnioInicioOperacionMundo = table.Column<int>(type: "int", nullable: false),
                    ContactoMundo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistribuidorMUNDO", x => x.IdMundo);
                });

            migrationBuilder.CreateTable(
                name: "DistribuidorPE",
                columns: table => new
                {
                    IdPeru = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDistribuidorPeru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RazonSocialPeru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonoPeru = table.Column<int>(type: "int", nullable: false),
                    AnioInicioOperacionPeru = table.Column<int>(type: "int", nullable: false),
                    ContactoPeru = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistribuidorPE", x => x.IdPeru);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DistribuidorMUNDO");

            migrationBuilder.DropTable(
                name: "DistribuidorPE");
        }
    }
}

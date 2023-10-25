using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuanAlvarez_ExamenP1.Migrations
{
    public partial class Cambios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JuanAlvarez_tabla",
                columns: table => new
                {
                    jaCedula = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    jaEdad = table.Column<int>(type: "int", nullable: false),
                    jaNombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    jaAñosEmpresa = table.Column<bool>(type: "bit", nullable: false),
                    jaSalario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    jaCorreo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    jaNacimiento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JuanAlvarez_tabla", x => x.jaCedula);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JuanAlvarez_tabla");
        }
    }
}

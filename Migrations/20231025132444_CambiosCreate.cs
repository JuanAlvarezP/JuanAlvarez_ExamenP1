using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuanAlvarez_ExamenP1.Migrations
{
    public partial class CambiosCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "jaNacimiento",
                table: "JuanAlvarez_tabla",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "jaNacimiento",
                table: "JuanAlvarez_tabla",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}

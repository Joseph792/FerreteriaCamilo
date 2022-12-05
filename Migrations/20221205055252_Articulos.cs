using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FerreteriaCamilo.Migrations
{
    /// <inheritdoc />
    public partial class Articulos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cedula",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "REAL");

            migrationBuilder.CreateTable(
                name: "Articulos",
                columns: table => new
                {
                    ArticuloId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Referencia = table.Column<string>(type: "TEXT", nullable: false),
                    Costo = table.Column<int>(type: "INTEGER", nullable: false),
                    Precio = table.Column<int>(type: "INTEGER", nullable: false),
                    SuplidorId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulos", x => x.ArticuloId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articulos");

            migrationBuilder.AlterColumn<float>(
                name: "Cedula",
                table: "Clientes",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Conciliador.Datos.Migrations
{
    /// <inheritdoc />
    public partial class UsuarioEstado2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Estado2",
                table: "usuarioEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado2",
                table: "usuarioEntities");
        }
    }
}

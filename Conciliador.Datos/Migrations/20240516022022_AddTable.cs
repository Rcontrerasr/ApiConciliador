using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Conciliador.Datos.Migrations
{
    /// <inheritdoc />
    public partial class AddTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bancoEmpresaEntities");

            migrationBuilder.DropTable(
                name: "bancosEntities");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bancoEmpresaEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cuenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdBanco = table.Column<int>(type: "int", nullable: false),
                    IdEmpresa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bancoEmpresaEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bancosEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoBanco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NombreBanco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioCreacionModificacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bancosEntities", x => x.Id);
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Conciliador.Datos.Migrations
{
    /// <inheritdoc />
    public partial class UsuarioEstado4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "moduloRolesEntities");

            migrationBuilder.DropColumn(
                name: "FechaActualizacion",
                table: "moduloRolesEntities");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "moduloRolesEntities");

            migrationBuilder.DropColumn(
                name: "NombreRol",
                table: "moduloRolesEntities");

            migrationBuilder.DropColumn(
                name: "UsuarioCreacionModificacion",
                table: "moduloRolesEntities");

            migrationBuilder.AddColumn<int>(
                name: "IdRol",
                table: "moduloRolesEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Idtabla",
                table: "moduloRolesEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdRol",
                table: "moduloRolesEntities");

            migrationBuilder.DropColumn(
                name: "Idtabla",
                table: "moduloRolesEntities");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "moduloRolesEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaActualizacion",
                table: "moduloRolesEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "moduloRolesEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "NombreRol",
                table: "moduloRolesEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioCreacionModificacion",
                table: "moduloRolesEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

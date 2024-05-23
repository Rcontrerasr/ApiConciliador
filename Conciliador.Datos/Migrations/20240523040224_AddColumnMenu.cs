using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Conciliador.Datos.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menu_Menu_IdMenuPadreNavigationId",
                table: "Menu");

            migrationBuilder.RenameColumn(
                name: "IdMenuPadreNavigationId",
                table: "Menu",
                newName: "IdMenuPadre");

            migrationBuilder.RenameIndex(
                name: "IX_Menu_IdMenuPadreNavigationId",
                table: "Menu",
                newName: "IX_Menu_IdMenuPadre");

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_Menu_IdMenuPadre",
                table: "Menu",
                column: "IdMenuPadre",
                principalTable: "Menu",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menu_Menu_IdMenuPadre",
                table: "Menu");

            migrationBuilder.RenameColumn(
                name: "IdMenuPadre",
                table: "Menu",
                newName: "IdMenuPadreNavigationId");

            migrationBuilder.RenameIndex(
                name: "IX_Menu_IdMenuPadre",
                table: "Menu",
                newName: "IX_Menu_IdMenuPadreNavigationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_Menu_IdMenuPadreNavigationId",
                table: "Menu",
                column: "IdMenuPadreNavigationId",
                principalTable: "Menu",
                principalColumn: "Id");
        }
    }
}

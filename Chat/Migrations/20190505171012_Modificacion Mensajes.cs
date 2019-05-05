using Microsoft.EntityFrameworkCore.Migrations;

namespace Chat.Migrations
{
    public partial class ModificacionMensajes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mensajes_Usuario_usuarioEmisorId",
                table: "Mensajes");

            migrationBuilder.RenameColumn(
                name: "usuarioEmisorId",
                table: "Mensajes",
                newName: "UsuarioEmisorId");

            migrationBuilder.RenameColumn(
                name: "enviado",
                table: "Mensajes",
                newName: "Enviado");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Mensajes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "mensaje",
                table: "Mensajes",
                newName: "MensajeEnviado");

            migrationBuilder.RenameIndex(
                name: "IX_Mensajes_usuarioEmisorId",
                table: "Mensajes",
                newName: "IX_Mensajes_UsuarioEmisorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mensajes_Usuario_UsuarioEmisorId",
                table: "Mensajes",
                column: "UsuarioEmisorId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mensajes_Usuario_UsuarioEmisorId",
                table: "Mensajes");

            migrationBuilder.RenameColumn(
                name: "UsuarioEmisorId",
                table: "Mensajes",
                newName: "usuarioEmisorId");

            migrationBuilder.RenameColumn(
                name: "Enviado",
                table: "Mensajes",
                newName: "enviado");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Mensajes",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "MensajeEnviado",
                table: "Mensajes",
                newName: "mensaje");

            migrationBuilder.RenameIndex(
                name: "IX_Mensajes_UsuarioEmisorId",
                table: "Mensajes",
                newName: "IX_Mensajes_usuarioEmisorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mensajes_Usuario_usuarioEmisorId",
                table: "Mensajes",
                column: "usuarioEmisorId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Chat.Migrations
{
    public partial class CrearBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NombreUsuario = table.Column<string>(nullable: true),
                    UltimoAcceso = table.Column<DateTime>(nullable: false),
                    UrlAvatar = table.Column<string>(nullable: true),
                    CorreoElectronico = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mensajes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    enviado = table.Column<DateTime>(nullable: false),
                    mensaje = table.Column<string>(maxLength: 240, nullable: true),
                    usuarioEmisorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensajes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Mensajes_Usuario_usuarioEmisorId",
                        column: x => x.usuarioEmisorId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mensajes_usuarioEmisorId",
                table: "Mensajes",
                column: "usuarioEmisorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mensajes");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}

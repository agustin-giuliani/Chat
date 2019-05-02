using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Chat.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombreUsuario = table.Column<string>(nullable: true),
                    contraseña = table.Column<string>(nullable: true),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    ultimoAcceso = table.Column<DateTime>(nullable: false),
                    preguntaSecreta = table.Column<string>(nullable: true),
                    respuestaPregSecreta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Mensajes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    enviado = table.Column<DateTime>(nullable: false),
                    mensaje = table.Column<string>(maxLength: 240, nullable: true),
                    usuarioEmisorid = table.Column<int>(nullable: true),
                    usuarioReceptorid = table.Column<int>(nullable: true),
                    idGrupo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensajes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Mensajes_Usuario_usuarioEmisorid",
                        column: x => x.usuarioEmisorid,
                        principalTable: "Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mensajes_Usuario_usuarioReceptorid",
                        column: x => x.usuarioReceptorid,
                        principalTable: "Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mensajes_usuarioEmisorid",
                table: "Mensajes",
                column: "usuarioEmisorid");

            migrationBuilder.CreateIndex(
                name: "IX_Mensajes_usuarioReceptorid",
                table: "Mensajes",
                column: "usuarioReceptorid");
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

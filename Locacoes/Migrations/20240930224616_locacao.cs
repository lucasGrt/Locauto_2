using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Locacoes.Migrations
{
    /// <inheritdoc />
    public partial class locacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataLocacao = table.Column<DateOnly>(type: "date", nullable: false),
                    ValorTotal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Clienteid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locacoes_Clientes_Clienteid",
                        column: x => x.Clienteid,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locacoes_Clienteid",
                table: "Locacoes",
                column: "Clienteid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locacoes");
        }
    }
}

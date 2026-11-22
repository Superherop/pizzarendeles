using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pizzarendeles.Migrations
{
    /// <inheritdoc />
    public partial class NaviKapcsolatok : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Rendelesek_PizzaId",
                table: "Rendelesek",
                column: "PizzaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rendelesek_UgyfelId",
                table: "Rendelesek",
                column: "UgyfelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rendelesek_Pizzak_PizzaId",
                table: "Rendelesek",
                column: "PizzaId",
                principalTable: "Pizzak",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rendelesek_Ugyfelek_UgyfelId",
                table: "Rendelesek",
                column: "UgyfelId",
                principalTable: "Ugyfelek",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rendelesek_Pizzak_PizzaId",
                table: "Rendelesek");

            migrationBuilder.DropForeignKey(
                name: "FK_Rendelesek_Ugyfelek_UgyfelId",
                table: "Rendelesek");

            migrationBuilder.DropIndex(
                name: "IX_Rendelesek_PizzaId",
                table: "Rendelesek");

            migrationBuilder.DropIndex(
                name: "IX_Rendelesek_UgyfelId",
                table: "Rendelesek");
        }
    }
}

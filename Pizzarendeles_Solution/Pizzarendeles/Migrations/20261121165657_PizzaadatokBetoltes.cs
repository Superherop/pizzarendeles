using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pizzarendeles.Migrations
{
    /// <inheritdoc />
    public partial class PizzaadatokBetoltes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pizzak",
                columns: new[] { "Id", "Ar", "Nev" },
                values: new object[,]
                {
                    { 1, 2490, "Margherita" },
                    { 2, 2890, "Sonkás" },
                    { 3, 3090, "Hawaii" },
                    { 4, 3290, "Magyaros" },
                    { 5, 3390, "Négysajtos" },
                    { 6, 2990, "Szalámis" },
                    { 7, 3190, "Tonhalas" },
                    { 8, 3490, "Csípős csirkés" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pizzak",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pizzak",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pizzak",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pizzak",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pizzak",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pizzak",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pizzak",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pizzak",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}

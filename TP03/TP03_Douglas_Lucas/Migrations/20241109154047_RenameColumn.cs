using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TP03_Douglas_Lucas.Migrations
{
    /// <inheritdoc />
    public partial class RenameColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Unidade",
                table: "Produto",
                newName: "Unit");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Produto",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Produto",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Produto",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Categoria",
                table: "Produto",
                newName: "CategoryName");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "Description", "Name" },
                values: new object[] { "Electronics", "Smartphone with high-quality display and camera", "Smartphone" });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "Description", "Name", "Price" },
                values: new object[] { "Electronics", "Smartphone with long-lasting battery", "Smartphone", 2000m });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "CategoryName", "Description", "Name", "Price", "Unit" },
                values: new object[,]
                {
                    { 3, "Electronics", "Lightweight laptop with 16GB RAM and 512GB SSD", "Laptop", 1500m, 1 },
                    { 4, "Accessories", "Noise-cancelling wireless headphones", "Headphones", 300m, 1 },
                    { 5, "Wearable", "Water-resistant smartwatch with fitness tracking", "Smartwatch", 250m, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.RenameColumn(
                name: "Unit",
                table: "Produto",
                newName: "Unidade");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Produto",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Produto",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Produto",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Produto",
                newName: "Categoria");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Categoria", "Descricao", "Nome" },
                values: new object[] { "Ele tronico", "CElular preto com capa preta andoid 18 meses de uso xioami poco x5 vem no precingo pv", "Celular do dougla" });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Categoria", "Descricao", "Nome", "Preco" },
                values: new object[] { "Ele tronico", "Celular branco com capa azul do kuquinhas nem parece branco vem no pv compra rapido", "Celular do luquinha", 5000m });
        }
    }
}

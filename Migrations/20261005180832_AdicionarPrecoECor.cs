using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_css_cs.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarPrecoECor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cor",
                table: "Veiculos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Preco",
                table: "Veiculos",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cor",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Veiculos");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_css_cs.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarCampoVersao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Versao",
                table: "Veiculos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Versao",
                table: "Veiculos");
        }
    }
}

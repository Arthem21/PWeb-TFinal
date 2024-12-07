using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P.Final.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_multas_Agentes_AgenteID",
                table: "multas");

            migrationBuilder.AlterColumn<int>(
                name: "AgenteID",
                table: "multas",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_multas_Agentes_AgenteID",
                table: "multas",
                column: "AgenteID",
                principalTable: "Agentes",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_multas_Agentes_AgenteID",
                table: "multas");

            migrationBuilder.AlterColumn<int>(
                name: "AgenteID",
                table: "multas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_multas_Agentes_AgenteID",
                table: "multas",
                column: "AgenteID",
                principalTable: "Agentes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

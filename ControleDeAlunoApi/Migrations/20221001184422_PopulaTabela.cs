using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeAlunoApi.Migrations
{
    public partial class PopulaTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "AlunoId", "Email", "Idade", "Nome" },
                values: new object[] { 1, "antoniocarlos@yahoo.com", 22, "Antonio Carlos" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Alunos",
                keyColumn: "AlunoId",
                keyValue: 1);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoMVC.Migrations.SqlServerMigrations3
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Promocoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacotesCompletos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacotesIndividuais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PromocaoVerao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promocoes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Promocoes");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Learn.Data.Migrations
{
    public partial class IniciandoBancoDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Sigla = table.Column<string>(nullable: true),
                    NascionalidadeMasculina = table.Column<string>(nullable: true),
                    NascionalidadeFeminina = table.Column<string>(nullable: true),
                    Continente = table.Column<string>(nullable: true),
                    DDI = table.Column<int>(nullable: false),
                    CadastradoEm = table.Column<DateTime>(nullable: false),
                    AlteradoEm = table.Column<DateTime>(nullable: false),
                    ExcluidoEm = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paises");
        }
    }
}

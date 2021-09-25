using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CM.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidato",
                columns: table => new
                {
                    CandidatoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: true),
                    Sobrenome = table.Column<string>(type: "varchar(100)", nullable: true),
                    Rg = table.Column<string>(type: "varchar(15)", nullable: true),
                    Cpf = table.Column<string>(type: "varchar(15)", nullable: true),
                    Nascimento = table.Column<DateTime>(nullable: false),
                    CarteiraTrabalho = table.Column<string>(type: "varchar(15)", nullable: true),
                    CarteiraTrabalhoSerie = table.Column<string>(type: "varchar(15)", nullable: true),
                    CarteiraTrabalhoUf = table.Column<string>(type: "varchar(2)", nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidato", x => x.CandidatoId);
                });

            migrationBuilder.CreateTable(
                name: "Habilidade",
                columns: table => new
                {
                    HabilidadeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tag = table.Column<string>(type: "varchar(100)", nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidade", x => x.HabilidadeId);
                });

            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    ContatoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Telefone = table.Column<string>(type: "varchar(30)", nullable: true),
                    Email = table.Column<string>(type: "varchar(60)", nullable: true),
                    Endereco = table.Column<string>(type: "varchar(400)", nullable: true),
                    LinkedinLink = table.Column<string>(type: "varchar(400)", nullable: true),
                    RedeSocial = table.Column<string>(type: "varchar(400)", nullable: true),
                    CandidatoId = table.Column<int>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.ContatoId);
                    table.ForeignKey(
                        name: "FK_Contato_Candidato_CandidatoId",
                        column: x => x.CandidatoId,
                        principalTable: "Candidato",
                        principalColumn: "CandidatoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CandidatoHabilidade",
                columns: table => new
                {
                    CandidadoHabilidadeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CandidatoId = table.Column<int>(nullable: false),
                    HabilidadeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidatoHabilidade", x => x.CandidadoHabilidadeId);
                    table.ForeignKey(
                        name: "FK_CandidatoHabilidade_Candidato_CandidatoId",
                        column: x => x.CandidatoId,
                        principalTable: "Candidato",
                        principalColumn: "CandidatoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidatoHabilidade_Habilidade_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "Habilidade",
                        principalColumn: "HabilidadeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandidatoHabilidade_CandidatoId",
                table: "CandidatoHabilidade",
                column: "CandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidatoHabilidade_HabilidadeId",
                table: "CandidatoHabilidade",
                column: "HabilidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_CandidatoId",
                table: "Contato",
                column: "CandidatoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidatoHabilidade");

            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DropTable(
                name: "Habilidade");

            migrationBuilder.DropTable(
                name: "Candidato");
        }
    }
}

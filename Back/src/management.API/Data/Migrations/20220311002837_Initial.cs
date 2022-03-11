using Microsoft.EntityFrameworkCore.Migrations;

namespace Management.API.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    IdDepartamento = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Sigla = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.IdDepartamento);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    ImagemURL = table.Column<string>(type: "TEXT", nullable: true),
                    RG = table.Column<int>(type: "INTEGER", nullable: false),
                    DepartmentIdDepartamento = table.Column<int>(type: "INTEGER", nullable: true),
                    IdDepartamento = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Departamentos_DepartmentIdDepartamento",
                        column: x => x.DepartmentIdDepartamento,
                        principalTable: "Departamentos",
                        principalColumn: "IdDepartamento",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_DepartmentIdDepartamento",
                table: "Funcionarios",
                column: "DepartmentIdDepartamento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Departamentos");
        }
    }
}

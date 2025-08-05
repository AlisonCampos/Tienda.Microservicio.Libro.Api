using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Tienda.Microservicio.Libro.Api.Migrations
{
    /// <inheritdoc />
    public partial class veruno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AutorLibros",
                columns: table => new
                {
                    AutorLibroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false),
                    Apellido = table.Column<string>(type: "longtext", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    AutorLibroGuid = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorLibros", x => x.AutorLibroId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GradoAcademicos",
                columns: table => new
                {
                    GradoAcademicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false),
                    CentroAcademico = table.Column<string>(type: "longtext", nullable: false),
                    FechaGrado = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    AutorLibroId = table.Column<int>(type: "int", nullable: false),
                    GradoAcademicoGuid = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradoAcademicos", x => x.GradoAcademicoId);
                    table.ForeignKey(
                        name: "FK_GradoAcademicos_AutorLibros_AutorLibroId",
                        column: x => x.AutorLibroId,
                        principalTable: "AutorLibros",
                        principalColumn: "AutorLibroId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_GradoAcademicos_AutorLibroId",
                table: "GradoAcademicos",
                column: "AutorLibroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GradoAcademicos");

            migrationBuilder.DropTable(
                name: "AutorLibros");
        }
    }
}

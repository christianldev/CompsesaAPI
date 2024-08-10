using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace API.Compsesa.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DatosSensores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Codigo_Parametro = table.Column<int>(type: "integer", nullable: false),
                    Parametro_Sensores_Id = table.Column<string>(type: "text", nullable: false),
                    Nombre_Parametro = table.Column<string>(type: "text", nullable: false),
                    Fecha_Dato = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Valor_Numero = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosSensores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sensores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Codigo_Parametro = table.Column<int>(type: "integer", nullable: false),
                    Descripcion_Larga = table.Column<string>(type: "text", nullable: false),
                    Descripcion_Med = table.Column<string>(type: "text", nullable: false),
                    Descripcion_Corta = table.Column<string>(type: "text", nullable: false),
                    Abreviacion = table.Column<string>(type: "text", nullable: false),
                    Observacione = table.Column<string>(type: "text", nullable: false),
                    Fecha_Creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Fecha_Modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    Unidad = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensores", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatosSensores");

            migrationBuilder.DropTable(
                name: "Sensores");
        }
    }
}

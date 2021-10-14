using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendaSIG5.App.Persistencia.Migrations
{
    public partial class Azure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgendaCitas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_Id_Sede = table.Column<int>(type: "int", nullable: false),
                    FK_Id_Paciente = table.Column<int>(type: "int", nullable: false),
                    FK_Id_Medico = table.Column<int>(type: "int", nullable: false),
                    FechaCita = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoraCita = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgendaCitas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCiudad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefonos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ECorreo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eps = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistroMedico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    FK_Id_Sede = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sedes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FK_Id_Ciudad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgendaCitas");

            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Sedes");
        }
    }
}

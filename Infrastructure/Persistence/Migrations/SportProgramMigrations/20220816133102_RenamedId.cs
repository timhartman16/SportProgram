using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Persistence.Migrations.SportProgramMigrations
{
    public partial class RenamedId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SportTrainingId",
                table: "SportTrainings",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SportTrainings",
                newName: "SportTrainingId");
        }
    }
}

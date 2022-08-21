using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Persistence.Migrations.SportProgramMigrations
{
    public partial class RemovedRequiredMaxLengthForTitleInSportTraining : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SportTraining",
                table: "SportTraining");

            migrationBuilder.RenameTable(
                name: "SportTraining",
                newName: "SportTrainings");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SportTrainings",
                table: "SportTrainings",
                column: "SportTrainingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SportTrainings",
                table: "SportTrainings");

            migrationBuilder.RenameTable(
                name: "SportTrainings",
                newName: "SportTraining");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SportTraining",
                table: "SportTraining",
                column: "SportTrainingId");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmentTwo.Migrations
{
    public partial class newschedulememberproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoachEmail",
                table: "ScheduleMembers",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Schedule",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Schedule",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CoachEmail",
                table: "Schedule",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoachEmail",
                table: "ScheduleMembers");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Schedule",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Schedule",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CoachEmail",
                table: "Schedule",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}

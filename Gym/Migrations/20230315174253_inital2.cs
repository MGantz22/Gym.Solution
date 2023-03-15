using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gym.Migrations
{
    public partial class inital2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocationInstructors_LocationInstructors_LocationInstructorId1",
                table: "LocationInstructors");

            migrationBuilder.DropIndex(
                name: "IX_LocationInstructors_LocationInstructorId1",
                table: "LocationInstructors");

            migrationBuilder.DropColumn(
                name: "LocationInstructorId1",
                table: "LocationInstructors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationInstructorId1",
                table: "LocationInstructors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationInstructors_LocationInstructorId1",
                table: "LocationInstructors",
                column: "LocationInstructorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_LocationInstructors_LocationInstructors_LocationInstructorId1",
                table: "LocationInstructors",
                column: "LocationInstructorId1",
                principalTable: "LocationInstructors",
                principalColumn: "LocationInstructorId");
        }
    }
}

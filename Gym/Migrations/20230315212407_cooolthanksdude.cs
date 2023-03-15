using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gym.Migrations
{
    public partial class cooolthanksdude : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassTypes_Classes_ClassId",
                table: "ClassTypes");

            migrationBuilder.DropIndex(
                name: "IX_ClassTypes_ClassId",
                table: "ClassTypes");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "ClassTypes");

            migrationBuilder.AddColumn<int>(
                name: "TypeOfClassId",
                table: "Classes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TypeOfClassId",
                table: "Classes",
                column: "TypeOfClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_ClassTypes_TypeOfClassId",
                table: "Classes",
                column: "TypeOfClassId",
                principalTable: "ClassTypes",
                principalColumn: "TypeOfClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_ClassTypes_TypeOfClassId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_TypeOfClassId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "TypeOfClassId",
                table: "Classes");

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "ClassTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ClassTypes_ClassId",
                table: "ClassTypes",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassTypes_Classes_ClassId",
                table: "ClassTypes",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

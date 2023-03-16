using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gym.Migrations
{
    public partial class seehowitworks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_ClassTypes_TypeOfClassId",
                table: "Classes");

            migrationBuilder.AlterColumn<int>(
                name: "TypeOfClassId",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_ClassTypes_TypeOfClassId",
                table: "Classes",
                column: "TypeOfClassId",
                principalTable: "ClassTypes",
                principalColumn: "TypeOfClassId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_ClassTypes_TypeOfClassId",
                table: "Classes");

            migrationBuilder.AlterColumn<int>(
                name: "TypeOfClassId",
                table: "Classes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_ClassTypes_TypeOfClassId",
                table: "Classes",
                column: "TypeOfClassId",
                principalTable: "ClassTypes",
                principalColumn: "TypeOfClassId");
        }
    }
}

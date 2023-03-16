using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gym.Migrations
{
    public partial class byeeeeeeeee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_ClassTypes_TypeOfClassId",
                table: "Classes");

            migrationBuilder.DropTable(
                name: "ClassTypes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_TypeOfClassId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "TypeOfClassId",
                table: "Classes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeOfClassId",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ClassTypes",
                columns: table => new
                {
                    TypeOfClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TypeOfClassName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassTypes", x => x.TypeOfClassId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TypeOfClassId",
                table: "Classes",
                column: "TypeOfClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_ClassTypes_TypeOfClassId",
                table: "Classes",
                column: "TypeOfClassId",
                principalTable: "ClassTypes",
                principalColumn: "TypeOfClassId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

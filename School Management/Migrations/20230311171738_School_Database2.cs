using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School_Management.Migrations
{
    public partial class School_Database2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "subjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Teacher_Branch",
                columns: table => new
                {
                    Teacher_Branch_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher_Branch", x => x.Teacher_Branch_Id);
                    table.ForeignKey(
                        name: "FK_Teacher_Branch_branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teacher_Branch_teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teacher_Subject",
                columns: table => new
                {
                    Teacher_Subject_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher_Subject", x => x.Teacher_Subject_Id);
                    table.ForeignKey(
                        name: "FK_Teacher_Subject_subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teacher_Subject_teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_subjects_BranchId",
                table: "subjects",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_Branch_BranchId",
                table: "Teacher_Branch",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_Branch_TeacherId",
                table: "Teacher_Branch",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_Subject_SubjectId",
                table: "Teacher_Subject",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_Subject_TeacherId",
                table: "Teacher_Subject",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_subjects_branches_BranchId",
                table: "subjects",
                column: "BranchId",
                principalTable: "branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_subjects_branches_BranchId",
                table: "subjects");

            migrationBuilder.DropTable(
                name: "Teacher_Branch");

            migrationBuilder.DropTable(
                name: "Teacher_Subject");

            migrationBuilder.DropIndex(
                name: "IX_subjects_BranchId",
                table: "subjects");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "subjects");
        }
    }
}

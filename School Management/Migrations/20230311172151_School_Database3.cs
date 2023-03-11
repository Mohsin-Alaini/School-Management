using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School_Management.Migrations
{
    public partial class School_Database3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Branch_branches_BranchId",
                table: "Teacher_Branch");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Branch_teachers_TeacherId",
                table: "Teacher_Branch");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Subject_subjects_SubjectId",
                table: "Teacher_Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Subject_teachers_TeacherId",
                table: "Teacher_Subject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teacher_Subject",
                table: "Teacher_Subject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teacher_Branch",
                table: "Teacher_Branch");

            migrationBuilder.RenameTable(
                name: "Teacher_Subject",
                newName: "teachers_subjects");

            migrationBuilder.RenameTable(
                name: "Teacher_Branch",
                newName: "teachers_branches");

            migrationBuilder.RenameIndex(
                name: "IX_Teacher_Subject_TeacherId",
                table: "teachers_subjects",
                newName: "IX_teachers_subjects_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Teacher_Subject_SubjectId",
                table: "teachers_subjects",
                newName: "IX_teachers_subjects_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Teacher_Branch_TeacherId",
                table: "teachers_branches",
                newName: "IX_teachers_branches_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Teacher_Branch_BranchId",
                table: "teachers_branches",
                newName: "IX_teachers_branches_BranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_teachers_subjects",
                table: "teachers_subjects",
                column: "Teacher_Subject_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_teachers_branches",
                table: "teachers_branches",
                column: "Teacher_Branch_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_teachers_branches_branches_BranchId",
                table: "teachers_branches",
                column: "BranchId",
                principalTable: "branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teachers_branches_teachers_TeacherId",
                table: "teachers_branches",
                column: "TeacherId",
                principalTable: "teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teachers_subjects_subjects_SubjectId",
                table: "teachers_subjects",
                column: "SubjectId",
                principalTable: "subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teachers_subjects_teachers_TeacherId",
                table: "teachers_subjects",
                column: "TeacherId",
                principalTable: "teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_teachers_branches_branches_BranchId",
                table: "teachers_branches");

            migrationBuilder.DropForeignKey(
                name: "FK_teachers_branches_teachers_TeacherId",
                table: "teachers_branches");

            migrationBuilder.DropForeignKey(
                name: "FK_teachers_subjects_subjects_SubjectId",
                table: "teachers_subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_teachers_subjects_teachers_TeacherId",
                table: "teachers_subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_teachers_subjects",
                table: "teachers_subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_teachers_branches",
                table: "teachers_branches");

            migrationBuilder.RenameTable(
                name: "teachers_subjects",
                newName: "Teacher_Subject");

            migrationBuilder.RenameTable(
                name: "teachers_branches",
                newName: "Teacher_Branch");

            migrationBuilder.RenameIndex(
                name: "IX_teachers_subjects_TeacherId",
                table: "Teacher_Subject",
                newName: "IX_Teacher_Subject_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_teachers_subjects_SubjectId",
                table: "Teacher_Subject",
                newName: "IX_Teacher_Subject_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_teachers_branches_TeacherId",
                table: "Teacher_Branch",
                newName: "IX_Teacher_Branch_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_teachers_branches_BranchId",
                table: "Teacher_Branch",
                newName: "IX_Teacher_Branch_BranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teacher_Subject",
                table: "Teacher_Subject",
                column: "Teacher_Subject_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teacher_Branch",
                table: "Teacher_Branch",
                column: "Teacher_Branch_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Branch_branches_BranchId",
                table: "Teacher_Branch",
                column: "BranchId",
                principalTable: "branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Branch_teachers_TeacherId",
                table: "Teacher_Branch",
                column: "TeacherId",
                principalTable: "teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Subject_subjects_SubjectId",
                table: "Teacher_Subject",
                column: "SubjectId",
                principalTable: "subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Subject_teachers_TeacherId",
                table: "Teacher_Subject",
                column: "TeacherId",
                principalTable: "teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

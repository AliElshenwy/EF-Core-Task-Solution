using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_Task.Migrations
{
    /// <inheritdoc />
    public partial class LastInitaaaalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentsId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "DepartmentsId",
                table: "Students",
                newName: "DepartmentID");

            migrationBuilder.RenameIndex(
                name: "IX_Students_DepartmentsId",
                table: "Students",
                newName: "IX_Students_DepartmentID");

            migrationBuilder.RenameColumn(
                name: "Dept_ID",
                table: "Instructors",
                newName: "Dep_idId");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Courses",
                newName: "DepartmentID");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_DepartmentId",
                table: "Courses",
                newName: "IX_Courses_DepartmentID");

            migrationBuilder.AlterColumn<int>(
                name: "Salary",
                table: "Instructors",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course",
                columns: new[] { "stud_Id", "Course_Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_course_Insts",
                table: "course_Insts",
                columns: new[] { "ins_ID", "Course_ID" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "HiringDate", "Ins_id", "Name" },
                values: new object[] { 3, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "C++" });

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dep_idId",
                table: "Instructors",
                column: "Dep_idId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentID",
                table: "Courses",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dep_idId",
                table: "Instructors",
                column: "Dep_idId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentID",
                table: "Students",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DepartmentID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dep_idId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentID",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_Dep_idId",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_course_Insts",
                table: "course_Insts");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Students",
                newName: "DepartmentsId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_DepartmentID",
                table: "Students",
                newName: "IX_Students_DepartmentsId");

            migrationBuilder.RenameColumn(
                name: "Dep_idId",
                table: "Instructors",
                newName: "Dept_ID");

            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Courses",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_DepartmentID",
                table: "Courses",
                newName: "IX_Courses_DepartmentId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "Instructors",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentsId",
                table: "Students",
                column: "DepartmentsId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

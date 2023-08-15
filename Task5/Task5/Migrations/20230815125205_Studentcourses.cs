using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Task5.Migrations
{
    /// <inheritdoc />
    public partial class Studentcourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
              table: "Students",
              columns: new[] { "StudentId", "Description", "Name" },
              values: new object[,]
              {
                    { 1, "smart", "Aziza" },
                    { 2, "smart", "Malak" },
                    { 3, "smart", "Mayar" }
              });

            migrationBuilder.InsertData(
                table: "stdCourse",
                columns: new[] { "StudentCourseId", "CourseId", "StudentId", "mark" },
                values: new object[,]
                {
                    { 1, 1, 1, 99 },
                    { 2, 2, 2, 90 },
                    { 3, 3, 3, 88 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}

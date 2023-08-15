using Task5.Configuration;
using Task5.Tables;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using Task5.Tables;

namespace Task5
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> option) : base(option)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> stdCourse { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          modelBuilder.ApplyConfiguration(new StudentCourseConfiguration());

            var a = new StudentCourse { StudentCourseId = 1, CourseId =1, StudentId=1, mark=99 };
            var b = new StudentCourse { StudentCourseId = 2, CourseId = 2, StudentId = 2, mark = 90 };
            var c = new StudentCourse { StudentCourseId = 3, CourseId = 3, StudentId = 3, mark = 88 };
            modelBuilder.Entity<StudentCourse>().HasData(a, b, c);


            base.OnModelCreating(modelBuilder);

        }
    }
}
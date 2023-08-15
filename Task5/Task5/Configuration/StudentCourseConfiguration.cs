using Microsoft.EntityFrameworkCore;
using Task5.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task5.Configuration
{
    public class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(key => key.StudentCourseId);


            builder.HasOne(v => v.Student).WithMany( v => v.StudentCourses).HasForeignKey(b => b.StudentId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(v => v.Course).WithMany(v => v.StudentCourses).HasForeignKey(b => b.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(v => v.mark).IsRequired();



        }

    }
}

using System.ComponentModel.DataAnnotations;

namespace Task5.Tables
{
    public class Course
    {
        public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
        public int CourseId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

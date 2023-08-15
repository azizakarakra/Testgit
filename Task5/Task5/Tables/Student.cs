using System.ComponentModel.DataAnnotations;

namespace Task5.Tables
{
    public class Student
    {
        public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

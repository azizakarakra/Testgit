using Task5.Tables;

namespace Task5.Models
{
    public class StudentCourseModel
    {
        public int StudentCourseId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int mark { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}

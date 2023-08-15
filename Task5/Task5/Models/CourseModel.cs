using System.ComponentModel.DataAnnotations;
using Task5.Tables;

namespace Task5.Models
{
    public class CourseModel
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace Task5.Service.StudentCourse
{
    public class StudentCourseService : IStudentCourseService
    {
        private readonly AplicationDbContext _context;

        public StudentCourseService(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Tables.StudentCourse>> GetAll()
        {
            return await _context.stdCourse.ToListAsync();

        }

        public async Task<Tables.StudentCourse> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace Task5.Service.Course
{
    public class CourseService : ICourseService
    {
        private readonly AplicationDbContext _context;

        public CourseService(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Tables.Course>> GetAll()
        {
            return await _context.Courses.ToListAsync();

        }

        public async Task<Tables.Course> GetById(int id)
        {
            throw new NotImplementedException();
        }

    }
}

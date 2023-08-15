using Microsoft.EntityFrameworkCore;

namespace Task5.Service.Student
{
    public class StudentService : IStudentService
    {
        private readonly AplicationDbContext _context;

        public StudentService(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Tables.Student>> GetAll()
        {
            return await _context.Students.ToListAsync();

        }

        public async Task<Tables.Student> GetById(int id)
        {
            throw new NotImplementedException();
        }

    }
}

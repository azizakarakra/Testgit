using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task5.Models;
using Task5.Service.Student;
using Task5.Tables;

namespace Task5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        private readonly IStudentService _studentService;

        public StudentController(AplicationDbContext context, IStudentService studentService)
        {
            _context = context;
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudent()
        {
            var list = await _studentService.GetAll();
            return Ok(list);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var obj = await _context.Students.FirstOrDefaultAsync(c => c.StudentId == id);
            if (obj == null)
            {
                return NotFound("the Student is not found");
            }

            return Ok(obj);

        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent(StudentModel model)
        {
            var obj = new Student()
            {
                Name = model.Name,
                Description = model.Description,

            };
            await _context.Students.AddAsync(obj);
            await _context.SaveChangesAsync();
            return Ok(obj);

        }

        [HttpPut]
        public async Task<IActionResult> UpdateStudent(int id, StudentModel model)
        {

            var obj = await _context.Students.FirstOrDefaultAsync(c => c.StudentId == id);
            if (obj == null)
            {
                return NotFound("the Student is not found");
            }
            obj.Name = model.Name;
            obj.Description = model.Description;
            await _context.SaveChangesAsync();

            return Ok();

        }

        [HttpDelete]
        public async Task<IActionResult> DeleteStudent(int id)
        {

            var obj = await _context.Students.FirstOrDefaultAsync(c => c.StudentId == id);
            if (obj == null)
            {
                return NotFound("the Student is not found");
            }

            _context.Students.Remove(obj);
            await _context.SaveChangesAsync();

            return Ok();

        }

    }
}

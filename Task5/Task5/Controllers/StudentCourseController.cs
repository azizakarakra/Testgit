using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task5.Models;
using Task5.Service.Course;
using Task5.Service.StudentCourse;
using Task5.Tables;

namespace Task5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentCourseController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        private readonly IStudentCourseService _studentcourseservice;

        public StudentCourseController(AplicationDbContext context, IStudentCourseService studentcourseservice)
        {
            _context = context;
            _studentcourseservice = studentcourseservice;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudentCourse()
        {
            var list = await _studentcourseservice.GetAll();
            return Ok(list);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentCourseById(int id)
        {
            var obj = await _context.stdCourse.FirstOrDefaultAsync(c => c.StudentCourseId == id);
            if (obj == null)
            {
                return NotFound("the StudentCourse is not found");
            }

            return Ok(obj);

        }

        [HttpPost]
        public async Task<IActionResult> CreateStudentCourse(StudentCourseModel model)
        {
            var obj = new StudentCourse()
            {
                mark = model.mark

            };
            await _context.stdCourse.AddAsync(obj);
            await _context.SaveChangesAsync();
            return Ok(obj);

        }

        [HttpPut]
        public async Task<IActionResult> UpdateStudentCourse(int id, StudentCourseModel model)
        {

            var obj = await _context.stdCourse.FirstOrDefaultAsync(c => c.StudentCourseId == id);
            if (obj == null)
            {
                return NotFound("the StudentCourse is not found");
            }
            obj.mark = model.mark;
            await _context.SaveChangesAsync();

            return Ok();

        }

        [HttpDelete]
        public async Task<IActionResult> DeleteStudentCourse(int id)
        {

            var obj = await _context.stdCourse.FirstOrDefaultAsync(c => c.StudentCourseId == id);
            if (obj == null)
            {
                return NotFound("the StudentCourse is not found");
            }

            _context.stdCourse.Remove(obj);
            await _context.SaveChangesAsync();

            return Ok();

        }
    }
}

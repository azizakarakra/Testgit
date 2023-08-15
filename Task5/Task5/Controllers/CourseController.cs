using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task5.Models;
using Task5.Service.Course;
using Task5.Service.Student;
using Task5.Tables;

namespace Task5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        private readonly ICourseService _courseService;

        public CourseController(AplicationDbContext context, ICourseService courseService)
        {
            _context = context;
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCourse()
        {
            var list = await _courseService.GetAll();
            return Ok(list);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourseById(int id)
        {
            var obj = await _context.Courses.FirstOrDefaultAsync(c => c.CourseId == id);
            if (obj == null)
            {
                return NotFound("the Course is not found");
            }

            return Ok(obj);

        }

        [HttpPost]
        public async Task<IActionResult> CreateCourse(CourseModel model)
        {
            var obj = new Course()
            {
                Name = model.Name,
                Description = model.Description,

            };
            await _context.Courses.AddAsync(obj);
            await _context.SaveChangesAsync();
            return Ok(obj);

        }

        [HttpPut]
        public async Task<IActionResult> UpdateCourse(int id, CourseModel model)
        {

            var obj = await _context.Courses.FirstOrDefaultAsync(c => c.CourseId == id);
            if (obj == null)
            {
                return NotFound("the Course is not found");
            }
            obj.Name = model.Name;
            obj.Description = model.Description;
            await _context.SaveChangesAsync();

            return Ok();

        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCourse(int id)
        {

            var obj = await _context.Courses.FirstOrDefaultAsync(c => c.CourseId == id);
            if (obj == null)
            {
                return NotFound("the Course is not found");
            }

            _context.Courses.Remove(obj);
            await _context.SaveChangesAsync();

            return Ok();

        }
    }
}

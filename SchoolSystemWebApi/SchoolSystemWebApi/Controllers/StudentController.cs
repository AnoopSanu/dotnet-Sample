using Microsoft.AspNetCore.Mvc;
using SchoolSystemWebApi.DAL;
using SchoolSystemWebApi.Models;
using System.Linq;

namespace SchoolSystemWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly SchoolSystemContext dbContext;
        public StudentController(SchoolSystemContext context)
        {
            dbContext = context;
        }

        //api/student
        [HttpGet]
        public IActionResult Get()
        {
            var listStudents = dbContext.Student.ToList();

            return Ok(listStudents);
        }

        //api/student/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var student = dbContext.Student.FirstOrDefault(x => x.Id == id); 

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        //api/student/GetByStandard/10
        [HttpGet("[action]/{standard}")]
        public IActionResult GetByStandard(int standard)
        {
            var listStudent = dbContext.Student.Where(x => x.Standard == standard).ToList();

            if (listStudent == null)
            {
                return NotFound();
            }

            return Ok(listStudent);
        }

        [HttpPost]
        public IActionResult Post(Student data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            dbContext.Student.Add(data);
            dbContext.SaveChanges();

            return Ok("Students saved successfully.");
        }
    }
}

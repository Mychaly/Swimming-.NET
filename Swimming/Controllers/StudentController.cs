using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _studentService.GetAllStudents();
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            var s = _studentService.GetStudentById(id);
            if (s == null)
                return NotFound();
            return s;

        }

        // POST api/<StudentController>
        [HttpPost]
        public ActionResult Post([FromBody] Student s)
        {
            //בדיקה האם הקורס קיים במאגר
            //var t = _context.CoursesList.Find(x => x.id == s.courseId);
            //if (t == null)
            //    return NotFound();
            //if (s.id.ToString().Length != 9)
            //    return BadRequest();
            _studentService.AddStudent(s);
            return Ok();

        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Student s)
        {
            //var t = _context.CoursesList.Find(x => x.id == s.courseId);
            //if (t == null)
            //    return NotFound();
            //if (s.id.ToString().Length != 9)
            //    return BadRequest();

            //var s2 = _context.StudentList.Find(e => e.id == id);
            //if (s2 == null)
            //    return NotFound();
            //s2.id = id;
            //s2.name = s.name;
            //s2.age = s.age;
            //s2.courseId = s.courseId;
            _studentService.UpdateStudent(id,s);
            return Ok();
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            //var s = _context.StudentList.Find(e => e.id == id);
            //if (s == null)
            //    return NotFound();
            //_context.StudentList.Remove(s);
            _studentService.DeleteStudent(id);
            return Ok();
        }
    }
}

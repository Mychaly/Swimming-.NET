using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Swimming.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        static List<Student> students = new List<Student> { new Student { id = 1, name = "tamar", age = 13,courseId=1 }, new Student { id = 3, name = "rachel", age = 16, courseId = 1 }, new Student { id = 2, name = "lali", age = 16, courseId = 1 } };
        static int count = 3;
        // GET: api/<StudentController>
        [HttpGet]
        public List<Student> Get()
        {
            return students;
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            var s = students.Find(x => x.id == id);
            return s;
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] Student s)
        {
            students.Add(new Student { id = ++count, name = s.name, age = s.age,courseId=s.courseId });

        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student s)
        {
            var s2 = students.Find(e => e.id == id);
            s2.name = s.name;
            s2.age = s.age;
            s2.courseId = s.courseId;
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var s = students.Find(e => e.id == id);
            students.Remove(s);
        }
    }
}

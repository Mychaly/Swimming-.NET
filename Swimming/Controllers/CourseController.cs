using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Swimming.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        static List<Course> courses = new List<Course> { new Course { id = 1, name = "back", teacherId = 1 }, new Course { id = 3, name = "side", teacherId = 3 }, new Course { id = 2, name = "breast", teacherId = 2 } };
        static int count=3;

        // GET: api/<CourseController>
        [HttpGet]
        public List<Course> Get()
        {
            return courses;
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public Course Get(int id)
        {
            var c2 = courses.Find(x => x.id == id);
            return c2;
        }

        // POST api/<CourseController>
        [HttpPost]
        public void Post([FromBody] Course c )
        {
            courses.Add(new Course { id = ++count, name =c.name, teacherId = c.teacherId });

        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Course c)
        {
            var c2=courses.Find(x => x.id == id);
            c2.name=c.name; 
            c2.teacherId=c.teacherId;
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var c = courses.Find(x => x.id == id);
            courses.Remove(c);
        }
    }
}

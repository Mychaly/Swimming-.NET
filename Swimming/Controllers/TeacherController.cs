using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Swimming.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {

        static List<Teacher> teachers = new List<Teacher> { new Teacher { id = 1, name = "SARA" }, new Teacher { id = 3, name = "TOVA" }, new Teacher { id = 2, name = "SHOSHI" } };
        static int count = 3;
        // GET: api/<TeacherController>
        [HttpGet]
        public List<Teacher> Get()
        {
            return teachers;
        }

        // GET api/<TeacherController>/5
        [HttpGet("{id}")]
        public Teacher Get(int id)
        {
            var s = teachers.Find(x => x.id == id);
            return s;
        }

        // POST api/<TeacherController>
        [HttpPost]
        public void Post([FromBody] Teacher t)
        {
            teachers.Add(new Teacher { id = ++count, name = t.name });

        }

        // PUT api/<TeacherController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Teacher t)
        {
            var t2 = teachers.Find(e => e.id == id);
            t2.name = t.name;
         
        }

        // DELETE api/<TeacherController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var t2 = teachers.Find(e => e.id == id);
            teachers.Remove(t2);
        }
    }
}

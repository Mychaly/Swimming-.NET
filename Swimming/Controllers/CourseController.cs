using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly    ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        // GET: api/<CourseController>
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return _courseService.GetAllCourses();
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public ActionResult<Course> Get(int id)
        {
            var c2 = _courseService.GetCourseById(id);
            if (c2 == null)
                return NotFound();
            return c2;
        }

        // POST api/<CourseController>
        [HttpPost]
        public ActionResult Post([FromBody] Course c)
        {
            //בדיקה למורה האם קיימת במאגר
            //var t = _context.TeacherList.Find(x => x.id == c.teacherId);
            //if (t == null)
            //    return NotFound();
            _courseService.AddCourse(c);    
            return Ok();


        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Course c)
        {
            //בבדיקה למורה האם קיימת במאגר
            //var t = _context.TeacherList.Find(x => x.id == c.teacherId);
            //if (t == null)
            //    return NotFound();
            _courseService.UpdateCourse(id, c); 
            return Ok();
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            //var c = _context.CoursesList.Find(x => x.id == id);
            //if (c == null)
            //    return NotFound();
            //_context.CoursesList.Remove(c);
            _courseService.DeleteCourse(id);
            return Ok();

        }
    }
}

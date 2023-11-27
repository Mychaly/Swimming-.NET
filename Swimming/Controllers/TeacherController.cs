using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {

        private readonly ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }


        // GET: api/<TeacherController>
        [HttpGet]
        public IEnumerable<Teacher> Get()
        {
            return _teacherService.GetAllTeachers();
        }

        // GET api/<TeacherController>/5
        [HttpGet("{id}")]
        public ActionResult<Teacher> Get(int id)
        {

            var t = _teacherService.GetTeacherById(id);
            if (t == null)
                return NotFound();
            return t;
        }

        // POST api/<TeacherController>
        [HttpPost]
        public ActionResult Post([FromBody] Teacher t)
        {
            //var t1 = _context.TeacherList.Find(x => x.id == t.id);
            //if (t1 == null)
            //    return NotFound();
            //if (t.id.ToString().Length != 9)
            //    return BadRequest();
            //_context.TeacherList.Add(new Teacher { id = t.id, name = t.name });
            _teacherService.AddTeacher(t);
            return Ok();

        }

        // PUT api/<TeacherController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Teacher t)
        {

            //var t2 = _context.TeacherList.Find(e => e.id == id); 
            //if (t2 == null)
            //    return NotFound();
            //if (t. id.ToString().Length != 9)
            //    return BadRequest();

            //t2.id=t.id; 
            //t2.name = t.name;
            _teacherService.UpdateTeacher(id, t);
            return Ok();

        }

        // DELETE api/<TeacherController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            //var t2 = _context.TeacherList.Find(e => e.id == id);
            //if (t2 == null)
            //    return NotFound();
            //_context.TeacherList.Remove(t2);
            _teacherService.DeleteTeacher(id);
            return Ok();
        }
    }
}

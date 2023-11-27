using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly DataContext _context;
        public CourseRepository(DataContext context)
        {
            _context = context; 
        }

       

        public IEnumerable<Course> GetAllCourses()
        {
            return _context.CoursesList;
        }

        public Course GetCourseById(int id)
        {
            return _context.CoursesList.First(x=>x.id == id);
        }
        public void AddCourse(Course course)
        {
            _context.CoursesList.Add(new Course { id = _context.CourseCount++, name = course.name, teacherId = course.teacherId });

        }

        public void UpdateCourse(int id, Course course)
        {
            var c2= _context.CoursesList.Find(x => x.id == id);
            c2.name=course.name; 
            c2.teacherId=course.teacherId;
        }

        public void DeleteCourse(int id)
        {
            var c = _context.CoursesList.Find(x => x.id == id);
            _context.CoursesList.Remove(c);
            
        }
    }
}

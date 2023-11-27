using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

       

        public IEnumerable<Course> GetAllCourses()
        {
            return _courseRepository.GetAllCourses();   
        }

        public Course GetCourseById(int id)
        {
            return _courseRepository.GetCourseById(id); 
        }
        public void AddCourse(Course course)
        {
            _courseRepository.AddCourse(course);    
        }

        public void UpdateCourse(int id, Course course)
        {
            _courseRepository.UpdateCourse(id, course);
        }

        public void DeleteCourse(int id)
        {
            _courseRepository.DeleteCourse(id);
        }
    }
}

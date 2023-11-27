using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface ICourseService
    {
        IEnumerable<Course> GetAllCourses();

        Course GetCourseById(int id);
        void AddCourse(Course course);
        void UpdateCourse(int id,Course course);
        void DeleteCourse(int id);

    }
}

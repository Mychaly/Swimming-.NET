using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface ITeacherService
    {
        IEnumerable<Teacher> GetAllTeachers();

        Teacher GetTeacherById(int id);
        void AddTeacher(Teacher teacher);
        void UpdateTeacher(int id, Teacher teacher);
        void DeleteTeacher(int id);
    }
}

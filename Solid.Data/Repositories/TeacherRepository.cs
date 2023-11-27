using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly DataContext _context;
        public TeacherRepository(DataContext context)
        {
            _context = context;
        }

        

        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _context.TeacherList;
        }

        public Teacher GetTeacherById(int id)
        {
            return _context.TeacherList.First(x => x.id == id);
        }
        public void AddTeacher(Teacher teacher)
        {
            _context.TeacherList.Add(new Teacher { id = teacher.id, name = teacher.name });
        }
        public void UpdateTeacher(int id, Teacher teacher)
        {
            var t2 = _context.TeacherList.Find(e => e.id == id);
            t2.id=teacher.id; 
            t2.name = teacher.name;
        }
        public void DeleteTeacher(int id)
        {
            var t = _context.TeacherList.Find(e => e.id == id);
            _context.TeacherList.Remove(t);
        }

        
    }
}

using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _context;
        public StudentRepository(DataContext context)
        {
            _context = context;
        }

       

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.StudentList;
        }

        public Student GetStudentById(int id)
        {
            return _context.StudentList.First(x => x.id == id);
        }

        public void AddStudent(Student student)
        {
            _context.StudentList.Add(new Student { id =student.id, name = student.name,age = student.age,courseId=student.courseId });

        }
        public void UpdateStudent(int id, Student student)
        {
            var s2 = _context.StudentList.Find(e => e.id == id);
            s2.id = student.id;
            s2.name = student.name;
            s2.age = student.age;
            s2.courseId = student.courseId;
        }
        public void DeleteStudent(int id)
        {
            var s = _context.StudentList.Find(e => e.id == id);
            _context.StudentList.Remove(s);
        }
    }
}

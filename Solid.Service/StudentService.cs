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
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

       

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();

        }

        public Student GetStudentById(int id)
        {
            return _studentRepository.GetStudentById(id);
        }
        public void AddStudent(Student student)
        {
            _studentRepository.AddStudent(student);
        }
        public void UpdateStudent(int id, Student student)
        {
            _studentRepository.UpdateStudent(id, student);
        }
        public void DeleteStudent(int id)
        {
            _studentRepository.DeleteStudent(id);
        }

       
        
    }
}


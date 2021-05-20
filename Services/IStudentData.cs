using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByeMed.Models;

namespace ByeMed.Services
{
    public interface IStudentData
    {
        IEnumerable<Student> GetStudents();

        Student GetStudent(int codigo);

        Student AddStudent(Student newStudent);

        Student ModifyStudent(Student updStudent);

        void DeleteStudent(int codigo);
    }
}

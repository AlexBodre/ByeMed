using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByeMed.Data;
using ByeMed.Models;
using ByeMed.Services;
using Microsoft.EntityFrameworkCore;

namespace ByeMed.Services
{
    
    public class StudentService : IStudentData
    {
        private readonly ApplicationDbContext _context;
        public StudentService (ApplicationDbContext context)
        {
            _context = context;
        }


        public Student AddStudent(Student newStudent)
        {
           var nuevo = _context.Students.Add(newStudent);
            _context.SaveChanges();
            return nuevo.Entity;
            
        }

        public Student GetStudent(int codigo)
        {
            var student = _context.Students.FirstOrDefault(x => x.Codigo == codigo);
            return student;
        }

        public IEnumerable<Student> GetStudents()
        {
            var students = _context.Students.ToList();
            return students;
            
        }

        public Student ModifyStudent(Student updStudent)
        {
            _context.Entry(updStudent).State = EntityState.Modified;
            _context.SaveChanges();
            return updStudent;

        }

        public void DeleteStudent(int codigo)
        {
            
           
            try {
                var registro = _context.Students.Find(codigo);
                if (registro != null)
            {
                _context.Remove(registro);
                _context.SaveChanges();
            }
            }
            catch (Exception ex){
                throw ex;
            }
        }

    }
}

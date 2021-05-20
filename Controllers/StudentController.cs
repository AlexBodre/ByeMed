using ByeMed.Models;
using ByeMed.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ByeMed.Controllers
{
    [Route("api/Student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public readonly IStudentData _studentData;
        public StudentController(IStudentData studentData)
        {
            _studentData = studentData;
        }

        [HttpGet, Route("getAll")]
        public IActionResult Get()
        {

            if (_studentData.GetStudents().Count > 0) { 
            return Ok(_studentData.GetStudents());
            }
            else
            {
                return BadRequest("Eto ta vacio");
            }

        }

        [HttpPost, Route("addOne")]
        public IActionResult Post(Student student)
        {
           
            if (student != null)
            {
                return Ok(_studentData.AddStudent(student));
            }
            else
            {
                return BadRequest("Eto ta vacio");
            }
        }

        [HttpPut, Route("updOne")]
        public IActionResult Put(Student student)
        {

            if (student != null)
            {
                return Ok(_studentData.ModifyStudent(student));
            }
            else
            {
                return BadRequest("Eto ta vacio");
            }
        }

        [HttpDelete, Route("DeleteOne/{codigo}")]
        public IActionResult Delete(int codigo)
        {
            _studentData.DeleteStudent(codigo);
             return Ok("Elemento eliminado");
           
        }

        /*
         Ok 200
            BadRequest 302
         */

    }
}

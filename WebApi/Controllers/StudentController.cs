// StudentController.cs
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public List<Student> GetStudents()
        {
            return _studentService.GetStudents();
        }

        [HttpGet("{number}")]
        public Student GetByNumber(int number)
        {
            return _studentService.GetByNumber(number);
        }

        [HttpPost]
        public IActionResult AddStudent([FromBody] Student newStudent)
        {
            try
            {
                _studentService.AddStudent(newStudent);
                return Ok();
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{number}")]
        public IActionResult UpdateStudent(int number, [FromBody] Student updatedStudent)
        {
            _studentService.UpdateStudent(number, updatedStudent);
            return Ok();
        }

        [HttpPatch("{number}")]
        public IActionResult UpdateStudentName(int number, [FromBody] Student updatedStudent)
        {
            _studentService.UpdateStudentName(number, updatedStudent);
            return Ok();
        }

        [HttpDelete("{number}")]
        public IActionResult DeleteStudent(int number)
        {
            _studentService.DeleteStudent(number);
            return Ok();
        }


        
    }

}

// Services/IStudentService.cs
using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Services
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student GetByNumber(int number);
        void AddStudent(Student newStudent);
        void UpdateStudent(int number, Student updatedStudent);
        void UpdateStudentName(int number, Student updatedStudent);
        void DeleteStudent(int number);
    }
}

// StudentService.cs
using WebApi.Models;
using WebApi.Extensions;
namespace WebApi.Services


{
    public class StudentService : IStudentService
    {
        private readonly List<Student> StudentList;

        public StudentService()
        {
            // Öğrenci listesini başlat
            StudentList = new List<Student>
        {
            new Student { Number = 385, Name = "Gülizar", Age = 28, Score = 98 },
            new Student { Number = 245, Name = "İsmail", Age = 25, Score = 85 },
            new Student { Number = 342, Name = "Yaren", Age = 26, Score = 78 }
        };
        }

        public List<Student> GetStudents()
        {
            return StudentList.OrderBy(x => x.Name).ToList();
        }

        public Student GetByNumber(int number)
        {
            return StudentList.FirstOrDefault(student => student.Number == number);
        }

        public void AddStudent(Student newStudent)
        {
            var student = StudentList.SingleOrDefault(x => x.Name == newStudent.Name);

            if (student != null)
            {
                throw new InvalidOperationException("Student with the same name already exists.");
            }

            StudentList.Add(newStudent);
        }

        public void UpdateStudent(int number, Student updatedStudent)
        {
            var student = StudentList.SingleOrDefault(x => x.Number == number);

            if (student != null)
            {
                student.Name = updatedStudent.Name ?? student.Name;
                student.Age = updatedStudent.Age > 0 ? updatedStudent.Age : student.Age;
                student.Score = updatedStudent.Score;
            }
        }

        public void UpdateStudentName(int number, Student updatedStudent)
        {
            var student = StudentList.SingleOrDefault(x => x.Number == number);

            if (student != null)
            {
                student.Name = updatedStudent.Name ?? student.Name;
            }
        }

        public void DeleteStudent(int number)
        {
            var student = StudentList.SingleOrDefault(x => x.Number == number);

            if (student != null)
            {
                StudentList.Remove(student);
            }
        }
    }

}

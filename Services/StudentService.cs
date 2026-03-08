using StudentManagement.API.Models;

namespace StudentManagement.API.Services
{
    public class StudentService : IStudentService
    {
        // In-memory list just for learning
        private static readonly List<Student> _students = new List<Student>
        {
            new Student { Id = 1, Name = "Rahul", Age = 20 },
            new Student { Id = 2, Name = "Priya", Age = 21 }
        };

        public List<Student> GetAll()
        {
            return _students;
        }
        public Student? GetById(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        public Student Add(Student student)
        {
            var nextId = _students.Max(s => s.Id) + 1;
            student.Id = nextId;
            _students.Add(student);
            return student;
        }
    }

}

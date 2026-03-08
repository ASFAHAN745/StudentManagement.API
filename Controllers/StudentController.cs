using Microsoft.AspNetCore.Mvc;
using StudentManagement.API.Models;
using StudentManagement.API.Services;

namespace StudentManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET /api/student
        [HttpGet]
        public IActionResult GetAll()
        {
            var students = _studentService.GetAll();
            return Ok(students);
        }

        // GET /api/student/1
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var student = _studentService.GetById(id);
            if (student is null)
                return NotFound($"Student with Id {id} not found.");

            return Ok(student);
        }

        // POST /api/student
        [HttpPost]
        public IActionResult Add(Student student)
        {
            var created = _studentService.Add(student);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }
    }

}

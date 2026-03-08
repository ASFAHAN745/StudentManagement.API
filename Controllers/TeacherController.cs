using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new[]
            {
                new { Id = 1, Name = "Teacher 1", Subject = "Math" },
                new { Id = 2, Name = "Teacher 2", Subject = "Science" }
            });
        }
    }

}

using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.API.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
// Added new Comment on the CourseController.cs class
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

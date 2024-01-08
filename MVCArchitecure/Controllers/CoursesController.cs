using Microsoft.AspNetCore.Mvc;

namespace MVCArchitecure.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Courses()
        {
            return View();
        }
    }
}

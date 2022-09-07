using Microsoft.AspNetCore.Mvc;

namespace EduhomeTask.Controllers
{
    public class TeachersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

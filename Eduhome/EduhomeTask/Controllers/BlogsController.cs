using Microsoft.AspNetCore.Mvc;

namespace EduhomeTask.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

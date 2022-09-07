using Microsoft.AspNetCore.Mvc;

namespace EduhomeTask.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

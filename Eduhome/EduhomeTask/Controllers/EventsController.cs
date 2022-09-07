using Microsoft.AspNetCore.Mvc;

namespace EduhomeTask.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

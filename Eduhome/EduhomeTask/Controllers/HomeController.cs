using EduhomeTask.DAL;
using EduhomeTask.Models;
using EduhomeTask.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EduhomeTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            

            HomeVM homeVM = new HomeVM
            {
                Sliders = _db.Sliders.Where(x => !x.IsDeactive).ToList(),
                About = _db.Abouts.First(),
                Courses = _db.Courses.Take(3).ToList(),
                Services = _db.Services.Where(x => !x.IsDeactive).ToList(),
                Feedbacks = _db.Feedbacks.ToList(),
                Notices = _db.Notices.ToList(),
                Blogs = _db.Blogs.OrderByDescending(x=>x.Id).Take(3).ToList(),
                Events = _db.Events.ToList()
            };
            return View(homeVM);


        }


        public IActionResult Error()
        {
            return View();
        }



    }
}

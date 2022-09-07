using EduhomeTask.DAL;
using EduhomeTask.Models;
using EduhomeTask.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduhomeTask.ViewComponents
{
    public class CoursesViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;

        public CoursesViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(int a)
        {
            List<Course> courses =  await _db.Courses.OrderByDescending(x => x.Id).Take(a).ToListAsync();
            return View(courses);

        }


    }
}


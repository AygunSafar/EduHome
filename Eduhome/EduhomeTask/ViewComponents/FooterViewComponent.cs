using EduhomeTask.DAL;
using EduhomeTask.Models;
using EduhomeTask.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace EduhomeTask.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;

        public FooterViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            FooterVM footervm = new FooterVM {

                Bio = await _db.Bios.FirstOrDefaultAsync(),
                SocialMedias = await _db.SocialMedias.ToListAsync()
            
            
            };
            return View(footervm);


        }

     
    }
}

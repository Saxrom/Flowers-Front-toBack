using System;
using Front_toBack_3.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Front_toBack_3.ViewComponents
{
    public class LogoViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public LogoViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var logos = await _dbContext.Logos.ToListAsync();

            return View(logos);
        }
    }
}


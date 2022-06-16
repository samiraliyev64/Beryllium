using backend.DAL;
using backend.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel home = new HomeViewModel
            {
                Sliders = _context.Sliders.ToList(),
                SliderSummary = _context.SliderSummary.FirstOrDefault(),
                WorkSummary = _context.WorkSummary.FirstOrDefault(),
                WorkSliders = _context.WorkSliders.ToList(),
                News = _context.News.ToList(),
                Testimonials = _context.Testimonials.ToList(),
                Summaries = _context.Summaries.ToList()
            };
            return View(home);
        }
    }
}

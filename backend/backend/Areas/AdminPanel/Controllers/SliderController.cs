using backend.DAL;
using backend.Helpers;
using backend.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class SliderController : Controller
    {
        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }
        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Sliders);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slide)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!slide.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo","file size must be less than 200 kb");
                return View();
            }
            if (!slide.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "file type must be image");
                return View();
            }
            slide.Url = await slide.Photo.SaveFileAsync(_env.WebRootPath,"images");
            await _context.Sliders.AddAsync(slide);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            var slider = _context.Sliders.Find(id);
            if(slider == null)
            {
                return NotFound();
            }
            var path = Helper.GetPath(_env.WebRootPath,"img",slider.Url);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? id)
        {
            if(id == null)
            {
                return BadRequest();
            }
            Slider slide = _context.Sliders.Find(id);
            if(slide == null)
            {
                return NotFound();
            }
            return View(slide);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Slider slide)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Slider slideDb = _context.Sliders.Find(id);
            if (slideDb == null)
            {
                return NotFound();
            }
            slide.Url = await slide.Photo.SaveFileAsync(_env.WebRootPath, "images");
            var pathDb = Helper.GetPath(_env.WebRootPath,"img",slide.Url);
            if (System.IO.File.Exists(pathDb))
            {
                System.IO.File.Delete(pathDb);
            }
            slideDb.Url = slide.Url;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}

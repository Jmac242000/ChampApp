using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ChampApp.Models;
using ChampApp.Data;
using Microsoft.EntityFrameworkCore;

namespace ChampApp.Controllers
{
    public class SlideController : Controller
    {
        private readonly IWebHostEnvironment _iwebhost;
        private readonly ChampContext _context;
        public SlideController(IWebHostEnvironment iwebhost, ChampContext context)
        {
            _context = context;
            _iwebhost = iwebhost;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.slides.ToListAsync());
        }
        public async Task<IActionResult> Create(Slide s)
        {
            string wwwRootPath = _iwebhost.WebRootPath;
            string namefile = Path.GetFileNameWithoutExtension(s.NameFile.FileName);
            string extension = Path.GetExtension(s.NameFile.FileName);
            s.foto = namefile = namefile + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/img/Slide/", namefile);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await s.NameFile.CopyToAsync(fileStream);
            }

            _context.slides.Add(s);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}

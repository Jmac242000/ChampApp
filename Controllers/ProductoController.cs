using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChampApp.Models;
using Microsoft.AspNetCore.Hosting;
using ChampApp.Data;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace ChampApp.Controllers
{
    public class ProductoController : Controller
    {
        private readonly IWebHostEnvironment _iwebhost;
        private readonly ChampContext _context;
        public ProductoController(IWebHostEnvironment iwebhost, ChampContext context)
        {
             _context = context;
            _iwebhost = iwebhost;
        }

        public async Task<IActionResult> Index() 
        {
            return View(await _context.productos.ToListAsync());
        } 
        public IActionResult comprar()
        {
            return View();
        }
          public IActionResult Detalle(int id)
        {
            return View(id);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Productos p)
        {
            string wwwRootPath = _iwebhost.WebRootPath;
            string namefile = Path.GetFileNameWithoutExtension(p.NameFile.FileName);
            string extension = Path.GetExtension(p.NameFile.FileName);
            p.foto = namefile = namefile + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/img/Producto/", namefile);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await p.NameFile.CopyToAsync(fileStream);
            }

            _context.productos.Add(p);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}

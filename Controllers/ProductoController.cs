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
        public async Task<IActionResult> Detalle(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productos = await _context.productos
                .FirstOrDefaultAsync(m => m.id == id);
            if (productos == null)
            {
                return NotFound();
            }

            return View(productos);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Lista()
        {
            return View(await _context.productos.ToListAsync());
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productos = await _context.productos.FindAsync(id);
            if (productos == null)
            {
                return NotFound();
            }
            return View(productos);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nombre,foto,stock,precio,descripcion")] Productos productos)
        {
            if (id != productos.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductosExists(productos.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(productos);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productos = await _context.productos
                .FirstOrDefaultAsync(m => m.id == id);
            if (productos == null)
            {
                return NotFound();
            }

            return View(productos);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productos = await _context.productos.FindAsync(id);
            _context.productos.Remove(productos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductosExists(int id)
        {
            return _context.productos.Any(e => e.id == id);
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

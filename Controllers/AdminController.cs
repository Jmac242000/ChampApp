using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Champ.Controllers
{
    public class AdminController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult pedidos()
        {
            return View();
        }
         public IActionResult crear()
        {
            return View();
        }
         public IActionResult editar()
        {
            return View();
        }
        public IActionResult Slider()
        {
            return View();
        }
        public IActionResult usuario()
        {
            return View();
        }
        public IActionResult reporte()
        {
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChampApp.Models;
using Microsoft.AspNetCore.Hosting;
using ChampApp.Data;

namespace ChampApp.Controllers
{
    public class ReporteController : Controller
    {
        private readonly IWebHostEnvironment _iwebhost;
        private readonly ChampContext _context;
        public ReporteController(IWebHostEnvironment iwebhost, ChampContext context)
        {
            _context = context;
            _iwebhost = iwebhost;
        }
        public IActionResult reporte()
        {
            return View();
        }
    
    }
}
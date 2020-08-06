using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChampApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace Shamp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Login(string returnUrl = "/")
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Create(Usuario user)
        {

            return RedirectToAction(nameof(Index));
        }
    }
}

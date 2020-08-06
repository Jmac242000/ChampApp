using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChampApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace ChampApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly ChampContext _context;

        public AccountController(ChampContext context){
            _context=context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Login(string returnUrl = "/")
        {
            return View();
        }
        [httpPost]
        public IActionResult Login(string correo, string clave)
        {

            var isvalidate=new LoginSevices();
            if(isvalidate.GetLogin(string correo,string clave)==true){
                return RedirectToAction("/Controllers/Home/Index")
            }
            return View();
        }
        public async Task<IActionResult> Register(Usuario user)
        {
            if(model.isvalid){
                _context.Usuario.add(user);
                _context.SaveAsync();
            }
            return View();
        }
        public IActionResult Create(Usuario user)
        {

            return RedirectToAction(nameof(Index));
        }
    }
}

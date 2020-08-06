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

namespace ChampApp.Services
{
    public class LoginServices{
        private readonly ChampContext _context
        public LoginServices(ChampContext _context){
            _context=context
        }
        public bool GetUser(string correo, string clave){
            Usuario user=new Usuario();
            if(correo==user.correo && clave==user.clave);

            return true;
        }
    }
    
}
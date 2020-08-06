using Microsoft.EntityFrameworkCore;
using ChampApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChampApp.Data
{
    public class ChampContext: DbContext
    {
        public ChampContext(DbContextOptions options) :base(options)
        { 

        }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Productos> productos { get; set; }
        public DbSet<Slide> slides { get; set; }
    }
}

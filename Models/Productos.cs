using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace ChampApp.Models
{
    public class Productos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string nombre { get; set; }
        public string foto { get; set; }
        public int stock { get; set; }
        public int precio { get; set; }
        public string descripcion { get; set; }

        [NotMapped]
        public IFormFile NameFile { get; set; }
    }
}
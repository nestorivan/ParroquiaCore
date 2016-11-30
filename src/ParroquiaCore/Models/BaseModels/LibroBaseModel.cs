using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParroquiaCore.Models.BaseModels
{
    public class LibroBaseModel
    {
        public int Id { get; set; }
        public string Libro { get; set; }
        public int Pagina { get; set; }
        public int Numero { get; set; }
    }
}

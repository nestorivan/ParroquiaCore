using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParroquiaCore.Models
{
    public class Matrimonio
    {
        public int Id { get; set; }
        public string Expediente { get; set; }
        public Persona Novio { get; set; }
        public Persona Novia { get; set; }
        public Persona Testigo1 { get; set; }
        public Persona Testigo2 { get; set; }
        public Persona Padrino { get; set; }
        public Persona Madrina { get; set; }
        public DateTime Fecha { get; set; }
        public Parroquia ParroquiaTramito { get; set; }
        public Parroquia Parroquia { get; set; }
    }
}

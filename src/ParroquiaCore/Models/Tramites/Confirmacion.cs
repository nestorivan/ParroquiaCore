using System;

namespace ParroquiaCore.Models
{
    public class Confirmacion
    {
        public int Id { get; set; } 
        public Persona Confirmado { get; set; }
        public Persona Padrino { get; set; }
        public Confirmacion Confirmacion { get; set; }
        public Parroquia ParroquiaAviso { get; set; }
        public DateTime Fecha { get; set; }
    }
}
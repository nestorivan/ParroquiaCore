using System;

namespace ParroquiaCore.Models
{
    public class Comunion
    {
        public int Id { get; set; }
        public string Acta { get; set; }
        public Persona Comulgado { get; set; }
        public CleroMiembro Celebrante { get; set; }
        public Bautismo Bautismo { get; set; }
        public DateTime Fecha { get; set; }
    }
}
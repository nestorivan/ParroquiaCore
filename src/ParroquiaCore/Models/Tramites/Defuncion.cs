using System;

namespace ParroquiaCore.Models
{
    public class Defuncion
    {
        public int Id { get; set; }

        public string CausaDefuncion { get; set; }
        public int Acta { get; set; }
        public Direccion LugarRecidencia { get; set; }
        public Direccion LugarSepulcro { get; set; }
        public DateTime FechaDefuncion { get; set; }
        public bool Confesion { get; set; }
        public bool Viatico { get; set; }
        public bool Uncion { get; set; }

        public Persona Padre { get; set; }
        public Persona Madre { get; set; }
        public Persona Viudo { get; set; }
        public Persona Difunto { get; set; }
    }
}
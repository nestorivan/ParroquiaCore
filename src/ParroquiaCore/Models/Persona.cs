using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParroquiaCore.Models
{
    public class Persona : PersonaBaseModel
    {
        public int Id { get; set; }

        public int PadreId { get; set; }
        public int MadreId { get; set; }
        public int AbueloPaternoId { get; set; }
        public int AbueloMaternoId { get; set; }
        public int AbuelaPaternaId { get; set; }
        public int AbuelaMaternaId { get; set; }

        [ForeignKey("Direccion")]
        public int DireccionNacimientoId { get; set; }
        
        public virtual Direccion DireccionNacimiento { get; set; }
    }
}

using Newtonsoft.Json;
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

        public Direccion DireccionNacimiento { get; set; }

        public Direccion DireccionActual { get; set; }
        
        public virtual Persona Padre { get; set; }

        public virtual Persona Madre { get; set; }

        public virtual Persona AbueloPaterno { get; set; }

        public virtual Persona AbueloMaterno { get; set; }

        public virtual Persona AbuelaPaterna { get; set; }

        public virtual Persona AbuelaMaterna { get; set; }
    }
}

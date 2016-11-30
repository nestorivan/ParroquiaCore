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

        public Persona Padre { get; set; }
        public Persona Madre { get; set; }

        [JsonIgnore]
        public Persona AbueloPaterno { get; set; }
        [JsonIgnore]
        public Persona AbueloMaterno { get; set; }
        [JsonIgnore]
        public Persona AbuelaPaterna { get; set; }
        [JsonIgnore]
        public Persona AbuelaMaterna { get; set; }
        
        public Direccion DireccionNacimiento { get; set; }
    }
}

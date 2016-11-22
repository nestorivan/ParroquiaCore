using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParroquiaCore.Models
{
    public class PersonaBaseModel
    {
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParroquiaCore.Models
{
    public class Colonia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Municipio Municipio { get; set; }
        public CodigoPostal CodigoPostal { get; set; }
    }
}

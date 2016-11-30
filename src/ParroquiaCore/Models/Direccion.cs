using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParroquiaCore.Models
{
    public class Direccion
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        public int NumeroExterior { get; set; }
        public string NumeroInterior { get; set; }

        public Colonia Colonia { get; set; }
        public Delegacion Delegacion { get; set; }
    }
}

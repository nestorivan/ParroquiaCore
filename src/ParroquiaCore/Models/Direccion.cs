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

        [ForeignKey("Colonia")]
        public int ColoniaId { get; set; }

        [ForeignKey("Delegacion")]
        public int? DelegacionId { get; set; }

        public virtual Colonia Colonia { get; set; }
        public virtual Delegacion Delegacion { get; set; }
    }
}

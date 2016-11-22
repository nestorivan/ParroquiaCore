using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParroquiaCore.Models
{
    public class Delegacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        [ForeignKey("Municipio")]
        public int MunicipioId { get; set; }

        public virtual Municipio Municipio { get; set; }
    }
}

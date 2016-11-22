using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParroquiaCore.Models
{
    public class Parroquia
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [ForeignKey("Diocesis")]
        public int DiocesisId { get; set; }

        [ForeignKey("Direccion")]
        public int DireccionId { get; set; }


        public virtual List<Sacerdote> Sacerdotes { get; set; }
        public virtual Direccion Direccion { get; set; }
    }
}

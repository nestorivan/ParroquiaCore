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

        public List<CleroMiembro> MiembrosClero { get; set; }

        public Direccion Direccion { get; set; }
    }
}

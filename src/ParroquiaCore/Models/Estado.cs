using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParroquiaCore.Models
{
    public class Estado
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Abreviacion { get; set; }

        public Pais Pais { get; set; }
    }
}

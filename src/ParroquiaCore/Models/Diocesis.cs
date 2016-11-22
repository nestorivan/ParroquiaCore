using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParroquiaCore.Models
{
    public class Diocesis
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("Archidiosesis")]
        public int ArchidiocesisId { get; set; }

        public virtual Archidiocesis Archidiocesis { get; set; }
    }
}

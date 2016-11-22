using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParroquiaCore.Models
{
    public class CleroMiembro : PersonaBaseModel
    {
        public int Id { get; set; }

        [ForeignKey("CleroTitulo")]
        public int CleroTituloId { get; set; }
        [ForeignKey("Parroquia")]
        public int ParroquiaId { get; set; }

        public virtual CleroTitulo CleroTitulo { get; set; }
        public virtual Parroquia Parroquia { get; set; }
    }
}

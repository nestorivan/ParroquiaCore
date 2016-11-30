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
        public CleroTitulo CleroTitulo { get; set; }
        public Parroquia Parroquia { get; set; }
    }
}

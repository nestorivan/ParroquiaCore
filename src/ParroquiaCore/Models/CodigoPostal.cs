using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParroquiaCore.Models
{
    public class CodigoPostal
    {
        public int Id { get; set; }

        [MaxLength(5)]
        public int Codigo { get; set; }
    }
}

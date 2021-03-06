﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParroquiaCore.Models
{
    public class Bautismo
    {
        public int Id { get; set; }
        public int RegistroCivilNumero { get; set; }
        public string RegistroCivilActa { get; set; }
        public int RegistroCivilLibro { get; set; }
        public string NotasUno { get; set; }
        public string NotasDos { get; set; }
        public bool Legitimo { get; set; }
        public CleroMiembro Parroco { get; set; }
        public Persona Bautizado { get; set; }
        public Persona Padrino { get; set; }
        public Persona Madrina { get; set; }
        public Parroquia Parroquia { get; set; }
        public DateTime Fecha { get; set; }
    }
}

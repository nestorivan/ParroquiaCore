﻿using ParroquiaCore.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParroquiaCore.Models
{
    public class LibroConfirmacion :LibroBaseModel
    {
        public List<Confirmacion> Confirmaciones { get; set; }
    }
}

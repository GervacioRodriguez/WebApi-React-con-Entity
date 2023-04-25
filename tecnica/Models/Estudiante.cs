﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace tecnica.Models
{
    public partial class Estudiante
    {
        public int Id { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Nombres { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
    }
}

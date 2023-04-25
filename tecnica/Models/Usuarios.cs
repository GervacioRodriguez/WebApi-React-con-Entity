using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace tecnica.Models
{
    public partial class Usuarios
    {
        public int Idusuario { get; set; }
        public string DocumentoIdentidad { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Ciudad { get; set; }
        public DateTime? FNacimiento { get; set; }
    }
}

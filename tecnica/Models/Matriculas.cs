using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace tecnica.Models
{
    public partial class Matriculas
    {
        public int Id { get; set; }
        public int? IdEstudiante { get; set; }
        public int? IdClase { get; set; }
    }
}

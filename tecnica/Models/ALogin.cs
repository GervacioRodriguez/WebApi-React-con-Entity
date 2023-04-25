using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace tecnica.Models
{
    public partial class ALogin
    {
        public int Id { get; set; }
        public int? IdUsuario { get; set; }
        public string Contra { get; set; }
        public string Email { get; set; }
    }
}

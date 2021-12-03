using System;
using System.Collections.Generic;

#nullable disable

namespace Movil_Api_Paciente.Models
{
    public partial class UsuarioDoctor
    {
        public int? IdDoctor { get; set; }
        public string Nombre { get; set; }
        public string Contra { get; set; }
    }
}

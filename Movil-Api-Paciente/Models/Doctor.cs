using System;
using System.Collections.Generic;

#nullable disable

namespace Movil_Api_Paciente.Models
{
    public partial class Doctor
    {
        public int IdDoctor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Especialidad { get; set; }
        public string Contra { get; set; }
        public int? Activo { get; set; }
    }
}

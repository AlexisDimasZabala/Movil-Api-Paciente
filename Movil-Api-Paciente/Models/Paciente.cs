using System;
using System.Collections.Generic;

#nullable disable

namespace Movil_Api_Paciente.Models
{
    public partial class Paciente
    {
        public int IdPaciente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int? Edad { get; set; }
        public string GrupoSanguineo { get; set; }
        public string Riesgo { get; set; }
        public string VacCovid { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Foto { get; set; }
        public string Rating { get; set; }
        public string Domicilio { get; set; }
        public string Alcohol { get; set; }
        public string Tabaco { get; set; }
        public string Drogas { get; set; }
        public string Infusiones { get; set; }
        public string Respiratorio { get; set; }
        public string Neurologico { get; set; }
        public string Quirurgico { get; set; }
        public string Alergias { get; set; }
        public int? Activo { get; set; }
        public string Documento { get; set; }
    }
}

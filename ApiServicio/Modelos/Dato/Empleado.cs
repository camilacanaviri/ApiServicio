using System;
using System.Collections.Generic;

namespace ApiServicio.Modelos.Dato
{
    public partial class Empleado
    {
        public decimal IdEmpleado { get; set; }
        public int? Usuario { get; set; }
        public string NombreEmpleado { get; set; }
        public string Cargo { get; set; }
        public string Disponible { get; set; }
    }
}

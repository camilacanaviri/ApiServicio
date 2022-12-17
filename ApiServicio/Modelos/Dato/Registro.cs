using System;
using System.Collections.Generic;

namespace ApiServicio.Modelos.Dato
{
    public partial class Registro
    {
        public decimal IdRegistro { get; set; }
        public string IdCliente { get; set; }
        public string IngresoDeNombre { get; set; }
        public string IngresoDeApellido { get; set; }
        public int? Contraseña { get; set; }
    }
}

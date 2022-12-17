using System;
using System.Collections.Generic;

namespace ApiServicio.Modelos.Dato
{
    public partial class Servicio
    {
        public decimal IdServicio { get; set; }
        public string Items { get; set; }
        public string Seccion { get; set; }
        public string Descripcion { get; set; }
        public int? Precio { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiServicio.Modelos.Dato
{
    public partial class FichajeCitum
    {
        public decimal IdFichaje { get; set; }
        public string Cliente { get; set; }
        public string Placa { get; set; }
        public int? CambioKms { get; set; }
        public DateTime? ProximaFecha { get; set; }
    }
}

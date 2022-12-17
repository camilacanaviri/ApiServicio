using System;
using System.Collections.Generic;

namespace ApiServicio.Modelos.Dato
{
    public partial class Vehiculo
    {
        public decimal IdVehiculo { get; set; }
        public string Placa { get; set; }
        public string Cliente { get; set; }
        public string ModeloAuto { get; set; }
        public string Marca { get; set; }
        public string ColorAuto { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiServicio.Modelos.Dato
{
    public partial class Compra
    {
        public decimal IdCompra { get; set; }
        public string IdCliente { get; set; }
        public string IdPlaca { get; set; }
        public string IdServicio { get; set; }
        public int? Cantidad { get; set; }
        public double? PrecioTotal { get; set; }
    }
}

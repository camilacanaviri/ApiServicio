using System;
using System.Collections.Generic;

namespace ApiServicio.Modelos.Dato
{
    public partial class Cliente
    {
        public decimal IdCliente { get; set; }
        public int? Usuario { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string DireccionCliente { get; set; }
        public int? TelefonoCliente { get; set; }
        public string Institución { get; set; }
    }
}

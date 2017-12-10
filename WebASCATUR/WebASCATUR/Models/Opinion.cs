using System;
using System.Collections.Generic;

namespace WebASCATUR.Models
{
    public partial class Opinion
    {
        public int Id { get; set; }
        public int IdComercio { get; set; }
        public string Detalle { get; set; }
        public string NombreUsuario { get; set; }
        public DateTime? FechaIngreso { get; set; }

        public Comercio IdComercioNavigation { get; set; }
    }
}

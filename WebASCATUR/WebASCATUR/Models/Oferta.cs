using System;
using System.Collections.Generic;

namespace WebASCATUR.Models
{
    public partial class Oferta
    {
        public int Id { get; set; }
        public int IdComercio { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Cantidad { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string ImagenPrimaria { get; set; }
        public string GaleriaImagenes { get; set; }
        public string DetalleIngles { get; set; }
        public decimal? PrecioIngles { get; set; }

        public Comercio IdComercioNavigation { get; set; }
    }
}

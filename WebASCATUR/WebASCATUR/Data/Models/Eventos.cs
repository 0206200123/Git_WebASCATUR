using System;
using System.Collections.Generic;

namespace WebASCATUR.Data.Models
{
    public partial class Eventos
    {
        public int Id { get; set; }
        public int IdComercio { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public DateTime FechaRealizar { get; set; }
        public TimeSpan Hora { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string ImagenPrimaria { get; set; }
        public string GaleriaImagenes { get; set; }
        public string DetalleIngles { get; set; }

        public Comercio IdComercioNavigation { get; set; }
    }
}

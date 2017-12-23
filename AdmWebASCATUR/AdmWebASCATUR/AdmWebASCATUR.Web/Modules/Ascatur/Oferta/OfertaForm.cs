
namespace AdmWebASCATUR.Ascatur.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Ascatur.Oferta")]
    [BasedOnRow(typeof(Entities.OfertaRow))]
    public class OfertaForm
    {
        //public Int32 IdComercio { get; set; }
        public String Nombre { get; set; }
        public String Detalle { get; set; }
        public Decimal Precio { get; set; }
        public Decimal Cantidad { get; set; }
        public DateTime FechaIngreso { get; set; }
        public String ImagenPrimaria { get; set; }
        public String GaleriaImagenes { get; set; }
        public String DetalleIngles { get; set; }
        public Decimal PrecioIngles { get; set; }
    }
}
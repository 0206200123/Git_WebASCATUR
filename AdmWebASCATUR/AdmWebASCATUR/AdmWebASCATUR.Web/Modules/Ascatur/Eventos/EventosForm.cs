
namespace AdmWebASCATUR.Ascatur.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Ascatur.Eventos")]
    [BasedOnRow(typeof(Entities.EventosRow))]
    public class EventosForm
    {
        //public Int32 IdComercio { get; set; }
        public String Nombre { get; set; }
        public String Detalle { get; set; }
        public DateTime FechaRealizar { get; set; }
        public TimeSpan Hora { get; set; }
        public DateTime FechaIngreso { get; set; }
        public String ImagenPrimaria { get; set; }
        public String GaleriaImagenes { get; set; }
        public String DetalleIngles { get; set; }
    }
}

namespace AdmWebASCATUR.Ascatur.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Ascatur.Opinion")]
    [BasedOnRow(typeof(Entities.OpinionRow))]
    public class OpinionForm
    {
        public String Detalle { get; set; }
        public String NombreUsuario { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
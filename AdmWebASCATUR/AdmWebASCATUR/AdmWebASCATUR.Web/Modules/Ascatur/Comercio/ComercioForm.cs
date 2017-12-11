
namespace AdmWebASCATUR.Ascatur.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Ascatur.Comercio")]
    [BasedOnRow(typeof(Entities.ComercioRow))]
    public class ComercioForm
    {
        public Int32 NumAfiliacion { get; set; }
        public String Nombre { get; set; }
        public String Cedula { get; set; }
        public Int32 CantidadEmpleados { get; set; }
        public String Canton { get; set; }
        public String Distrito { get; set; }
        public String Localidad { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Mail { get; set; }
        public String NombreRepresentante { get; set; }
        public String IdentificacionRepresentante { get; set; }
        public String EstadoCivil { get; set; }
        public String TelefonoRepresentante { get; set; }
        public String MailRepresentante { get; set; }
        public String Ocupacion { get; set; }
        public String DireccionRepresentante { get; set; }
        public String ImagenPrimaria { get; set; }
        public String GaleriaImagenes { get; set; }
        public DateTime FechaIngreso { get; set; }
        [TextAreaEditor(Rows = 6)]
        public String Descripcion { get; set; }
        [TextAreaEditor(Rows = 6)]
        public String DescripcionIngles { get; set; }
    }
}
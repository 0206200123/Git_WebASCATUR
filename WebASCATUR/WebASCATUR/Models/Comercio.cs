using System;
using System.Collections.Generic;

namespace WebASCATUR.Models
{
    public partial class Comercio
    {
        public Comercio()
        {
            Eventos = new HashSet<Eventos>();
            Oferta = new HashSet<Oferta>();
            Opinion = new HashSet<Opinion>();
            Producto = new HashSet<Producto>();
            Servicio = new HashSet<Servicio>();
        }

        public int Id { get; set; }
        public int NumAfiliacion { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public int CantidadEmpleados { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public string Localidad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public string NombreRepresentante { get; set; }
        public string IdentificacionRepresentante { get; set; }
        public string EstadoCivil { get; set; }
        public string TelefonoRepresentante { get; set; }
        public string MailRepresentante { get; set; }
        public string Ocupacion { get; set; }
        public string DireccionRepresentante { get; set; }
        public string ImagenPrimaria { get; set; }
        public string GaleriaImagenes { get; set; }
        public DateTime? FechaIngreso { get; set; }

        public ICollection<Eventos> Eventos { get; set; }
        public ICollection<Oferta> Oferta { get; set; }
        public ICollection<Opinion> Opinion { get; set; }
        public ICollection<Producto> Producto { get; set; }
        public ICollection<Servicio> Servicio { get; set; }
    }
}

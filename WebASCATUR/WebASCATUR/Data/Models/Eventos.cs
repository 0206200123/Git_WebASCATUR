using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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

        [NotMapped]
        public List<FileImage> Imagenes
        {
            get
            {
                if (string.IsNullOrEmpty(GaleriaImagenes))
                {
                    return new List<FileImage>();

                }
                return JsonConvert.DeserializeObject<List<FileImage>>(GaleriaImagenes);
            }
        }

        public string DetalleIngles { get; set; }

        public Comercio IdComercioNavigation { get; set; }
    }
}

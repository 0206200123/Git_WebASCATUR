
namespace AdmWebASCATUR.Ascatur.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Ascatur.Producto")]
    [BasedOnRow(typeof(Entities.ProductoRow))]
    public class ProductoColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        
        [EditLink]
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

namespace AdmWebASCATUR.Ascatur.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Ascatur.Opinion")]
    [BasedOnRow(typeof(Entities.OpinionRow))]
    public class OpinionColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [EditLink]
        public String Detalle { get; set; }
        public String NombreUsuario { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
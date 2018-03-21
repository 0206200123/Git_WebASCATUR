
namespace AdmWebASCATUR.Ascatur.Entities
{
    using AdmWebASCATUR.Web.Modules.Ascatur.Comercio;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("ASCATUR"), TableName("[dbo].[Eventos]")]
    [DisplayName("Eventos"), InstanceName("Eventos"), TwoLevelCached]
    [ReadPermission("PermissionKeys:Comercio")]
    [ModifyPermission("PermissionKeys:Comercio")]
    [LookupScript("Ascatur:Eventos")]
    public sealed class EventosRow : Row, IIdRow, INameRow, IMultiComercioRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [Insertable(false), Updatable(false)]
        public Int32? Id_Comercio
        {
            get { return Fields.Id_Comercio[this]; }
            set { Fields.Id_Comercio[this] = value; }
        }

        [DisplayName("Nombre"), Size(50), NotNull, QuickSearch]
        public String Nombre
        {
            get { return Fields.Nombre[this]; }
            set { Fields.Nombre[this] = value; }
        }

        [DisplayName("Detalle"), Size(200), NotNull]
        public String Detalle
        {
            get { return Fields.Detalle[this]; }
            set { Fields.Detalle[this] = value; }
        }

        [DisplayName("Fecha Realizar"), Column("Fecha_realizar"), NotNull]
        public DateTime? FechaRealizar
        {
            get { return Fields.FechaRealizar[this]; }
            set { Fields.FechaRealizar[this] = value; }
        }

        [DisplayName("Hora"), NotNull]
        public TimeSpan? Hora
        {
            get { return Fields.Hora[this]; }
            set { Fields.Hora[this] = value; }
        }

        [DisplayName("Fecha Ingreso"), Column("Fecha_Ingreso")]
        public DateTime? FechaIngreso
        {
            get { return Fields.FechaIngreso[this]; }
            set { Fields.FechaIngreso[this] = value; }
        }

        [DisplayName("Imagen Primaria"), Column("Imagen_Primaria"), Size(100), ImageUploadEditor(FilenameFormat = "Eventos/ImagenPrimaria/~")]
        public String ImagenPrimaria
        {
            get { return Fields.ImagenPrimaria[this]; }
            set { Fields.ImagenPrimaria[this] = value; }
        }

        [DisplayName("Galería Imagenes"), Column("Galeria_Imagenes"), Size(100), MultipleImageUploadEditor(FilenameFormat = "Eventos/GaleriaImagenes/~")]
        public String GaleriaImagenes
        {
            get { return Fields.GaleriaImagenes[this]; }
            set { Fields.GaleriaImagenes[this] = value; }
        }

        [DisplayName("Detalle Ingles"), Column("Detalle_Ingles"), Size(200)]
        public String DetalleIngles
        {
            get { return Fields.DetalleIngles[this]; }
            set { Fields.DetalleIngles[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Nombre; }
        }

        public Int32Field IdComercioField
        {
            get { return Fields.Id_Comercio; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public EventosRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field Id_Comercio;
            public StringField Nombre;
            public StringField Detalle;
            public DateTimeField FechaRealizar;
            public TimeSpanField Hora;
            public DateTimeField FechaIngreso;
            public StringField ImagenPrimaria;
            public StringField GaleriaImagenes;
            public StringField DetalleIngles;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Ascatur.Eventos";
            }
        }
    }
}

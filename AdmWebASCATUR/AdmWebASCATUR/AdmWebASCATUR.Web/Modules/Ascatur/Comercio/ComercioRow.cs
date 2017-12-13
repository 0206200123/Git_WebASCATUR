
namespace AdmWebASCATUR.Ascatur.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("ASCATUR"), TableName("[dbo].[Comercio]")]
    [DisplayName("Comercio"), InstanceName("Comercio"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ComercioRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("# Afiliación"), Column("Num_Afiliacion"), NotNull]
        public Int32? NumAfiliacion
        {
            get { return Fields.NumAfiliacion[this]; }
            set { Fields.NumAfiliacion[this] = value; }
        }

        [DisplayName("Nombre"), Size(50), NotNull, QuickSearch]
        public String Nombre
        {
            get { return Fields.Nombre[this]; }
            set { Fields.Nombre[this] = value; }
        }

        [DisplayName("Cédula"), Size(50), NotNull]
        public String Cedula
        {
            get { return Fields.Cedula[this]; }
            set { Fields.Cedula[this] = value; }
        }

        [DisplayName("Cantidad Empleados"), Column("Cantidad_Empleados"), NotNull]
        public Int32? CantidadEmpleados
        {
            get { return Fields.CantidadEmpleados[this]; }
            set { Fields.CantidadEmpleados[this] = value; }
        }

        [DisplayName("Cantón"), Size(50)]
        public String Canton
        {
            get { return Fields.Canton[this]; }
            set { Fields.Canton[this] = value; }
        }

        [DisplayName("Distrito"), Size(50)]
        public String Distrito
        {
            get { return Fields.Distrito[this]; }
            set { Fields.Distrito[this] = value; }
        }

        [DisplayName("Localidad"), Size(50)]
        public String Localidad
        {
            get { return Fields.Localidad[this]; }
            set { Fields.Localidad[this] = value; }
        }

        [DisplayName("Dirección")]
        public String Direccion
        {
            get { return Fields.Direccion[this]; }
            set { Fields.Direccion[this] = value; }
        }

        [DisplayName("Teléfono"), Size(50)]
        public String Telefono
        {
            get { return Fields.Telefono[this]; }
            set { Fields.Telefono[this] = value; }
        }

        [DisplayName("Correo"), Size(50)]
        public String Mail
        {
            get { return Fields.Mail[this]; }
            set { Fields.Mail[this] = value; }
        }

        [DisplayName("Nombre Representante"), Column("Nombre_Representante"), Size(50), NotNull]
        public String NombreRepresentante
        {
            get { return Fields.NombreRepresentante[this]; }
            set { Fields.NombreRepresentante[this] = value; }
        }

        [DisplayName("Identificación Representante"), Column("Identificacion_Representante"), Size(50), NotNull]
        public String IdentificacionRepresentante
        {
            get { return Fields.IdentificacionRepresentante[this]; }
            set { Fields.IdentificacionRepresentante[this] = value; }
        }

        [DisplayName("Estado Civil"), Column("Estado_Civil"), Size(50)]
        public String EstadoCivil
        {
            get { return Fields.EstadoCivil[this]; }
            set { Fields.EstadoCivil[this] = value; }
        }

        [DisplayName("Teléfono Representante"), Column("Telefono_Representante"), Size(50)]
        public String TelefonoRepresentante
        {
            get { return Fields.TelefonoRepresentante[this]; }
            set { Fields.TelefonoRepresentante[this] = value; }
        }

        [DisplayName("Correo Representante"), Column("Mail_Representante"), Size(50)]
        public String MailRepresentante
        {
            get { return Fields.MailRepresentante[this]; }
            set { Fields.MailRepresentante[this] = value; }
        }

        [DisplayName("Ocupación"), Size(50)]
        public String Ocupacion
        {
            get { return Fields.Ocupacion[this]; }
            set { Fields.Ocupacion[this] = value; }
        }

        [DisplayName("Dirección Representante"), Column("Direccion_Representante"), Size(400)]
        public String DireccionRepresentante
        {
            get { return Fields.DireccionRepresentante[this]; }
            set { Fields.DireccionRepresentante[this] = value; }
        }

        [DisplayName("Imagen Primaria"), Column("Imagen_Primaria"), Size(100),
            ImageUploadEditor(FilenameFormat = "Comercio/ImagenPrimaria/~")]
        public String ImagenPrimaria
        {
            get { return Fields.ImagenPrimaria[this]; }
            set { Fields.ImagenPrimaria[this] = value; }
        }

        [DisplayName("Galería Imagenes"), Column("Galeria_Imagenes"),
            MultipleImageUploadEditor(FilenameFormat = "Comercio/GaleriaImagenes/~")]
        public String GaleriaImagenes
        {
            get { return Fields.GaleriaImagenes[this]; }
            set { Fields.GaleriaImagenes[this] = value; }
        }

        [DisplayName("Fecha Ingreso"), Column("Fecha_ingreso")]
        public DateTime? FechaIngreso
        {
            get { return Fields.FechaIngreso[this]; }
            set { Fields.FechaIngreso[this] = value; }
        }

        [DisplayName("Descripción")]
        public String Descripcion
        {
            get { return Fields.Descripcion[this]; }
            set { Fields.Descripcion[this] = value; }
        }

        [DisplayName("Descripción en Ingles"), Column("Descripcion_Ingles")]
        public String DescripcionIngles
        {
            get { return Fields.DescripcionIngles[this]; }
            set { Fields.DescripcionIngles[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Nombre; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ComercioRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field NumAfiliacion;
            public StringField Nombre;
            public StringField Cedula;
            public Int32Field CantidadEmpleados;
            public StringField Canton;
            public StringField Distrito;
            public StringField Localidad;
            public StringField Direccion;
            public StringField Telefono;
            public StringField Mail;
            public StringField NombreRepresentante;
            public StringField IdentificacionRepresentante;
            public StringField EstadoCivil;
            public StringField TelefonoRepresentante;
            public StringField MailRepresentante;
            public StringField Ocupacion;
            public StringField DireccionRepresentante;
            public StringField ImagenPrimaria;
            public StringField GaleriaImagenes;
            public DateTimeField FechaIngreso;
            public StringField Descripcion;
            public StringField DescripcionIngles;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Ascatur.Comercio";
            }
        }
    }
}

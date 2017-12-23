
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

    [ConnectionKey("ASCATUR"), TableName("[dbo].[Opinion]")]
    [DisplayName("Opinion"), InstanceName("Opinion"), TwoLevelCached]
    [ReadPermission("PermissionKeys:Comercio")]
    [ModifyPermission("PermissionKeys:Comercio")]
    [LookupScript("Ascatur:Opinion")]
    public sealed class OpinionRow : Row, IIdRow, INameRow, IMultiComercioRow
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

        [DisplayName("Detalle"), Size(200), NotNull, QuickSearch]
        public String Detalle
        {
            get { return Fields.Detalle[this]; }
            set { Fields.Detalle[this] = value; }
        }

        [DisplayName("Nombre Usuario"), Column("Nombre_Usuario"), Size(50)]
        public String NombreUsuario
        {
            get { return Fields.NombreUsuario[this]; }
            set { Fields.NombreUsuario[this] = value; }
        }

        [DisplayName("Fecha Ingreso"), Column("Fecha_Ingreso")]
        public DateTime? FechaIngreso
        {
            get { return Fields.FechaIngreso[this]; }
            set { Fields.FechaIngreso[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Detalle; }
        }


        public Int32Field IdComercioField
        {
            get { return Fields.Id_Comercio; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public OpinionRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field Id_Comercio;
            public StringField Detalle;
            public StringField NombreUsuario;
            public DateTimeField FechaIngreso;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Ascatur.Opinion";
            }
        }
    }
}

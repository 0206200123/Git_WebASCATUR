namespace AdmWebASCATUR.Ascatur {
    export class ComercioForm extends Serenity.PrefixedContext {
        static formKey = 'Ascatur.Comercio';

    }

    export interface ComercioForm {
        NumAfiliacion: Serenity.IntegerEditor;
        Nombre: Serenity.StringEditor;
        Cedula: Serenity.StringEditor;
        CantidadEmpleados: Serenity.IntegerEditor;
        Canton: Serenity.StringEditor;
        Distrito: Serenity.StringEditor;
        Localidad: Serenity.StringEditor;
        Direccion: Serenity.StringEditor;
        Telefono: Serenity.StringEditor;
        Mail: Serenity.StringEditor;
        NombreRepresentante: Serenity.StringEditor;
        IdentificacionRepresentante: Serenity.StringEditor;
        EstadoCivil: Serenity.StringEditor;
        TelefonoRepresentante: Serenity.StringEditor;
        MailRepresentante: Serenity.StringEditor;
        Ocupacion: Serenity.StringEditor;
        DireccionRepresentante: Serenity.StringEditor;
        ImagenPrimaria: Serenity.StringEditor;
        GaleriaImagenes: Serenity.StringEditor;
        FechaIngreso: Serenity.DateEditor;
        Descripcion: Serenity.TextAreaEditor;
        DescripcionIngles: Serenity.TextAreaEditor;
    }

    [['NumAfiliacion', () => Serenity.IntegerEditor], ['Nombre', () => Serenity.StringEditor], ['Cedula', () => Serenity.StringEditor], ['CantidadEmpleados', () => Serenity.IntegerEditor], ['Canton', () => Serenity.StringEditor], ['Distrito', () => Serenity.StringEditor], ['Localidad', () => Serenity.StringEditor], ['Direccion', () => Serenity.StringEditor], ['Telefono', () => Serenity.StringEditor], ['Mail', () => Serenity.StringEditor], ['NombreRepresentante', () => Serenity.StringEditor], ['IdentificacionRepresentante', () => Serenity.StringEditor], ['EstadoCivil', () => Serenity.StringEditor], ['TelefonoRepresentante', () => Serenity.StringEditor], ['MailRepresentante', () => Serenity.StringEditor], ['Ocupacion', () => Serenity.StringEditor], ['DireccionRepresentante', () => Serenity.StringEditor], ['ImagenPrimaria', () => Serenity.StringEditor], ['GaleriaImagenes', () => Serenity.StringEditor], ['FechaIngreso', () => Serenity.DateEditor], ['Descripcion', () => Serenity.TextAreaEditor], ['DescripcionIngles', () => Serenity.TextAreaEditor]].forEach(x => Object.defineProperty(ComercioForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

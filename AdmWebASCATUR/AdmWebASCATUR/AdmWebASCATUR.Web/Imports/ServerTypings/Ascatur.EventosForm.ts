
namespace AdmWebASCATUR.Ascatur {
    export class EventosForm extends Serenity.PrefixedContext {
        static formKey = 'Ascatur.Eventos';
    }

    export interface EventosForm {
        IdComercio: Serenity.IntegerEditor;
        Nombre: Serenity.StringEditor;
        Detalle: Serenity.StringEditor;
        FechaRealizar: Serenity.DateEditor;
        Hora: Serenity.StringEditor;
        FechaIngreso: Serenity.DateEditor;
        ImagenPrimaria: Serenity.StringEditor;
        GaleriaImagenes: Serenity.StringEditor;
        DetalleIngles: Serenity.StringEditor;
    }

    [,
        ['IdComercio', () => Serenity.IntegerEditor],
        ['Nombre', () => Serenity.StringEditor],
        ['Detalle', () => Serenity.StringEditor],
        ['FechaRealizar', () => Serenity.DateEditor],
        ['Hora', () => Serenity.StringEditor],
        ['FechaIngreso', () => Serenity.DateEditor],
        ['ImagenPrimaria', () => Serenity.StringEditor],
        ['GaleriaImagenes', () => Serenity.StringEditor],
        ['DetalleIngles', () => Serenity.StringEditor]
    ].forEach(x => Object.defineProperty(EventosForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}
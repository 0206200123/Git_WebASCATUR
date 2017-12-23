
namespace AdmWebASCATUR.Ascatur {
    export class OpinionForm extends Serenity.PrefixedContext {
        static formKey = 'Ascatur.Opinion';
    }

    export interface OpinionForm {
        IdComercio: Serenity.IntegerEditor;
        Detalle: Serenity.StringEditor;
        NombreUsuario: Serenity.StringEditor;
        FechaIngreso: Serenity.DateEditor;
    }

    [,
        ['IdComercio', () => Serenity.IntegerEditor],
        ['Detalle', () => Serenity.StringEditor],
        ['NombreUsuario', () => Serenity.StringEditor],
        ['FechaIngreso', () => Serenity.DateEditor]
    ].forEach(x => Object.defineProperty(OpinionForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}
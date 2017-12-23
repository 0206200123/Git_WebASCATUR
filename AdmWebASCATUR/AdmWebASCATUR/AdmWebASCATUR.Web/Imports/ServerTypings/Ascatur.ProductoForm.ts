
namespace AdmWebASCATUR.Ascatur {
    export class ProductoForm extends Serenity.PrefixedContext {
        static formKey = 'Ascatur.Producto';
    }

    export interface ProductoForm {
        IdComercio: Serenity.IntegerEditor;
        Nombre: Serenity.StringEditor;
        Detalle: Serenity.StringEditor;
        Precio: Serenity.DecimalEditor;
        Cantidad: Serenity.DecimalEditor;
        FechaIngreso: Serenity.DateEditor;
        ImagenPrimaria: Serenity.StringEditor;
        GaleriaImagenes: Serenity.StringEditor;
        DetalleIngles: Serenity.StringEditor;
        PrecioIngles: Serenity.DecimalEditor;
    }

    [,
        ['IdComercio', () => Serenity.IntegerEditor],
        ['Nombre', () => Serenity.StringEditor],
        ['Detalle', () => Serenity.StringEditor],
        ['Precio', () => Serenity.DecimalEditor],
        ['Cantidad', () => Serenity.DecimalEditor],
        ['FechaIngreso', () => Serenity.DateEditor],
        ['ImagenPrimaria', () => Serenity.StringEditor],
        ['GaleriaImagenes', () => Serenity.StringEditor],
        ['DetalleIngles', () => Serenity.StringEditor],
        ['PrecioIngles', () => Serenity.DecimalEditor]
    ].forEach(x => Object.defineProperty(ProductoForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}
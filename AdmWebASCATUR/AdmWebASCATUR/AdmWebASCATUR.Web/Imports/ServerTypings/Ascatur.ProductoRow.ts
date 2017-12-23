
namespace AdmWebASCATUR.Ascatur {
    export interface ProductoRow {
        Id?: number;
        IdComercio?: number;
        Nombre?: string;
        Detalle?: string;
        Precio?: number;
        Cantidad?: number;
        FechaIngreso?: string;
        ImagenPrimaria?: string;
        GaleriaImagenes?: string;
        DetalleIngles?: string;
        PrecioIngles?: number;
    }

    export namespace ProductoRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Nombre';
        export const localTextPrefix = 'Ascatur.Producto';

        export namespace Fields {
            export declare const Id;
            export declare const IdComercio;
            export declare const Nombre;
            export declare const Detalle;
            export declare const Precio;
            export declare const Cantidad;
            export declare const FechaIngreso;
            export declare const ImagenPrimaria;
            export declare const GaleriaImagenes;
            export declare const DetalleIngles;
            export declare const PrecioIngles;
        }

        [
            'Id',
            'IdComercio',
            'Nombre',
            'Detalle',
            'Precio',
            'Cantidad',
            'FechaIngreso',
            'ImagenPrimaria',
            'GaleriaImagenes',
            'DetalleIngles',
            'PrecioIngles'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}
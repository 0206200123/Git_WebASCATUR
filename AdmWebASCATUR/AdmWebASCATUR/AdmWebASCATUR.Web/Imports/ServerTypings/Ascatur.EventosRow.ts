
namespace AdmWebASCATUR.Ascatur {
    export interface EventosRow {
        Id?: number;
        IdComercio?: number;
        Nombre?: string;
        Detalle?: string;
        FechaRealizar?: string;
        Hora?: string;
        FechaIngreso?: string;
        ImagenPrimaria?: string;
        GaleriaImagenes?: string;
        DetalleIngles?: string;
    }

    export namespace EventosRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Nombre';
        export const localTextPrefix = 'Ascatur.Eventos';

        export namespace Fields {
            export declare const Id;
            export declare const IdComercio;
            export declare const Nombre;
            export declare const Detalle;
            export declare const FechaRealizar;
            export declare const Hora;
            export declare const FechaIngreso;
            export declare const ImagenPrimaria;
            export declare const GaleriaImagenes;
            export declare const DetalleIngles;
        }

        [
            'Id',
            'IdComercio',
            'Nombre',
            'Detalle',
            'FechaRealizar',
            'Hora',
            'FechaIngreso',
            'ImagenPrimaria',
            'GaleriaImagenes',
            'DetalleIngles'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}
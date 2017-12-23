
namespace AdmWebASCATUR.Ascatur {
    export interface OpinionRow {
        Id?: number;
        IdComercio?: number;
        Detalle?: string;
        NombreUsuario?: string;
        FechaIngreso?: string;
    }

    export namespace OpinionRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Detalle';
        export const localTextPrefix = 'Ascatur.Opinion';

        export namespace Fields {
            export declare const Id;
            export declare const IdComercio;
            export declare const Detalle;
            export declare const NombreUsuario;
            export declare const FechaIngreso;
        }

        [
            'Id',
            'IdComercio',
            'Detalle',
            'NombreUsuario',
            'FechaIngreso'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}
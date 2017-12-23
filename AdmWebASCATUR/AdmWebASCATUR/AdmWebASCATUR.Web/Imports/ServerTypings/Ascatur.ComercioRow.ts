namespace AdmWebASCATUR.Ascatur {
    export interface ComercioRow {
        Id?: number;
        NumAfiliacion?: number;
        Nombre?: string;
        Cedula?: string;
        CantidadEmpleados?: number;
        Canton?: string;
        Distrito?: string;
        Localidad?: string;
        Direccion?: string;
        Telefono?: string;
        Mail?: string;
        NombreRepresentante?: string;
        IdentificacionRepresentante?: string;
        EstadoCivil?: string;
        TelefonoRepresentante?: string;
        MailRepresentante?: string;
        Ocupacion?: string;
        DireccionRepresentante?: string;
        ImagenPrimaria?: string;
        GaleriaImagenes?: string;
        FechaIngreso?: string;
        Descripcion?: string;
        DescripcionIngles?: string;
    }

    export namespace ComercioRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Nombre';
        export const localTextPrefix = 'Ascatur.Comercio';

        export namespace Fields {
            export declare const Id: string;
            export declare const NumAfiliacion: string;
            export declare const Nombre: string;
            export declare const Cedula: string;
            export declare const CantidadEmpleados: string;
            export declare const Canton: string;
            export declare const Distrito: string;
            export declare const Localidad: string;
            export declare const Direccion: string;
            export declare const Telefono: string;
            export declare const Mail: string;
            export declare const NombreRepresentante: string;
            export declare const IdentificacionRepresentante: string;
            export declare const EstadoCivil: string;
            export declare const TelefonoRepresentante: string;
            export declare const MailRepresentante: string;
            export declare const Ocupacion: string;
            export declare const DireccionRepresentante: string;
            export declare const ImagenPrimaria: string;
            export declare const GaleriaImagenes: string;
            export declare const FechaIngreso: string;
            export declare const Descripcion: string;
            export declare const DescripcionIngles: string;
        }

        [
            'Id', 
            'NumAfiliacion', 
            'Nombre', 
            'Cedula', 
            'CantidadEmpleados', 
            'Canton', 
            'Distrito', 
            'Localidad', 
            'Direccion', 
            'Telefono', 
            'Mail', 
            'NombreRepresentante', 
            'IdentificacionRepresentante', 
            'EstadoCivil', 
            'TelefonoRepresentante', 
            'MailRepresentante', 
            'Ocupacion', 
            'DireccionRepresentante', 
            'ImagenPrimaria', 
            'GaleriaImagenes', 
            'FechaIngreso', 
            'Descripcion', 
            'DescripcionIngles'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

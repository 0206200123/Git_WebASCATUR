
namespace AdmWebASCATUR.Ascatur {

    @Serenity.Decorators.registerClass()
    export class ServicioGrid extends Serenity.EntityGrid<ServicioRow, any> {
        protected getColumnsKey() { return 'Ascatur.Servicio'; }
        protected getDialogType() { return ServicioDialog; }
        protected getIdProperty() { return ServicioRow.idProperty; }
        protected getLocalTextPrefix() { return ServicioRow.localTextPrefix; }
        protected getService() { return ServicioService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}
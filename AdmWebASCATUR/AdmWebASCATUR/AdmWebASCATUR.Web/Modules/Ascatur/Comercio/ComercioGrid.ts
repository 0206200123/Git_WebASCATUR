
namespace AdmWebASCATUR.Ascatur {

    @Serenity.Decorators.registerClass()
    export class ComercioGrid extends Serenity.EntityGrid<ComercioRow, any> {
        protected getColumnsKey() { return 'Ascatur.Comercio'; }
        protected getDialogType() { return ComercioDialog; }
        protected getIdProperty() { return ComercioRow.idProperty; }
        protected getLocalTextPrefix() { return ComercioRow.localTextPrefix; }
        protected getService() { return ComercioService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}

namespace AdmWebASCATUR.Ascatur {

    @Serenity.Decorators.registerClass()
    export class OfertaGrid extends Serenity.EntityGrid<OfertaRow, any> {
        protected getColumnsKey() { return 'Ascatur.Oferta'; }
        protected getDialogType() { return OfertaDialog; }
        protected getIdProperty() { return OfertaRow.idProperty; }
        protected getLocalTextPrefix() { return OfertaRow.localTextPrefix; }
        protected getService() { return OfertaService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}
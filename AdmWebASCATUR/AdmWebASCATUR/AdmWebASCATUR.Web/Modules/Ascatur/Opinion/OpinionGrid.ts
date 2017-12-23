
namespace AdmWebASCATUR.Ascatur {

    @Serenity.Decorators.registerClass()
    export class OpinionGrid extends Serenity.EntityGrid<OpinionRow, any> {
        protected getColumnsKey() { return 'Ascatur.Opinion'; }
        protected getDialogType() { return OpinionDialog; }
        protected getIdProperty() { return OpinionRow.idProperty; }
        protected getLocalTextPrefix() { return OpinionRow.localTextPrefix; }
        protected getService() { return OpinionService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}
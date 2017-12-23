
namespace AdmWebASCATUR.Ascatur {

    @Serenity.Decorators.registerClass()
    export class EventosGrid extends Serenity.EntityGrid<EventosRow, any> {
        protected getColumnsKey() { return 'Ascatur.Eventos'; }
        protected getDialogType() { return EventosDialog; }
        protected getIdProperty() { return EventosRow.idProperty; }
        protected getLocalTextPrefix() { return EventosRow.localTextPrefix; }
        protected getService() { return EventosService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}
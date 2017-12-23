
namespace AdmWebASCATUR.Ascatur {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class EventosDialog extends Serenity.EntityDialog<EventosRow, any> {
        protected getFormKey() { return EventosForm.formKey; }
        protected getIdProperty() { return EventosRow.idProperty; }
        protected getLocalTextPrefix() { return EventosRow.localTextPrefix; }
        protected getNameProperty() { return EventosRow.nameProperty; }
        protected getService() { return EventosService.baseUrl; }

        protected form = new EventosForm(this.idPrefix);

    }
}
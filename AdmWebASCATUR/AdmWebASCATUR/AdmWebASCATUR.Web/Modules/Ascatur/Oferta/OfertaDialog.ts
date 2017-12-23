
namespace AdmWebASCATUR.Ascatur {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class OfertaDialog extends Serenity.EntityDialog<OfertaRow, any> {
        protected getFormKey() { return OfertaForm.formKey; }
        protected getIdProperty() { return OfertaRow.idProperty; }
        protected getLocalTextPrefix() { return OfertaRow.localTextPrefix; }
        protected getNameProperty() { return OfertaRow.nameProperty; }
        protected getService() { return OfertaService.baseUrl; }

        protected form = new OfertaForm(this.idPrefix);

    }
}

namespace AdmWebASCATUR.Ascatur {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ServicioDialog extends Serenity.EntityDialog<ServicioRow, any> {
        protected getFormKey() { return ServicioForm.formKey; }
        protected getIdProperty() { return ServicioRow.idProperty; }
        protected getLocalTextPrefix() { return ServicioRow.localTextPrefix; }
        protected getNameProperty() { return ServicioRow.nameProperty; }
        protected getService() { return ServicioService.baseUrl; }

        protected form = new ServicioForm(this.idPrefix);

    }
}

namespace AdmWebASCATUR.Ascatur {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ComercioDialog extends Serenity.EntityDialog<ComercioRow, any> {
        protected getFormKey() { return ComercioForm.formKey; }
        protected getIdProperty() { return ComercioRow.idProperty; }
        protected getLocalTextPrefix() { return ComercioRow.localTextPrefix; }
        protected getNameProperty() { return ComercioRow.nameProperty; }
        protected getService() { return ComercioService.baseUrl; }

        protected form = new ComercioForm(this.idPrefix);

    }
}
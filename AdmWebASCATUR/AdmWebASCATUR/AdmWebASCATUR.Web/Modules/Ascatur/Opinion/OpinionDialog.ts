
namespace AdmWebASCATUR.Ascatur {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class OpinionDialog extends Serenity.EntityDialog<OpinionRow, any> {
        protected getFormKey() { return OpinionForm.formKey; }
        protected getIdProperty() { return OpinionRow.idProperty; }
        protected getLocalTextPrefix() { return OpinionRow.localTextPrefix; }
        protected getNameProperty() { return OpinionRow.nameProperty; }
        protected getService() { return OpinionService.baseUrl; }

        protected form = new OpinionForm(this.idPrefix);

    }
}
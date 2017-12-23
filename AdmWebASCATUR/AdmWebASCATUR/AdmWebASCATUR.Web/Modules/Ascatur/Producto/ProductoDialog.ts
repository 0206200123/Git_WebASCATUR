
namespace AdmWebASCATUR.Ascatur {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ProductoDialog extends Serenity.EntityDialog<ProductoRow, any> {
        protected getFormKey() { return ProductoForm.formKey; }
        protected getIdProperty() { return ProductoRow.idProperty; }
        protected getLocalTextPrefix() { return ProductoRow.localTextPrefix; }
        protected getNameProperty() { return ProductoRow.nameProperty; }
        protected getService() { return ProductoService.baseUrl; }

        protected form = new ProductoForm(this.idPrefix);

    }
}
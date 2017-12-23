
namespace AdmWebASCATUR.Ascatur {

    @Serenity.Decorators.registerClass()
    export class ProductoGrid extends Serenity.EntityGrid<ProductoRow, any> {
        protected getColumnsKey() { return 'Ascatur.Producto'; }
        protected getDialogType() { return ProductoDialog; }
        protected getIdProperty() { return ProductoRow.idProperty; }
        protected getLocalTextPrefix() { return ProductoRow.localTextPrefix; }
        protected getService() { return ProductoService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}
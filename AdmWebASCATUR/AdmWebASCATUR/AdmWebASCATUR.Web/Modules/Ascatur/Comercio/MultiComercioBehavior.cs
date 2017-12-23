using AdmWebASCATUR.Administration;
using System.Linq;
using Serenity;
using Serenity.Data;
using Serenity.Services;

namespace AdmWebASCATUR.Web.Modules.Ascatur.Comercio
{
    public class MultiComercioBehavior : IImplicitBehavior,
    ISaveBehavior, IDeleteBehavior, IListBehavior, IRetrieveBehavior
    {
        private Int32Field fldIdComercio;

        public bool ActivateFor(Row row)
        {
            var mt = row as IMultiComercioRow;
            if (mt == null)
                return false;

            fldIdComercio = mt.IdComercioField;
            return true;
        }

        public void OnPrepareQuery(IRetrieveRequestHandler handler, SqlQuery query)
        {
            var user = (UserDefinition)Authorization.UserDefinition;
            if (!Authorization.HasPermission(PermissionKeys.Comercio))
                query.Where(fldIdComercio == user.Id_Comercio);
        }

        public void OnPrepareQuery(IListRequestHandler handler, SqlQuery query)
        {
            var user = (UserDefinition)Authorization.UserDefinition;
            if (!Authorization.HasPermission(PermissionKeys.Comercio))
                query.Where(fldIdComercio == user.Id_Comercio);
        }

        public void OnSetInternalFields(ISaveRequestHandler handler)
        {
            if (handler.IsCreate)
                fldIdComercio[handler.Row] = ((UserDefinition)Authorization.UserDefinition).Id_Comercio;
        }

        public void OnValidateRequest(ISaveRequestHandler handler)
        {
            if (handler.IsUpdate)
            {
                var user = (UserDefinition)Authorization.UserDefinition;
                if (fldIdComercio[handler.Old] != fldIdComercio[handler.Row])
                    Authorization.ValidatePermission(PermissionKeys.Comercio);
            }
        }

        public void OnValidateRequest(IDeleteRequestHandler handler)
        {
            var user = (UserDefinition)Authorization.UserDefinition;
            if (fldIdComercio[handler.Row] != user.Id_Comercio)
                Authorization.ValidatePermission(
                PermissionKeys.Comercio);
        }

        public void OnAfterDelete(IDeleteRequestHandler handler) { }
        public void OnAfterExecuteQuery(IRetrieveRequestHandler handler) { }
        public void OnAfterExecuteQuery(IListRequestHandler handler) { }
        public void OnAfterSave(ISaveRequestHandler handler) { }
        public void OnApplyFilters(IListRequestHandler handler, SqlQuery query) { }
        public void OnAudit(IDeleteRequestHandler handler) { }
        public void OnAudit(ISaveRequestHandler handler) { }
        public void OnBeforeDelete(IDeleteRequestHandler handler) { }
        public void OnBeforeExecuteQuery(IRetrieveRequestHandler handler) { }
        public void OnBeforeExecuteQuery(IListRequestHandler handler) { }
        public void OnBeforeSave(ISaveRequestHandler handler) { }
        public void OnPrepareQuery(IDeleteRequestHandler handler, SqlQuery query) { }
        public void OnPrepareQuery(ISaveRequestHandler handler, SqlQuery query) { }
        public void OnReturn(IDeleteRequestHandler handler) { }
        public void OnReturn(IRetrieveRequestHandler handler) { }
        public void OnReturn(IListRequestHandler handler) { }
        public void OnReturn(ISaveRequestHandler handler) { }
        public void OnValidateRequest(IRetrieveRequestHandler handler) { }
        public void OnValidateRequest(IListRequestHandler handler) { }
    }
}

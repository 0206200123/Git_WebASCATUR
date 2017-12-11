/// <reference path="../Common/Helpers/LanguageList.ts" />

namespace AdmWebASCATUR.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('AdmWebASCATUR');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}
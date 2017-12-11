using Serenity.Navigation;
using Administration = AdmWebASCATUR.Administration.Pages;
using MyPages = AdmWebASCATUR.Ascatur.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]


[assembly: NavigationMenu(2000, "Ascatur", icon: "fa-bars")]
[assembly: NavigationLink(2100, "Ascatur/Comercio", typeof(MyPages.ComercioController), icon: "fa-book")]

[assembly: NavigationMenu(9000, "Administration", icon: "fa-desktop")]
[assembly: NavigationLink(9000, "Administration/Languages", typeof(Administration.LanguageController), icon: "fa-comments")]
[assembly: NavigationLink(9000, "Administration/Translations", typeof(Administration.TranslationController), icon: "fa-comment-o")]
[assembly: NavigationLink(9000, "Administration/Sergen", typeof(Administration.SergenController), icon: "fa-magic")]
[assembly: NavigationLink(9000, "Administration/Roles", typeof(Administration.RoleController), icon: "fa-lock")]
[assembly: NavigationLink(9000, "Administration/User Management", typeof(Administration.UserController), icon: "fa-users")]

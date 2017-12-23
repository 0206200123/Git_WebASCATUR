using Serenity.Navigation;
using Administration = AdmWebASCATUR.Administration.Pages;
using MyPages = AdmWebASCATUR.Ascatur.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]


[assembly: NavigationMenu(2000, "Ascatur", icon: "fa-bars")]
[assembly: NavigationLink(2100, "Ascatur/Comercio", typeof(MyPages.ComercioController), icon: "fa-book")]
[assembly: NavigationLink(2200, "Ascatur/Servicio", typeof(MyPages.ServicioController), icon: "fa-hotel")]
[assembly: NavigationLink(2300, "Ascatur/Producto", typeof(MyPages.ProductoController), icon: "fa-coffee")]
[assembly: NavigationLink(2400, "Ascatur/Oferta", typeof(MyPages.OfertaController), icon: "fa-percent")]
[assembly: NavigationLink(2500, "Ascatur/Eventos", typeof(MyPages.EventosController), icon: "fa-paper-plane")]
[assembly: NavigationLink(2600, "Ascatur/Opinion", typeof(MyPages.OpinionController), icon: "fa-comments")]

[assembly: NavigationMenu(9000, "Administration", icon: "fa-desktop")]
[assembly: NavigationLink(9100, "Administration/Languages", typeof(Administration.LanguageController), icon: "fa-comments")]
[assembly: NavigationLink(9200, "Administration/Translations", typeof(Administration.TranslationController), icon: "fa-comment-o")]
[assembly: NavigationLink(9300, "Administration/Sergen", typeof(Administration.SergenController), icon: "fa-magic")]
[assembly: NavigationLink(9400, "Administration/Roles", typeof(Administration.RoleController), icon: "fa-lock")]
[assembly: NavigationLink(9500, "Administration/User Management", typeof(Administration.UserController), icon: "fa-users")]

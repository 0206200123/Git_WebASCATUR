
namespace AdmWebASCATUR.Ascatur.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.EventosRow))]
    public class EventosController : Controller
    {
        [Route("Ascatur/Eventos")]
        public ActionResult Index()
        {
            return View("~/Modules/Ascatur/Eventos/EventosIndex.cshtml");
        }
    }
}
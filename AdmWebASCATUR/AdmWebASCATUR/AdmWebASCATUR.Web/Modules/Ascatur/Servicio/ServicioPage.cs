
namespace AdmWebASCATUR.Ascatur.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.ServicioRow))]
    public class ServicioController : Controller
    {
        [Route("Ascatur/Servicio")]
        public ActionResult Index()
        {
            return View("~/Modules/Ascatur/Servicio/ServicioIndex.cshtml");
        }
    }
}
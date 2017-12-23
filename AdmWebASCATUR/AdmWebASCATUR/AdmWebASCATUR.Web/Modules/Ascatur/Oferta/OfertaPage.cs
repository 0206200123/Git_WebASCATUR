
namespace AdmWebASCATUR.Ascatur.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.OfertaRow))]
    public class OfertaController : Controller
    {
        [Route("Ascatur/Oferta")]
        public ActionResult Index()
        {
            return View("~/Modules/Ascatur/Oferta/OfertaIndex.cshtml");
        }
    }
}
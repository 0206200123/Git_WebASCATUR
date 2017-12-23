
namespace AdmWebASCATUR.Ascatur.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.ComercioRow))]
    public class ComercioController : Controller
    {
        [Route("Ascatur/Comercio")]
        public ActionResult Index()
        {
            return View("~/Modules/Ascatur/Comercio/ComercioIndex.cshtml");
        }
    }
}
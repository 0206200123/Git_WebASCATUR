
namespace AdmWebASCATUR.Ascatur.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.OpinionRow))]
    public class OpinionController : Controller
    {
        [Route("Ascatur/Opinion")]
        public ActionResult Index()
        {
            return View("~/Modules/Ascatur/Opinion/OpinionIndex.cshtml");
        }
    }
}
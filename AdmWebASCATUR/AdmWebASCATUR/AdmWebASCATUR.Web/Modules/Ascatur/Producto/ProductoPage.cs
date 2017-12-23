
namespace AdmWebASCATUR.Ascatur.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.ProductoRow))]
    public class ProductoController : Controller
    {
        [Route("Ascatur/Producto")]
        public ActionResult Index()
        {
            return View("~/Modules/Ascatur/Producto/ProductoIndex.cshtml");
        }
    }
}
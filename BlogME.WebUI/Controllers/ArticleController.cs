using System.Web.Mvc;

namespace BlogME.WebUI.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            return View();
        }
    }
}
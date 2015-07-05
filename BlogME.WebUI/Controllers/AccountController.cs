using System.Web.Mvc;
using BlogME.WebUI.Models;

namespace BlogME.WebUI.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(AccountViewModel viewModel)
        {
            return RedirectToAction("Dashboard");
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Tags()
        {
            return View();
        }
    }
}
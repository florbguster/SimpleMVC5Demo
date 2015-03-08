using MVCApp.Models;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new PlayerModel();

            return View(model);
        }
    }
}
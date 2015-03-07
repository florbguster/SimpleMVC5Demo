using MVCApp.Models;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new UsersViewModel();

            return View(model);
        }
    }
}
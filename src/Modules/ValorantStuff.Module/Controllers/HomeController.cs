using Microsoft.AspNetCore.Mvc;

namespace ValorantStuff.Module.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}

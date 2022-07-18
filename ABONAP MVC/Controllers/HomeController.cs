using Microsoft.AspNetCore.Mvc;

namespace ABONAP_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

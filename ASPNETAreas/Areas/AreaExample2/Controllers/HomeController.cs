using Microsoft.AspNetCore.Mvc;

namespace ASPNETAreas.Areas.AreaExample2.Controllers
{
    [Area("AreaExample2")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

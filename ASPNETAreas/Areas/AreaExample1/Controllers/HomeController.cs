using ASPNETAreas.Areas.AreaExample1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETAreas.Areas.AreaExample1.Controllers
{
    [Area("AreaExample1")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomeModel()
            {
                Title = "This is AreaExample1",
                Message = "This is the message"
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Form(HomeModel model)
        {
            Console.WriteLine(model.FormData.Name);
            Console.WriteLine(model.FormData.Email);

            return RedirectToAction("Index");
        }
    }
}

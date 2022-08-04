using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers
{
    public class Controller1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

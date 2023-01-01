using Microsoft.AspNetCore.Mvc;

namespace TarimSunumuUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

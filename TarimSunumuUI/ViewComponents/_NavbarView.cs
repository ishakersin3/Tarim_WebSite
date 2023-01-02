using Microsoft.AspNetCore.Mvc;

namespace TarimSunumuUI.ViewComponents
{
    public class _NavbarView:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

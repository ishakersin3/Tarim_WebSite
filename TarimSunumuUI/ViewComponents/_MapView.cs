using Microsoft.AspNetCore.Mvc;

namespace TarimSunumuUI.ViewComponents
{
    public class _MapView:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

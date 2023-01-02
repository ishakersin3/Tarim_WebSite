using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TarimSunumuUI.ViewComponents
{
    public class _AboutView:ViewComponent
    {
        private IAboutService _aboutService;

        public _AboutView(IAboutService aboutService)
        {
            _aboutService = aboutService;   
        }
        public IViewComponentResult Invoke()
        {
            var model =_aboutService.GetListAll();
            return View(model);
        }
    }
}

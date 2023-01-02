using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TarimSunumuUI.ViewComponents
{
    public class _ServiceView:ViewComponent
    {
        IServiceService _serviceService;
        public _ServiceView(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }
        public IViewComponentResult Invoke()
        {
            var model = _serviceService.GetListAll();
            return View(model);
        }
    }
}

using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TarimSunumuUI.ViewComponents
{
    public class _GalleryView:ViewComponent
    {
        private IImageService _ımageService;

        public _GalleryView(IImageService imageService)
        {
            _ımageService = imageService;
        }

        public IViewComponentResult Invoke()
        {
            var model =_ımageService.GetListAll();
            return View(model);
        }
    }
}

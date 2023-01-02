using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TarimSunumuUI.ViewComponents
{
    public class _SocialMediaView:ViewComponent
    {
        private ISocialMediaService _socialMediaService;
        public _SocialMediaView(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IViewComponentResult Invoke()
        {
            var model = _socialMediaService.GetListAll();
            return View(model);  
        }
    }
}

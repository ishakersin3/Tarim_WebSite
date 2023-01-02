using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TarimSunumuUI.ViewComponents
{
	public class _AnnouncementView:ViewComponent
	{
		private IAnnouncementService _announcementService;
		public _AnnouncementView(IAnnouncementService announcementService)
		{
			_announcementService= announcementService;
		}
		public IViewComponentResult Invoke ()
		{
			var model = _announcementService.GetListAll();
			return View(model);
		}
	}
}

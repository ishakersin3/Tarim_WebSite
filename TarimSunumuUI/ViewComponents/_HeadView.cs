using Microsoft.AspNetCore.Mvc;

namespace TarimSunumuUI.ViewComponents
{
	public class _HeadView:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

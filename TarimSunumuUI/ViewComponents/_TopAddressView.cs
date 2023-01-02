using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TarimSunumuUI.ViewComponents
{
	public class _TopAddressView:ViewComponent
	{
		private IAddressService _addressService;

		public _TopAddressView(IAddressService addressService)
		{
			_addressService = addressService;
		}

		public IViewComponentResult Invoke()
		{
			var model = _addressService.GetListAll();
			return View(model);
		}
	}
}

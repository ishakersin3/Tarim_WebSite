using BusinessLayer.Abstract;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TarimSunumuUI.Controllers
{
    public class DefaultController : Controller
    {
        private IContactService _contactService;

		public DefaultController(IContactService contactService)
		{
			_contactService = contactService;
		}

		public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
		public IActionResult SendMessage(Contact contact)
		{
            contact.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
			_contactService.Insert(contact);           
			return RedirectToAction("Index","Default");
		}
	}
}

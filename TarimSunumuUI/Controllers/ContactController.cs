using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace TarimSunumuUI.Controllers
{
    public class ContactController : Controller
    {
        IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IActionResult Index()
        {
            var model = _contactService.GetListAll();
            return View(model);
        }
        public IActionResult DeleteMessage(int id)
        {
            var value =_contactService.GetById(id);
            _contactService.Delete(value);
            return RedirectToAction("Index");
        }
        public IActionResult MessageDetails(int id)
        {
            var value =_contactService.GetById(id);
            return View(value);
        }
        
    }
}

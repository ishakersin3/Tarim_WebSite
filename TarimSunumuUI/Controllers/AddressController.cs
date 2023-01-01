using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace TarimSunumuUI.Controllers
{
    public class AddressController : Controller
    {
        IAddressService _addressService;

        public AddressController(IAddressService teamService)
        {
            this._addressService = teamService;
        }
        public IActionResult Index()
        {
            var model = _addressService.GetListAll();
            return View(model);
        }
        public IActionResult UpdateAddress(int id)
        {
            var value = _addressService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateAddress(Address address)
        {
            AddressValidator _addressvalidator = new AddressValidator();
            ValidationResult result = _addressvalidator.Validate(address);
            if (result.IsValid)
            {
                _addressService.Update(address);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }
            return View();
        }

    }
}


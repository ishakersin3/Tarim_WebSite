using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace TarimSunumuUI.Controllers
{
    public class ImageController : Controller
    {
        private IImageService _ımageService;

        public ImageController(IImageService ımageService)
        {
            _ımageService = ımageService;
        }
        public IActionResult Index()
        {
            var value = _ımageService.GetListAll();
            return View(value);
        }
        public IActionResult CreateImage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateImage(Image img)
        {
            ImageValidator _ımagevalidator = new ImageValidator();
            ValidationResult result = _ımagevalidator.Validate(img);
            if (result.IsValid)
            {
                _ımageService.Insert(img);
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
        public IActionResult DeleteImage(int id)
        {
            var value = _ımageService.GetById(id);
            _ımageService.Delete(value);
            return RedirectToAction("Index");
        }
        public IActionResult UpdateImage(int id)
        {
            var value = _ımageService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateImage(Image img)
        {
            ImageValidator _ımagevalidator = new ImageValidator();
            ValidationResult result = _ımagevalidator.Validate(img);
            if (result.IsValid)
            {
                _ımageService.Update(img);
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

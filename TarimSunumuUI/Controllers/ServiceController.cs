using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFrameworkRepository;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using TarimSunumuUI.Models;

namespace TarimSunumuUI.Controllers
{
    public class ServiceController : Controller
    {
        IServiceService _serviceService;

        public ServiceController(IServiceService serviceManager)
        {
            _serviceService = serviceManager;
        }

        public IActionResult Index()
        {
            var values = _serviceService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateService()
        {
            return View(new ServiceAddViewModel());
        }
        [HttpPost]
        public IActionResult CreateService(ServiceAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _serviceService.Insert(new Service
                {
                    Title= model.Title,
                    Description= model.Description,
                    İmageUrl = model.Image
                });
                return RedirectToAction("Index");
            }
            return View(model);
           
        }
        public IActionResult DeleteService(int id)
        {
            var value = _serviceService.GetById(id);
            _serviceService.Delete(value);
            return RedirectToAction("Index");
        }
        public IActionResult UpdateService(int id)
        {
            var value = _serviceService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateService(Service service)
        {           
                _serviceService.Update(service);
                return RedirectToAction("Index");                    
        }
       
    }
}

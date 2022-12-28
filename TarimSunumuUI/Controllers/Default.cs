using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFrameworkRepository;
using Microsoft.AspNetCore.Mvc;

namespace TarimSunumuUI.Controllers
{
    public class Default : Controller
    {
        ServiceManager _serviceManager = new ServiceManager(new EfServiceRepository());
        public IActionResult Index()
        {
            var values =_serviceManager.GetListAll();
            return View(values);
        }
    }
}

using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace TarimSunumuUI.Controllers
{
    public class TeamController : Controller
    {
        ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            this._teamService = teamService;
        }
        public IActionResult Index()
        {
            var model = _teamService.GetListAll();
            return View(model);
        }
        public IActionResult CreateTeam()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTeam(Team team)
        {
            TeamValidator _teamvalidator= new TeamValidator();
            ValidationResult result= _teamvalidator.Validate(team);
            if (result.IsValid)
            {
                _teamService.Insert(team);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName,error.ErrorMessage);
                }
            }
            return View();
            
        }
        public IActionResult DeleteTeam(int id)
        {
            var value = _teamService.GetById(id);
            _teamService.Delete(value);
            return RedirectToAction("Index");
        }
        public IActionResult UpdateTeam(int id)
        {
            var value = _teamService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateTeam(Team team)
        {
            TeamValidator _teamvalidator = new TeamValidator();
            ValidationResult result = _teamvalidator.Validate(team);
            if (result.IsValid)
            {
                _teamService.Update(team);
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

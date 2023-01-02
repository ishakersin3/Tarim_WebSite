using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TarimSunumuUI.ViewComponents
{
    public class _TeamView:ViewComponent
    {
        private ITeamService _teamService;

        public _TeamView(ITeamService teamService)
        {
            _teamService= teamService;
        }
        public IViewComponentResult Invoke()
        {
            var model = _teamService.GetListAll();
            return View(model);
        }
    }
}

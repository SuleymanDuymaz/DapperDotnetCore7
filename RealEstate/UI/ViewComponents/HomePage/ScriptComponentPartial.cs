using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.HomePage
{
    public class ScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

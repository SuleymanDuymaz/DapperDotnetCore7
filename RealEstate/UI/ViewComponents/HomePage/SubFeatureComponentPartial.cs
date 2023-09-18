using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.HomePage
{
    public class SubFeatureComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

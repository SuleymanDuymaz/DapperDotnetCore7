using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.HomePage
{
    public class FeatureComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

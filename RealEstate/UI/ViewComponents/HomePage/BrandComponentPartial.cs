using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.HomePage
{
    public class BrandComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

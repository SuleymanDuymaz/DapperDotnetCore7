using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.HomePage
{
    public class FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

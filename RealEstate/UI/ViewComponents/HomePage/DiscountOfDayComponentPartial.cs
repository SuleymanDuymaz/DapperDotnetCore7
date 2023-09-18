using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.HomePage
{
    public class DiscountOfDayComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

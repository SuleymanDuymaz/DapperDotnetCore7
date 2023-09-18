using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Layout
{
    public class _HeadarViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

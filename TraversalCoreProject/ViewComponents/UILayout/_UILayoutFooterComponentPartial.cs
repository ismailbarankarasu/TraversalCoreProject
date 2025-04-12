using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.UILayout
{
    public class _UILayoutFooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.UILayout
{
    public class _UILayoutHeaderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

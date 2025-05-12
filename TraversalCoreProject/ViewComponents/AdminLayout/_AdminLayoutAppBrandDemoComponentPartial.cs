using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.AdminLayout
{
    public class _AdminLayoutAppBrandDemoComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.AdminLayout
{
    public class _AdminLayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

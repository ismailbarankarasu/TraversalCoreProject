using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.AdminDashboard
{
    public class _AdminDashboardGuideListComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

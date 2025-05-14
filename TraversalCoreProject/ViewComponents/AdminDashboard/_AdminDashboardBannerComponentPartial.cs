using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.AdminDashboard
{
    public class _AdminDashboardBannerComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

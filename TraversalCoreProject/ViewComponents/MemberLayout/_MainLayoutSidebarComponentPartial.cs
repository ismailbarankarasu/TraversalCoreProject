using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.MemberLayout
{
    public class _MainLayoutSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

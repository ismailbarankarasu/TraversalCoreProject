using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.MemberLayout
{
    public class _MemberLayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

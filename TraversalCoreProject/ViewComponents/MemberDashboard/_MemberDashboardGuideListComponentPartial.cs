using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.MemberDashboard
{
    public class _MemberDashboardGuideListComponentPartial:ViewComponent
    {
        private readonly IGuideService _guideService;

        public _MemberDashboardGuideListComponentPartial(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _guideService.TGetList();
            return View(values);
        }
    }
}

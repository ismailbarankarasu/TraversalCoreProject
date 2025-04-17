using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.UILayout
{
    public class _UILayoutStatsComponentPartial:ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public _UILayoutStatsComponentPartial(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = _destinationService.TDestinationCount();
            ViewBag.v2 = _destinationService.TGuidesCount();
            ViewBag.v3 = "285";
            return View();
        }
    }
}

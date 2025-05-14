using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace TraversalCoreProject.ViewComponents.AdminDashboard
{
    public class _AdminDashboardCards1StatisticsComponentPartial:ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public _AdminDashboardCards1StatisticsComponentPartial(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.destinationCount = _destinationService.TDestinationCount();
            ViewBag.guideCount = _destinationService.TUsersCount();
            return View();
        }
    }
}

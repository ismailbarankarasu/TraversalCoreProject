using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace TraversalCoreProject.ViewComponents.UILayout
{
    public class _UILayoutGridComponentPartial:ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public _UILayoutGridComponentPartial(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _destinationService.TGetList();
            return View(values);
        }
    }
}

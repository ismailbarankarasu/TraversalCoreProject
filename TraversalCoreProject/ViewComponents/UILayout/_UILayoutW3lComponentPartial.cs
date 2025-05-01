using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.UILayout
{
    public class _UILayoutW3lComponentPartial:ViewComponent
    {
        private readonly ISubAboutService _subAboutService;

        public _UILayoutW3lComponentPartial(ISubAboutService subAboutService)
        {
            _subAboutService = subAboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _subAboutService.TGetList();
            return View(values);
        }
    }
}

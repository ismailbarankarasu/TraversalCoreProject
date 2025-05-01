using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.UILayout
{
    public class _UILayoutTestimonialsComponentPartial:ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public _UILayoutTestimonialsComponentPartial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _testimonialService.TGetList();
            return View(values);
        }
    }
}

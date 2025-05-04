using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Comment
{
    public class _CommentCreate:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

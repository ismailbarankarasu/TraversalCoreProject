using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var values = _commentService.TCommentListWithDestination();
            return View(values);
        }
        public IActionResult DeleteComment(int id)
        {
            var value = _commentService.TGetById(id);
            _commentService.TDelete(value);
            return RedirectToAction("Index", "Comment", new { area = "Admin" });

        }
    }
}

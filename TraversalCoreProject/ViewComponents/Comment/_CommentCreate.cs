using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TraversalCoreProject.ViewComponents.Comment
{
    public class _CommentCreate:ViewComponent
    {
        private readonly ICommentService _commentService;

        public _CommentCreate(ICommentService commentService)
        {
            _commentService = commentService;
        }
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

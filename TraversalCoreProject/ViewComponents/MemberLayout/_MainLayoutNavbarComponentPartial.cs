﻿using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.MemberLayout
{
    public class _MainLayoutNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

﻿using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.AdminLayout
{
    public class _AdminLayoutNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

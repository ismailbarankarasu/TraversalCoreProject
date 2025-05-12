﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProject.ViewComponents.MemberDashboard
{
    public class _MemberDashboardProfileInformationComponentPartial:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _MemberDashboardProfileInformationComponentPartial(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.memberName = values.Name + " " + values.Surname;
            ViewBag.memberMail = values.Email;
            ViewBag.memberPhone = values.PhoneNumber;
            return View();
        }
    }
}

using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;

        public UserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {
            var values = _appUserService.TGetList();
            return View(values);
        }
        public IActionResult DeleteUser(int id)
        {
            var value = _appUserService.TGetById(id);
            _appUserService.TDelete(value);
            return RedirectToAction("Index", "User", new { area = "Admin" });
        }
        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var values = _appUserService.TGetById(id);
            return View(values);
        }
        [HttpPost]  
        public IActionResult EditUser(AppUser appUser)
        {
            _appUserService.TUpdate(appUser);
            return RedirectToAction("Index", "User", new { area = "Admin" });
        }
        public IActionResult CommentUser(int id)
        {
            return View();
        }
        public IActionResult ReservationUser(int id)
        {
            return View();
        }
    }
}

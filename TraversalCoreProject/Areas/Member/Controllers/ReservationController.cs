using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly IReservationService _reservationService;

        public ReservationController(IDestinationService destinationService, IReservationService reservationService)
        {
            _destinationService = destinationService;
            _reservationService = reservationService;
        }

        public IActionResult MyCurrentReservation()
        {

            return View();
        }
        public IActionResult MyOldReservation()
        {
            return View();
        }
        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in _destinationService.TGetList()
                        select new SelectListItem
                        {
                            Text = x.City,
                            Value = x.DesctinationId.ToString()
                        }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult NewReservation(Reservation p)
        {
            p.AppUserId = 1; // This should be replaced with the actual user ID from the session or authentication context
            p.Status = "Onay Bekliyor";
            TempData["ReservationSuccess"] = true;
            _reservationService.TAdd(p);
            return RedirectToAction("MyCurrentReservation");
        }
    }
}

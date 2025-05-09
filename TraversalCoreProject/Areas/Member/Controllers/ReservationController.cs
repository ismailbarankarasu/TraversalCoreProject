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

        public ReservationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
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
            return View();
        }
        [HttpPost]
        public IActionResult NewReservation(Reservation p)
        {
            return View();
        }
    }
}

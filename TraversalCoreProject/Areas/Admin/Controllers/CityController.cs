using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CityList()
        {
            return Json(_destinationService.TGetList());
        }
        public static List<CityClass> cities = new List<CityClass>
        {
            new CityClass{CityId=1, CityName="Istanbul", Country="Türkiye"},
            new CityClass{CityId=2, CityName="Ankara", Country="Türkiye"},
            new CityClass{CityId=3, CityName="Izmir", Country="Türkiye"},
            new CityClass{CityId=4, CityName="Berlin", Country="Almanya"},
            new CityClass{CityId=5, CityName="Paris", Country="Fransa"},
            new CityClass{CityId=6, CityName="London", Country="İngiltere"}
        };
    }
}

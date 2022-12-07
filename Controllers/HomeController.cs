using DataEntryICTSBM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DataEntryICTSBM.Controllers
{
    public class HomeController : Controller
    {
        private readonly LIVEAdvanceDevSwachhBharatMainContext _context;

        public HomeController(LIVEAdvanceDevSwachhBharatMainContext context)
        {
            _context = context;
        }


        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AllULBDataEntry()
        {


            var data = _context.HouseEntryCount.FromSqlRaw("HouseEntryCount").ToList();

            ViewBag.data = data;
           

            return View();
        }

        public IActionResult HouseDataEntry()
        {
            var data = _context.HouseEntryCount.FromSqlRaw("HouseEntryCount").ToList();

            @ViewBag.data = data;

            return View();
        }

        public IActionResult DumpYardDataEntry()
        {
            var data = _context.HouseEntryCount.FromSqlRaw("DumpYardEntryCount").ToList();

            ViewBag.data = data;

            return View();
        }

        public IActionResult LiquidDataEntry()
        {
            var data = _context.HouseEntryCount.FromSqlRaw("LiquidEntryCount").ToList();

            ViewBag.data = data;

            return View();
        }

        public IActionResult StreetDataEntry()
        {
            var data = _context.HouseEntryCount.FromSqlRaw("StreetEntryCount").ToList();


            ViewBag.data = data;
            return View();
        }
    }
}

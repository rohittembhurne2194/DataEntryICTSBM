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
            if(TempData["errorMessage"] != null)
            {
                @ViewBag.errormsg = TempData["errorMessage"].ToString();
                return View();
            }
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
            try
            {
                var data = _context.HouseEntryCount.FromSqlRaw("HouseEntryCount").ToList();

                if (data != null)
                {
                    @ViewBag.data = data;

                    return View();
                }
                else
                {
                    TempData["errorMessage"] = "Please Try Again Later";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

                TempData["errorMessage"] = ex.Message.ToString();
                return RedirectToAction("Index");

            }
        }

        public IActionResult DumpYardDataEntry()
        {
            try
            {
                var data = _context.HouseEntryCount.FromSqlRaw("DumpYardEntryCount").ToList();
                if (data != null)
                {
                    @ViewBag.data = data;


                    return View();
                }
                else
                {
                    TempData["errorMessage"] = "Please Try Again Later";
                    return RedirectToAction("Index");
                }
            }

            catch (Exception ex)
            {

                TempData["errorMessage"] = ex.Message.ToString();
                return RedirectToAction("Index");

            }
        }

        public IActionResult LiquidDataEntry()
        {
            try
            {
                var data = _context.HouseEntryCount.FromSqlRaw("LiquidEntryCount").ToList();

                if (data != null)
                {
                    @ViewBag.data = data;


                    return View();
                }
                else
                {
                    TempData["errorMessage"] = "Please Try Again Later";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

                TempData["errorMessage"] = ex.Message.ToString();
                return RedirectToAction("Index");

            }
         
        }

        public IActionResult StreetDataEntry()
        {
            try
            {
                var data = _context.HouseEntryCount.FromSqlRaw("StreetEntryCount").ToList();

                if (data != null)
                {
                    @ViewBag.data = data;


                    return View();
                }
                else
                {
                    TempData["errorMessage"] = "Please Try Again Later";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

                TempData["errorMessage"] = ex.Message.ToString();
                return RedirectToAction("Index");

            }
           
        }
    }
}

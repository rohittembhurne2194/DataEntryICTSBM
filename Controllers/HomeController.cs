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
using System.Text.Json;
using System.Threading.Tasks;
using System.Web.WebPages.Html;

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
                using (SqlConnection connection = new SqlConnection(_context.Database.GetDbConnection().ConnectionString))
                {
                    connection.Open();

                    var command = connection.CreateCommand();
                    _context.Database.SetCommandTimeout(TimeSpan.FromMinutes(20));

                    const string CheckIfTableExistsStatement = "SELECT * FROM sys.objects WHERE name = N'HouseEntryCount'";
                    command.CommandText = CheckIfTableExistsStatement;
                    var executeScalar = command.ExecuteScalar();
                    if (executeScalar != null)
                    {
                        var data = _context.HouseEntryCount.FromSqlRaw("HouseEntryCount").ToList();

                        if (data != null)
                        {
                            @ViewBag.data = data;
                            @ViewBag.TotalCount = data.Sum(x => x.total_count);
                            @ViewBag.UpdateCount = data.Sum(x => x.updated_count);
                            @ViewBag.Count = data.Sum(x => x._count);
                            @ViewBag.TodayTotal = data.Sum(x => x.Todays_count);

                            return View();
                        }
                        else
                        {
                            TempData["errorMessage"] = "Please Try Again Later";
                            return RedirectToAction("Index");
                        }
                    }
                    else
                    {
                        TempData["errorMessage"] = "Please Try Again Later";
                        return RedirectToAction("Index");
                    }

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
                using (SqlConnection connection = new SqlConnection(_context.Database.GetDbConnection().ConnectionString))
                {
                    connection.Open();

                    var command = connection.CreateCommand();
                    _context.Database.SetCommandTimeout(TimeSpan.FromMinutes(20));

                    const string CheckIfTableExistsStatement = "SELECT * FROM sys.objects WHERE name = N'DumpYardEntryCount'";
                    command.CommandText = CheckIfTableExistsStatement;
                    var executeScalar = command.ExecuteScalar();
                    if (executeScalar != null)
                    {
                        var data = _context.HouseEntryCount.FromSqlRaw("DumpYardEntryCount").ToList();

                        if (data != null)
                        {
                            @ViewBag.data = data;
                            @ViewBag.TotalCount = data.Sum(x => x.total_count);
                            @ViewBag.UpdateCount = data.Sum(x => x.updated_count);
                            @ViewBag.Count = data.Sum(x => x._count);
                            @ViewBag.TodayTotal = data.Sum(x => x.Todays_count);

                            return View();
                        }
                        else
                        {
                            TempData["errorMessage"] = "Please Try Again Later";
                            return RedirectToAction("Index");
                        }
                    }
                    else
                    {
                        TempData["errorMessage"] = "Please Try Again Later";
                        return RedirectToAction("Index");
                    }

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
                using (SqlConnection connection = new SqlConnection(_context.Database.GetDbConnection().ConnectionString))
                {
                    connection.Open();

                    var command = connection.CreateCommand();
                    _context.Database.SetCommandTimeout(TimeSpan.FromMinutes(20));

                    const string CheckIfTableExistsStatement = "SELECT * FROM sys.objects WHERE name = N'LiquidEntryCount'";
                    command.CommandText = CheckIfTableExistsStatement;
                    var executeScalar = command.ExecuteScalar();
                    if (executeScalar != null)
                    {
                        var data = _context.HouseEntryCount.FromSqlRaw("LiquidEntryCount").ToList();

                        if (data != null)
                        {
                            @ViewBag.data = data;
                            @ViewBag.TotalCount = data.Sum(x => x.total_count);
                            @ViewBag.UpdateCount = data.Sum(x => x.updated_count);
                            @ViewBag.Count = data.Sum(x => x._count);
                            @ViewBag.TodayTotal = data.Sum(x => x.Todays_count);

                            return View();
                        }
                        else
                        {
                            TempData["errorMessage"] = "Please Try Again Later";
                            return RedirectToAction("Index");
                        }
                    }
                    else
                    {
                        TempData["errorMessage"] = "Please Try Again Later";
                        return RedirectToAction("Index");
                    }

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
                using (SqlConnection connection = new SqlConnection(_context.Database.GetDbConnection().ConnectionString))
                {
                    connection.Open();

                    var command = connection.CreateCommand();
                    _context.Database.SetCommandTimeout(TimeSpan.FromMinutes(20));

                    const string CheckIfTableExistsStatement = "SELECT * FROM sys.objects WHERE name = N'StreetEntryCount'";
                    command.CommandText = CheckIfTableExistsStatement;
                    var executeScalar = command.ExecuteScalar();
                    if (executeScalar != null)
                    {
                        var data = _context.HouseEntryCount.FromSqlRaw("StreetEntryCount").ToList();

                        if (data != null)
                        {
                            @ViewBag.data = data;
                            @ViewBag.TotalCount = data.Sum(x => x.total_count);
                            @ViewBag.UpdateCount = data.Sum(x => x.updated_count);
                            @ViewBag.Count = data.Sum(x => x._count);
                            @ViewBag.TodayTotal = data.Sum(x => x.Todays_count);

                            return View();
                        }
                        else
                        {
                            TempData["errorMessage"] = "Please Try Again Later";
                            return RedirectToAction("Index");
                        }
                    }
                    else
                    {
                        TempData["errorMessage"] = "Please Try Again Later";
                        return RedirectToAction("Index");
                    }

                }
              
            }
            catch (Exception ex)
            {

                TempData["errorMessage"] = ex.Message.ToString();
                return RedirectToAction("Index");

            }
           
        }

        public ActionResult ListAllApp()
        {


            List<SelectListItem> lstApps = GetUlbList();
            //return Json(lstApps, System.Web.Mvc.JsonRequestBehavior.AllowGet);
            //return Json(lstApps);

            // Create JsonSerializerOptions
            var jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true // Optional: to make the output more readable
            };

            // Return JsonResult with data and serializer settings
            return new JsonResult(lstApps)
            {
                SerializerSettings = jsonSerializerOptions
            };

        }

        public List<SelectListItem> GetUlbList()
        {
            var apps = new List<SelectListItem>();

            try
            {

                apps = _context.AppDetails.Where(a => a.IsActive == true).Select(x => new SelectListItem
                {
                    Value = x.AppId.ToString(),
                    Text = x.AppName
                }).OrderBy(t => t.Text).ToList();


            }
            catch (Exception ex) { return apps; }

            return apps;
        }
    }
}

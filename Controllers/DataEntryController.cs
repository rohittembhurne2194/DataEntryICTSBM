using DataEntryICTSBM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataEntryICTSBM.Controllers
{
    public class DataEntryController : Controller
    {
        private readonly LIVEAdvanceDevSwachhBharatMainContext _context;

        public DataEntryController(LIVEAdvanceDevSwachhBharatMainContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DataEntryHouse()
        {
            return View();
        }

        public IActionResult HouseDataEntry(string Appid)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_context.Database.GetDbConnection().ConnectionString))
                {
                    connection.Open();

                    var command = connection.CreateCommand();
                    _context.Database.SetCommandTimeout(TimeSpan.FromMinutes(30));

                    const string CheckIfTableExistsStatement = "SELECT * FROM sys.objects WHERE name = N'HouseEntryCount'";
                    command.CommandText = CheckIfTableExistsStatement;
                    var executeScalar = command.ExecuteScalar();
                    if (executeScalar != null)
                    {
                        int NAppId = Convert.ToInt32(Appid);
                        List<SqlParameter> parms = new List<SqlParameter>
                        {
                        // Create parameter(s)
                        new SqlParameter { ParameterName = "@Nappid", Value = NAppId },

                        };

                        var data = _context.HouseEntryCount.FromSqlRaw("HouseEntryCount @Nappid", parms.ToArray()).ToList();

                        if (data != null)
                        {
                            @ViewBag.data = data;
                            @ViewBag.TotalCount = data.Sum(x => x.total_count);
                            @ViewBag.UpdateCount = data.Sum(x => x.updated_count);
                            @ViewBag.Count = data.Sum(x => x._count);
                            @ViewBag.TodayTotal = data.Sum(x => x.Todays_count);

                            //return View();
                            return PartialView("_HouseDataEntryPartial");

                        }
                        else
                        {
                            return Json(new { ErrorMessage = "Please Try Again Later" });
                        }
                    }
                    else
                    {
                        return Json(new { ErrorMessage = "Please Try Again Later" });
                    }

                }



            }
            catch (Exception ex)
            {

                return Json(new { ErrorMessage = ex.Message.ToString() });

            }
        }

        public IActionResult DataEntryLiquid()
        {
            return View();
        }

        public IActionResult LiquidDataEntry(string Appid)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_context.Database.GetDbConnection().ConnectionString))
                {
                    connection.Open();

                    var command = connection.CreateCommand();
                    _context.Database.SetCommandTimeout(TimeSpan.FromMinutes(30));

                    const string CheckIfTableExistsStatement = "SELECT * FROM sys.objects WHERE name = N'LiquidEntryCount'";
                    command.CommandText = CheckIfTableExistsStatement;
                    var executeScalar = command.ExecuteScalar();
                    if (executeScalar != null)
                    {
                        int NAppId = Convert.ToInt32(Appid);
                        List<SqlParameter> parms = new List<SqlParameter>
                        {
                        // Create parameter(s)
                        new SqlParameter { ParameterName = "@Nappid", Value = NAppId },

                        };

                        var data = _context.HouseEntryCount.FromSqlRaw("LiquidEntryCount @Nappid", parms.ToArray()).ToList();

                        if (data != null)
                        {
                            @ViewBag.data = data;
                            @ViewBag.TotalCount = data.Sum(x => x.total_count);
                            @ViewBag.UpdateCount = data.Sum(x => x.updated_count);
                            @ViewBag.Count = data.Sum(x => x._count);
                            @ViewBag.TodayTotal = data.Sum(x => x.Todays_count);

                            //return View();
                            return PartialView("_LiquidDataEntryPartial");

                        }
                        else
                        {
                            return Json(new { ErrorMessage = "Please Try Again Later" });
                        }
                    }
                    else
                    {
                        return Json(new { ErrorMessage = "Please Try Again Later" });
                    }

                }



            }
            catch (Exception ex)
            {

                return Json(new { ErrorMessage = ex.Message.ToString() });

            }
        }

        public IActionResult DataEntryStreet()
        {
            return View();
        }

        public IActionResult StreetDataEntry(string Appid)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_context.Database.GetDbConnection().ConnectionString))
                {
                    connection.Open();

                    var command = connection.CreateCommand();
                    _context.Database.SetCommandTimeout(TimeSpan.FromMinutes(30));

                    const string CheckIfTableExistsStatement = "SELECT * FROM sys.objects WHERE name = N'StreetEntryCount'";
                    command.CommandText = CheckIfTableExistsStatement;
                    var executeScalar = command.ExecuteScalar();
                    if (executeScalar != null)
                    {
                        int NAppId = Convert.ToInt32(Appid);
                        List<SqlParameter> parms = new List<SqlParameter>
                        {
                        // Create parameter(s)
                        new SqlParameter { ParameterName = "@Nappid", Value = NAppId },

                        };

                        var data = _context.HouseEntryCount.FromSqlRaw("StreetEntryCount @Nappid", parms.ToArray()).ToList();

                        if (data != null)
                        {
                            @ViewBag.data = data;
                            @ViewBag.TotalCount = data.Sum(x => x.total_count);
                            @ViewBag.UpdateCount = data.Sum(x => x.updated_count);
                            @ViewBag.Count = data.Sum(x => x._count);
                            @ViewBag.TodayTotal = data.Sum(x => x.Todays_count);

                            //return View();
                            return PartialView("_StreetDataEntryPartial");

                        }
                        else
                        {
                            return Json(new { ErrorMessage = "Please Try Again Later" });
                        }
                    }
                    else
                    {
                        return Json(new { ErrorMessage = "Please Try Again Later" });
                    }

                }



            }
            catch (Exception ex)
            {

                return Json(new { ErrorMessage = ex.Message.ToString() });

            }
        }

        public IActionResult DataEntryDumpYard()
        {
            return View();
        }

        public IActionResult DumpYardDataEntry(string Appid)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_context.Database.GetDbConnection().ConnectionString))
                {
                    connection.Open();

                    var command = connection.CreateCommand();
                    _context.Database.SetCommandTimeout(TimeSpan.FromMinutes(30));

                    const string CheckIfTableExistsStatement = "SELECT * FROM sys.objects WHERE name = N'DumpYardEntryCount'";
                    command.CommandText = CheckIfTableExistsStatement;
                    var executeScalar = command.ExecuteScalar();
                    if (executeScalar != null)
                    {
                        int NAppId = Convert.ToInt32(Appid);
                        List<SqlParameter> parms = new List<SqlParameter>
                        {
                        // Create parameter(s)
                        new SqlParameter { ParameterName = "@Nappid", Value = NAppId },

                        };

                        var data = _context.HouseEntryCount.FromSqlRaw("DumpYardEntryCount @Nappid", parms.ToArray()).ToList();

                        if (data != null)
                        {
                            @ViewBag.data = data;
                            @ViewBag.TotalCount = data.Sum(x => x.total_count);
                            @ViewBag.UpdateCount = data.Sum(x => x.updated_count);
                            @ViewBag.Count = data.Sum(x => x._count);
                            @ViewBag.TodayTotal = data.Sum(x => x.Todays_count);

                            //return View();
                            return PartialView("_DumpYardDataEntryPartial");

                        }
                        else
                        {
                            return Json(new { ErrorMessage = "Please Try Again Later" });
                        }
                    }
                    else
                    {
                        return Json(new { ErrorMessage = "Please Try Again Later" });
                    }

                }



            }
            catch (Exception ex)
            {

                return Json(new { ErrorMessage = ex.Message.ToString() });

            }
        }
    }
}

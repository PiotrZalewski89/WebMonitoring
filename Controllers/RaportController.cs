using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMonitoring.Models;

namespace WebMonitoring.Controllers
{
    public class RaportController : Controller
    {
        private IDbSetLine context { get; set; }
        private DateTime dateTime { get; set; }

        public RaportController(IDbSetLine ctx)
        {
            context = ctx;
            dateTime = DateTime.Now;
        }

        [HttpGet]
        public IActionResult Daily()
        {
            DailyRaport dailyRaport = new DailyRaport();

            dailyRaport.GetDailyRaport(dateTime);

            dailyRaport.DateTime = dateTime;

            ViewBag.TitleNavBar = "Daily raport";

            return View(nameof(Daily), dailyRaport);
        }

        [HttpPost]
        public IActionResult Daily(DailyRaport daily)
        {
            dateTime = daily.DateTime;
            DailyRaport dailyRaport = new DailyRaport();

            ViewBag.TitleNavBar = "Daily raport";

            dailyRaport.GetDailyRaport(dateTime);
            dailyRaport.DateTime = dateTime;
            return View(dailyRaport);
        }

        [HttpGet]
        public IActionResult TSQ()
        {
            TSQ dailyRaport = new TSQ();

            dailyRaport.GetDailyRaport(dateTime);

            dailyRaport.DateTime = dateTime;

            ViewBag.TitleNavBar = "TSQ";

            return View(nameof(TSQ), dailyRaport);
        }

        [HttpPost]
        public IActionResult TSQ(DailyRaport daily)
        {
            dateTime = daily.DateTime;
            TSQ dailyRaport = new TSQ();

            ViewBag.TitleNavBar = "TSQ";

            dailyRaport.GetDailyRaport(dateTime);
            dailyRaport.DateTime = dateTime;
            return View(dailyRaport);
        }

        [HttpGet]
        public void ExcelFile(DateTime dateTime)
        {
            TSQ dailyRaport = new TSQ();

            ViewBag.TitleNavBar = "TSQ";

            dailyRaport.GetDailyRaport(dateTime);
            dailyRaport.DateTime = dateTime;

            ExcelFile excelFile = new ExcelFile();

            excelFile.InsertCellEPPlus(dateTime, dailyRaport);

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.Components;
using WebMonitoring.DataBase;
using WebMonitoring.Models;

namespace WebMonitoring.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IDbSetLine _dbSetStorageStation;
        //private LineParameters _lineParameters { get; set; }

        public HomeController(IDbSetLine dbSetStorageStation)
        {
            _dbSetStorageStation = dbSetStorageStation;
        }

        public IActionResult Index()
        {
            ViewBag.TitleNavBar = "Strona główna";

            return View();
        }


        //[HttpPost]
        //public IActionResult TotalPartsForm(LineParameters lineParameters)
        //{
        //    string urlAction = lineParameters.Url.ReturnAction + "_";
        //    string urlControler = lineParameters.Url.ReturnController;


        //    return RedirectToAction(urlAction, urlControler, lineParameters);
        //}



        //[HttpPost]
        //public IActionResult RedirectToLine(LineParameters line)
        //{
        //    //int removeChart = lineParameters.Url.ReturnAction.LastIndexOf('_');
        //    //string urlLine = lineParameters.Url.ReturnAction.Remove(removeChart);
        //    string urlAction = line.Url.ReturnAction;
        //    string urlControler = line.Url.ReturnController;
        //    return RedirectToActionPermanent(urlAction, urlControler, line.ActualTotalParts);
        //}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.Models;

namespace WebMonitoring.Controllers
{
    public class LineWS6Controller : Controller
    {
        string[] Desctription = new string[]
        {
             "Linia WS6 CNH 529"
        };

        private LineParametersWS _lineParameters { get; set;
        }
        public LineWS6Controller(LineParametersWS lineParameters)
        {
            _lineParameters = lineParameters;

            _lineParameters.Url.ReturnController = "LineWS6";
        }

        [HttpGet]
        public IActionResult LineWS6()
        {
            _lineParameters.Url.ReturnAction = nameof(LineWS6);
            ViewBag.TitleNavBar = Desctription[0];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineWS6(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                _lineParameters = line;
                ViewBag.TitleNavBar = Desctription[0];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }      
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.Models;

namespace WebMonitoring.Controllers
{
    public class LineWS5Controller : Controller
    {
        string[] Desctription = new string[]
        {
             "Linia WS5 CNH 537"
        };

        private LineParametersWS _lineParameters { get; set;
        }
        public LineWS5Controller(LineParametersWS lineParameters)
        {
            _lineParameters = lineParameters;

            _lineParameters.Url.ReturnController = "LineWS5";
        }

        [HttpGet]
        public IActionResult LineWS5()
        {
            _lineParameters.Url.ReturnAction = nameof(LineWS5);
            ViewBag.TitleNavBar = Desctription[0];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineWS5(LineParametersWS line)
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

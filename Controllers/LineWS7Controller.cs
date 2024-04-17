using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMonitoring.Models;

namespace WebMonitoring.Controllers
{
    public class LineWS7Controller:Controller
    {

        string[] Desctription = new string[]
       {
             "Linia WS7 CNH 537"
       };

        private LineParametersWS _lineParameters
        {
            get; set;
        }
        public LineWS7Controller(LineParametersWS lineParameters)
        {
            _lineParameters = lineParameters;

            _lineParameters.Url.ReturnController = "LineWS7";
        }

        [HttpGet]
        public IActionResult LineWS7()
        {
            _lineParameters.Url.ReturnAction = nameof(LineWS7);
            ViewBag.TitleNavBar = Desctription[0];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineWS7(LineParametersWS line)
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

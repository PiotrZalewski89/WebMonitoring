using Microsoft.AspNetCore.Mvc;
using WebMonitoring.Models;

namespace WebMonitoring.Controllers
{
    public class LineWS4Controller : Controller
    {
        string[] Desctription = new string[]
        {
             "Linia WS4 Mercedes M260A - 8h",
             "Linia WS4 Mercedes M260A - 12h"
        };

        private LineParametersWS _lineParameters { get; set;
        }
        public LineWS4Controller(LineParametersWS lineParameters)
        {
            _lineParameters = lineParameters;

            _lineParameters.Url.ReturnController = "LineWS4";
        }

        [HttpGet]
        public IActionResult LineWS4M260()
        {
            DbSetLineWS4M260.Line = LineDescription.LineWS4M260;

            _lineParameters.Url.ReturnAction = nameof(LineWS4M260);
            ViewBag.TitleNavBar = Desctription[0];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineWS4M260(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                DbSetLineWS4M260.Line = LineDescription.LineWS4M260;

                _lineParameters = line;
                ViewBag.TitleNavBar = Desctription[0];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public IActionResult LineWS4M26012h()
        {
            DbSetLineWS4M260.Line = LineDescription.LineWS4M260;
            _lineParameters.TrybPracy12h = true;
            _lineParameters.Url.ReturnAction = nameof(LineWS4M26012h);
            ViewBag.TitleNavBar = Desctription[1];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineWS4M26012h(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                DbSetLineWS4M260.Line = LineDescription.LineWS4M260;

                _lineParameters = line;
                _lineParameters.TrybPracy12h = true;
                ViewBag.TitleNavBar = Desctription[1];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }
    }
}

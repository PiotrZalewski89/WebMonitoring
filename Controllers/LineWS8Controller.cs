using Microsoft.AspNetCore.Mvc;
using WebMonitoring.Models;

namespace WebMonitoring.Controllers
{
    public class LineWS8Controller : Controller
    {
        string[] Desctription = new string[]
        {
            "",
             "Linia WS8 BR10 BJA - 8h",
             "Linia WS8 BR10 GPF - 8h",
             "Linia WS8 BR10 BJA - 12h",
             "Linia WS8 BR10 GPF - 12h"
        };

        private LineParametersWS _lineParameters
        {
            get; set;
        }
        public LineWS8Controller(LineParametersWS lineParameters)
        {
            _lineParameters = lineParameters;

            _lineParameters.Url.ReturnController = "LineWS8";
        }
               
        [HttpGet]
        public IActionResult LineWS8_BR10BJA()
        {
            DbSetLineWS8.Line = LineDescription.LineWS8_BJA;

            _lineParameters.Url.ReturnAction = nameof(LineWS8_BR10BJA);
            ViewBag.TitleNavBar = Desctription[1];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineWS8_BR10BJA(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                DbSetLineWS8.Line = LineDescription.LineWS8_BJA;

                _lineParameters = line;
                ViewBag.TitleNavBar = Desctription[1];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public IActionResult LineWS8_BR10BJA12h()
        {
            DbSetLineWS8.Line = LineDescription.LineWS8_BJA;
            _lineParameters.TrybPracy12h = true;
            _lineParameters.Url.ReturnAction = nameof(LineWS8_BR10BJA12h);
            ViewBag.TitleNavBar = Desctription[3];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineWS8_BR10BJA12h(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                DbSetLineWS8.Line = LineDescription.LineWS8_BJA;

                _lineParameters = line;
                _lineParameters.TrybPracy12h = true;
                ViewBag.TitleNavBar = Desctription[3];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public IActionResult LineWS8_BR10GPF()
        {
            DbSetLineWS8.Line = LineDescription.LineWS8_GPF;

            _lineParameters.Url.ReturnAction = nameof(LineWS8_BR10GPF);
            ViewBag.TitleNavBar = Desctription[2];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineWS8_BR10GPF(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                DbSetLineWS8.Line = LineDescription.LineWS8_GPF;

                _lineParameters = line;
                ViewBag.TitleNavBar = Desctription[2];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public IActionResult LineWS8_BR10GPF12h()
        {
            DbSetLineWS8.Line = LineDescription.LineWS8_GPF;
            _lineParameters.TrybPracy12h = true;
            _lineParameters.Url.ReturnAction = nameof(LineWS8_BR10GPF12h);
            ViewBag.TitleNavBar = Desctription[4];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineWS8_BR10GPF12h(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                DbSetLineWS8.Line = LineDescription.LineWS8_GPF;

                _lineParameters = line;
                _lineParameters.TrybPracy12h = true;
                ViewBag.TitleNavBar = Desctription[4];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }
    }
}

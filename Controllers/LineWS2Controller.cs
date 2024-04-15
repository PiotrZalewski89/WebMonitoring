using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.Models;

namespace WebMonitoring.Controllers
{
    public class LineWS2Controller : Controller
    {
        string[] Desctription = new string[]
        {
             "Linia WS2",
             "Linia WS2B BR10 BJA - 8h",
             "Linia WS2B BR10 GPF - 8h",
             "Linia WS2B BR10 BJA - 12h",
             "Linia WS2B BR10 GPF - 12h"
        };

        private LineParametersWS _lineParameters { get; set;
        }
        public LineWS2Controller(LineParametersWS lineParameters)
        {
            _lineParameters = lineParameters;

            _lineParameters.Url.ReturnController = "LineWS2";
        }

        [HttpGet]
        public IActionResult LineWS2()
        {
            _lineParameters.Url.ReturnAction = nameof(LineWS2);
            ViewBag.TitleNavBar = Desctription[0];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineWS2(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                _lineParameters = line;
                ViewBag.TitleNavBar = Desctription[0];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public IActionResult LineWS2B_BR10BJA()
        {
            DbSetLineWS2B.Line = LineDescription.LineWS2B_BJA;

            _lineParameters.Url.ReturnAction = nameof(LineWS2B_BR10BJA);
            ViewBag.TitleNavBar = Desctription[1];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineWS2B_BR10BJA(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                DbSetLineWS2B.Line = LineDescription.LineWS2B_BJA;

                _lineParameters = line;
                ViewBag.TitleNavBar = Desctription[1];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public IActionResult LineWS2B_BR10BJA12h()
        {
            DbSetLineWS2B.Line = LineDescription.LineWS2B_BJA;
            _lineParameters.TrybPracy12h = true;
            _lineParameters.Url.ReturnAction = nameof(LineWS2B_BR10BJA12h);
            ViewBag.TitleNavBar = Desctription[3];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineWS2B_BR10BJA12h(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                DbSetLineWS2B.Line = LineDescription.LineWS2B_BJA;

                _lineParameters = line;
                _lineParameters.TrybPracy12h = true;
                ViewBag.TitleNavBar = Desctription[3];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public IActionResult LineWS2B_BR10GPF()
        {
            DbSetLineWS2B.Line = LineDescription.LineWS2B_GPF;

            _lineParameters.Url.ReturnAction = nameof(LineWS2B_BR10GPF);
            ViewBag.TitleNavBar = Desctription[2];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineWS2B_BR10GPF(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                DbSetLineWS2B.Line = LineDescription.LineWS2B_GPF;

                _lineParameters = line;
                ViewBag.TitleNavBar = Desctription[2];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public IActionResult LineWS2B_BR10GPF12h()
        {
            DbSetLineWS2B.Line = LineDescription.LineWS2B_GPF;
            _lineParameters.TrybPracy12h = true;
            _lineParameters.Url.ReturnAction = nameof(LineWS2B_BR10GPF12h);
            ViewBag.TitleNavBar = Desctription[4];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineWS2B_BR10GPF12h(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                DbSetLineWS2B.Line = LineDescription.LineWS2B_GPF;

                _lineParameters = line;
                _lineParameters.TrybPracy12h = true;
                ViewBag.TitleNavBar = Desctription[4];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }
    }
}

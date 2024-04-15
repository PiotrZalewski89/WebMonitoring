using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.Models;

namespace WebMonitoring.Controllers
{
    public class LineWS3Controller : Controller
    {
        string[] Desctription = new string[]
        {
             "Linia WS3A",
             "Linia WS3B LP1",
             "Linia WS3B LP2",
             "Linia WS3B LP3"
        };

        private LineParametersWS _lineParameters { get; set;
        }
        public LineWS3Controller(LineParametersWS lineParameters)
        {
            _lineParameters = lineParameters;

            _lineParameters.Url.ReturnController = "LineWS3";
        }

        [HttpGet]
        public IActionResult LineWS3A()
        {
            _lineParameters.Url.ReturnAction = nameof(LineWS3A);
            ViewBag.TitleNavBar = Desctription[0];
            return View(_lineParameters);
        }        

        [HttpGet]
        public IActionResult LineWS3BLP1()
        {
            _lineParameters.Url.ReturnAction = nameof(LineWS3BLP1);
            ViewBag.TitleNavBar = Desctription[1];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineWS3BLP1(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                _lineParameters = line;
                ViewBag.TitleNavBar = Desctription[1];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public IActionResult LineWS3BLP2()
        {
            _lineParameters.Url.ReturnAction = nameof(LineWS3BLP2);
            ViewBag.TitleNavBar = Desctription[2];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineWS3BLP2(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                _lineParameters = line;
                ViewBag.TitleNavBar = Desctription[2];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public IActionResult LineWS3BLP3()
        {
            _lineParameters.Url.ReturnAction = nameof(LineWS3BLP3);
            ViewBag.TitleNavBar = Desctription[3];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineWS3BLP3(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                _lineParameters = line;
                ViewBag.TitleNavBar = Desctription[3];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }

    }
}

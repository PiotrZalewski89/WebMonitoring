using Microsoft.AspNetCore.Mvc;
using WebMonitoring.Models;

namespace WebMonitoring.Controllers
{
    public class LineWS1Controller : Controller
    {
        string[] Desctription = new string[]
        {
             "Linia WS1 CNH",
             "Linia WS1 V50"
        };

        private LineParametersWS _lineParameters { get; set;
        }
        public LineWS1Controller(LineParametersWS lineParameters)
        {
            _lineParameters = lineParameters;

            _lineParameters.Url.ReturnController = "LineWS1";
        }

        [HttpGet]
        public IActionResult LineWS1CNH()
        {
            _lineParameters.Url.ReturnAction = nameof(LineWS1CNH);
            ViewBag.TitleNavBar = Desctription[0];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineWS1CNH(LineParametersWS line)
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
        public IActionResult LineWS1V50()
        {
            _lineParameters.Url.ReturnAction = nameof(LineWS1V50);
            ViewBag.TitleNavBar = Desctription[1];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineWS1V50(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                _lineParameters = line;
                ViewBag.TitleNavBar = Desctription[1];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }        
    }
}

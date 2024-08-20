using Microsoft.AspNetCore.Mvc;
using WebMonitoring.Models;

namespace WebMonitoring.Controllers
{
    public class LineWS2Controller : Controller
    {
        string[] Desctription = new string[]
        {
             "Linia WS2 - HR16",
             "Linia WS2 - HR18"
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
        public IActionResult LineWS2_HR18()
        {
            _lineParameters.Url.ReturnAction = nameof(LineWS2_HR18);
            ViewBag.TitleNavBar = Desctription[1];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineWS2_HR18(LineParametersWS line)
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

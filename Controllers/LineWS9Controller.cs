using Microsoft.AspNetCore.Mvc;
using WebMonitoring.Models;

namespace WebMonitoring.Controllers
{
    public class LineWS9Controller : Controller
    {
        string[] Desctription = new string[]
        {
            "",
             "Linia WS9"
        };

        private LineParametersWS _lineParameters
        {
            get; set;
        }
        public LineWS9Controller(LineParametersWS lineParameters)
        {
            _lineParameters = lineParameters;

            _lineParameters.Url.ReturnController = "LineWS9";
        }
               
        [HttpGet]
        public IActionResult LineWS9()
        {
            _lineParameters.Url.ReturnAction = nameof(LineWS9);
            ViewBag.TitleNavBar = Desctription[1];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineWS9(LineParametersWS line)
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

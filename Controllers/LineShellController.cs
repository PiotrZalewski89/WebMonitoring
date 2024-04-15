using Microsoft.AspNetCore.Mvc;
using WebMonitoring.Models;

namespace WebMonitoring.Controllers
{
    public class LineShellController : Controller
    {
        string[] Desctription = new string[]
        {
             "Linia Weil"
        };

        private LineParametersWS _lineParameters { get; set;
        }
        public LineShellController(LineParametersWS lineParameters)
        {
            _lineParameters = lineParameters;

            _lineParameters.Url.ReturnController = "LineShell";
        }

        [HttpGet]
        public IActionResult LineWeil()
        {
            _lineParameters.Url.ReturnAction = nameof(LineWeil);
            ViewBag.TitleNavBar = Desctription[0];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineWeil(LineParametersWS line)
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

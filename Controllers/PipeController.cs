using Microsoft.AspNetCore.Mvc;
using WebMonitoring.Models;

namespace WebMonitoring.Controllers
{
    public class PipeController : Controller
    {
        private string[] Desctription = new string[]
        {
             "SDF",
             "NGC"
         };

        private LineParametersWS _lineParameters { get; set; }

        public PipeController(LineParametersWS lineParameters)
        {
            _lineParameters = lineParameters;

            _lineParameters.Url.ReturnController = "Pipe";
        }

        [HttpGet]
        public IActionResult LineSDF()
        {
            _lineParameters.Url.ReturnAction = nameof(LineSDF);
            ViewBag.TitleNavBar = Desctription[0];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineSDF(LineParametersWS line)
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

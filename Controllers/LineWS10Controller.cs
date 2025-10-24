using Microsoft.AspNetCore.Mvc;
using WebMonitoring.Models;

namespace WebMonitoring.Controllers
{
    public class LineWS10Controller : Controller
    {
        string[] Desctription = new string[]
        {
            "",
             "Linia WS10 - Porsche",
              "Linia WS10 - Porsche 976.119.213.F",
            "Linia WS10 - Porsche 976.119.213.G",
            "Linia WS10 - Porsche 976.119.213.H",
            "Linia WS10 - Porsche 976.119.213.J",
            "Linia WS10 - Porsche 976.119.213.K",
            "Linia WS10 - Porsche 976.119.364.G",
            "Linia WS10 - Porsche 976.119.364.H",
            "Linia WS10 - Porsche 976.119.368.C",
            "Linia WS10 - Porsche 976.119.369.E",
            "Linia WS10 - Porsche 976.119.520.E",
            "Linia WS10 - Porsche 976.119.535.B",
            "Linia WS10 - Porsche 976.119.714.D",
        };

        private LineParametersWS _lineParameters
        {
            get; set;
        }
        public LineWS10Controller(LineParametersWS lineParameters)
        {
            _lineParameters = lineParameters;

            _lineParameters.Url.ReturnController = Desctription[1];
        }
               
        [HttpGet]
        public IActionResult LineWS10()
        {
            _lineParameters.Url.ReturnAction = nameof(LineWS10);
            _lineParameters.Url.ReturnController = nameof(LineWS10);
            ViewBag.TitleNavBar = Desctription[1];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult LineWS10(LineParametersWS line)
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
        public IActionResult PN_976_119_213_F()
        {
            _lineParameters.Url.ReturnAction = nameof(PN_976_119_213_F);
            _lineParameters.Url.ReturnController = nameof(LineWS10);
            ViewBag.TitleNavBar = Desctription[2];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult PN_976_119_213_F(LineParametersWS line)
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
        public IActionResult PN_976_119_213_G()
        {
            _lineParameters.Url.ReturnAction = nameof(PN_976_119_213_G);
            _lineParameters.Url.ReturnController = nameof(LineWS10);
            ViewBag.TitleNavBar = Desctription[3];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult PN_976_119_213_G(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                _lineParameters = line;
                ViewBag.TitleNavBar = Desctription[3];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public IActionResult PN_976_119_213_H()
        {
            _lineParameters.Url.ReturnAction = nameof(PN_976_119_213_H);
            _lineParameters.Url.ReturnController = nameof(LineWS10);
            ViewBag.TitleNavBar = Desctription[4];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult PN_976_119_213_H(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                _lineParameters = line;
                ViewBag.TitleNavBar = Desctription[4];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public IActionResult PN_976_119_213_J()
        {
            _lineParameters.Url.ReturnAction = nameof(PN_976_119_213_J);
            _lineParameters.Url.ReturnController = nameof(LineWS10);
            ViewBag.TitleNavBar = Desctription[5];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult PN_976_119_213_J(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                _lineParameters = line;
                ViewBag.TitleNavBar = Desctription[5];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public IActionResult PN_976_119_213_K()
        {
            _lineParameters.Url.ReturnAction = nameof(PN_976_119_213_K);
            _lineParameters.Url.ReturnController = nameof(LineWS10);
            ViewBag.TitleNavBar = Desctription[6];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult PN_976_119_213_K(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                _lineParameters = line;
                ViewBag.TitleNavBar = Desctription[6];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public IActionResult PN_976_119_364_G()
        {
            _lineParameters.Url.ReturnAction = nameof(PN_976_119_364_G);
            _lineParameters.Url.ReturnController = nameof(LineWS10);
            ViewBag.TitleNavBar = Desctription[7];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult PN_976_119_364_G(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                _lineParameters = line;
                ViewBag.TitleNavBar = Desctription[7];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public IActionResult PN_976_119_364_H()
        {
            _lineParameters.Url.ReturnAction = nameof(PN_976_119_364_H);
            _lineParameters.Url.ReturnController = nameof(LineWS10);
            ViewBag.TitleNavBar = Desctription[8];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult PN_976_119_364_H(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                _lineParameters = line;
                ViewBag.TitleNavBar = Desctription[8];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public IActionResult PN_976_119_368_C()
        {
            _lineParameters.Url.ReturnAction = nameof(PN_976_119_368_C);
            _lineParameters.Url.ReturnController = nameof(LineWS10);
            ViewBag.TitleNavBar = Desctription[9];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult PN_976_119_368_C(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                _lineParameters = line;
                ViewBag.TitleNavBar = Desctription[9];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public IActionResult PN_976_119_369_E()
        {
            _lineParameters.Url.ReturnAction = nameof(PN_976_119_369_E);
            _lineParameters.Url.ReturnController = nameof(LineWS10);
            ViewBag.TitleNavBar = Desctription[10];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult PN_976_119_369_E(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                _lineParameters = line;
                ViewBag.TitleNavBar = Desctription[10];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public IActionResult PN_976_119_520_E()
        {
            _lineParameters.Url.ReturnAction = nameof(PN_976_119_520_E);
            _lineParameters.Url.ReturnController = nameof(LineWS10);
            ViewBag.TitleNavBar = Desctription[11];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult PN_976_119_520_E(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                _lineParameters = line;
                ViewBag.TitleNavBar = Desctription[11];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public IActionResult PN_976_119_535_B()
        {
            _lineParameters.Url.ReturnAction = nameof(PN_976_119_535_B);
            _lineParameters.Url.ReturnController = nameof(LineWS10);
            ViewBag.TitleNavBar = Desctription[12];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult PN_976_119_535_B(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                _lineParameters = line;
                ViewBag.TitleNavBar = Desctription[12];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public IActionResult PN_976_119_714_D()
        {
            _lineParameters.Url.ReturnAction = nameof(PN_976_119_714_D);
            _lineParameters.Url.ReturnController = nameof(LineWS10);
            ViewBag.TitleNavBar = Desctription[13];
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult PN_976_119_714_D(LineParametersWS line)
        {
            if (ModelState.IsValid)
            {
                _lineParameters = line;
                ViewBag.TitleNavBar = Desctription[13];
                return View(_lineParameters);
            }
            return BadRequest(ModelState);
        }
    }
}

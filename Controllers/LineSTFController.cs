using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.Models;

namespace WebMonitoring.Controllers
{
    public class LineSTFController : Controller
    {

        private LineParametersSTF _lineParameters { get; set;
        }
        public LineSTFController(LineParametersSTF lineParameters)
        {
            _lineParameters = lineParameters;

            _lineParameters.Url.ReturnController = nameof(LineSTF);
        }

        [HttpGet]
        public IActionResult LineSTF()
        {
            _lineParameters.Url.ReturnAction = nameof(LineSTF);
            _lineParameters.Url.TitleNavBar = "Linia STF";
            return View(_lineParameters);
        }

        [HttpPost]
        public IActionResult STF3HR16(LineParametersSTF line)
        {
            if (ModelState.IsValid)
            {
                DbSetLineSTF context = new DbSetLineSTF(new DataBase.StorageStationDbContext());

                context.SetTarget(LineDescription.LineSTF3 + " HR16", line.ActualTotalParts);
            }

            _lineParameters.ActualTotalParts = line.ActualTotalParts;
            _lineParameters.Url.ReturnAction = nameof(LineSTF);
            
            return RedirectToAction(_lineParameters.Url.ReturnAction, _lineParameters);
        }

        [HttpPost]
        public IActionResult STF4BR10BJA(LineParametersSTF line)
        {
            if (ModelState.IsValid)
            {
                DbSetLineSTF context = new DbSetLineSTF(new DataBase.StorageStationDbContext());

                context.SetTarget(LineDescription.LineSTF4 + " BR10 BJA", line.ActualTotalParts);
            }

            _lineParameters.ActualTotalParts = line.ActualTotalParts;
            _lineParameters.Url.ReturnAction = nameof(LineSTF);
            return RedirectToAction(_lineParameters.Url.ReturnAction, _lineParameters);
        }


        [HttpPost]
        public IActionResult STF4BR10GPF(LineParametersSTF line)
        {
            if (ModelState.IsValid)
            {
                DbSetLineSTF context = new DbSetLineSTF(new DataBase.StorageStationDbContext());

                context.SetTarget(LineDescription.LineSTF4 + " BR10 GPF", line.ActualTotalParts);
            }

            _lineParameters.ActualTotalParts = line.ActualTotalParts;
            _lineParameters.Url.ReturnAction = nameof(LineSTF);
            return RedirectToAction(_lineParameters.Url.ReturnAction, _lineParameters);
        }

        [HttpPost]
        public IActionResult STF4HR10(LineParametersSTF line)
        {
            if (ModelState.IsValid)
            {
                DbSetLineSTF context = new DbSetLineSTF(new DataBase.StorageStationDbContext());

                context.SetTarget(LineDescription.LineSTF4 + " HR10", line.ActualTotalParts);
            }

            _lineParameters.ActualTotalParts = line.ActualTotalParts;
            _lineParameters.Url.ReturnAction = nameof(LineSTF);
            return RedirectToAction(_lineParameters.Url.ReturnAction, _lineParameters);
        }

        [HttpPost]
        public IActionResult STF5HR10(LineParametersSTF line)
        {
            if (ModelState.IsValid)
            {
                DbSetLineSTF context = new DbSetLineSTF(new DataBase.StorageStationDbContext());

                context.SetTarget(LineDescription.LineSTF5 + " HR10", line.ActualTotalParts);
            }

            _lineParameters.ActualTotalParts = line.ActualTotalParts;
            _lineParameters.Url.ReturnAction = nameof(LineSTF);
            return RedirectToAction(_lineParameters.Url.ReturnAction, _lineParameters);
        }

        [HttpPost]
        public IActionResult STF6HR16(LineParametersSTF line)
        {
            if (ModelState.IsValid)
            {
                DbSetLineSTF context = new DbSetLineSTF(new DataBase.StorageStationDbContext());

                context.SetTarget(LineDescription.LineSTF6 + " HR16", line.ActualTotalParts);
            }

            _lineParameters.ActualTotalParts = line.ActualTotalParts;
            _lineParameters.Url.ReturnAction = nameof(LineSTF);
            return RedirectToAction(_lineParameters.Url.ReturnAction, _lineParameters);
        }

        [HttpPost]
        public IActionResult STF6HR10(LineParametersSTF line)
        {
            if (ModelState.IsValid)
            {
                DbSetLineSTF context = new DbSetLineSTF(new DataBase.StorageStationDbContext());

                context.SetTarget(LineDescription.LineSTF6 + " HR10", line.ActualTotalParts);
            }

            _lineParameters.ActualTotalParts = line.ActualTotalParts;
            _lineParameters.Url.ReturnAction = nameof(LineSTF);
            return RedirectToAction(_lineParameters.Url.ReturnAction, _lineParameters);
        }
    }
}

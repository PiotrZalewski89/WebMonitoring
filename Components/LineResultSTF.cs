using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.Models;

namespace WebMonitoring.Components
{
    public class LineResultSTF : ViewComponent
    {
        private DbSetLineSTF _DbSetLineSTF { get; set; }

        public LineResultSTF(DbSetLineSTF db)
        {
            _DbSetLineSTF = db;
        }

        public IViewComponentResult Invoke(LineParametersSTF _LineParameters)
        {
            var dateTime = DateTime.Now;//DateTime.Parse("06.05.2022 06:00:00"); //DateTime.Parse("19.05.2022 06:00:00");
            dateTime = dateTime.SetTimeForShift();

            _DbSetLineSTF.GetProductionCountPerHourSTF(dateTime);

            _LineParameters.SetValues(_DbSetLineSTF);

            return View(_LineParameters);
        }
    }
}

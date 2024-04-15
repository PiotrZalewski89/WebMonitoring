using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.Models;

namespace WebMonitoring.Components
{
    public class ChartBar : ViewComponent
    {
        private IDbSetLine _DbSetLine { get; set; }
        private WeeklyProduction _WeeklyProduction { get; set; }

        public ChartBar(IDbSetLine db)
        {
            _DbSetLine = db;
        }

        public IViewComponentResult Invoke(string selectLine)
        {
            _WeeklyProduction = new WeeklyProduction();

            ////if (selectLine == LineDescription.LineWS3BLP1)
            ////    line = LineDescription.LineWS3BLP1.Insert(4, " ");
            ////else if (selectLine == LineDescription.LineWS3BLP2)
            ////    line = LineDescription.LineWS3BLP2.Insert(4, " ");
            ////else if (selectLine == LineDescription.LineWS4BJA || selectLine == LineDescription.LineWS4GPF)
            ////    line = LineDescription.LineWS4BJA.Substring(0, 3);
            ////else
            ////    line = selectLine;

            //_WeeklyProduction.Description = selectLine;
            //_WeeklyProduction.SetValues(_DbSetLine.GetSumWeeklyProduction(selectLine));    
            //_WeeklyProduction.Target = _DbSetLine.GetTargetForProduction(selectLine, DateTime.Now);
            //_WeeklyProduction.ActiveShifts = _DbSetLine.GetSumWeeklyActiveShifts(selectLine);

            _WeeklyProduction = _WeeklyProduction.Production(selectLine);

            return View(_WeeklyProduction);
        }

        //public WeeklyProduction Production(string line)
        //{
        //    line = line.Contains("Line") ? line : "Line" + line;

        //    WeeklyProduction weeklyProduction = new WeeklyProduction();
        //    weeklyProduction.Description = line;
        //    weeklyProduction.SetValues(_DbSetLine.GetSumWeeklyProduction(line));
        //    weeklyProduction.Target = _DbSetLine.GetTargetForProduction(line, DateTime.Now);
        //    weeklyProduction.ActiveShifts = _DbSetLine.GetSumWeeklyActiveShifts(line);

        //    return weeklyProduction;
        //}
    }
}

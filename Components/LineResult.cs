using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WebMonitoring.Models;

namespace WebMonitoring.Components
{
    public class LineResult : ViewComponent
    {
       // private LineParameters _LineParameters { get; set; }
        private IDbSetLine _DbSetLine { get; set; }
        public LineResult(IDbSetLine db/*, LineParameters line*/)
        {
            _DbSetLine = db;
           // _LineParameters = line;
        }

        public IViewComponentResult Invoke(string selectLine, LineParametersWS _LineParameters, bool tryb12h = false)
        {

            var dateTime = DateTime.Now; //DateTime.Parse("06.05.2022 06:00:00"); //DateTime.Parse("19.05.2022 06:00:00");
            dateTime = dateTime.SetTimeForShift();

            if (selectLine == LineDescription.LineWS1CNH || selectLine == LineDescription.LineWS1V50)
            {
                _DbSetLine.GetProductionCountPerHourWS1(dateTime, selectLine);
            }
            else if (selectLine == LineDescription.LineWS2)
            {
                _DbSetLine.GetProductionCountPerHourWS2(dateTime);
            }
            else if (selectLine == LineDescription.LineWS3A)
            {
                _DbSetLine.GetProductionCountPerHourWS3(dateTime, LineDescription.LineWS3A);
            }
            else if (selectLine == LineDescription.LineWS3BLP1)
            {
                _DbSetLine.GetProductionCountPerHourWS3(dateTime, LineDescription.LineWS3BLP1);
            }
            else if (selectLine == LineDescription.LineWS3BLP2)
            {
                _DbSetLine.GetProductionCountPerHourWS3(dateTime, LineDescription.LineWS3BLP2);
            }
            else if (selectLine == LineDescription.LineWS3BLP3)
            {
                _DbSetLine.GetProductionCountPerHourWS3(dateTime, LineDescription.LineWS3BLP3);
            }
            else if (selectLine == LineDescription.LineWS2B_GPF)
            {
                _DbSetLine.GetProductionCountPerHourWS4(dateTime, LineDescription.LineWS2B_GPF, tryb12h);
            }
            else if (selectLine == LineDescription.LineWS2B_BJA)
            {
                _DbSetLine.GetProductionCountPerHourWS4(dateTime, LineDescription.LineWS2B_BJA, tryb12h);
            }
            else if (selectLine == LineDescription.LineWS4M260)
            {
                _DbSetLine.GetProductionCountPerHourWS4M260(dateTime, LineDescription.LineWS4M260, tryb12h);
            }
            else if (selectLine == LineDescription.LineWS5)
            {
                _DbSetLine.GetProductionCountPerHourWS5(dateTime, LineDescription.LineWS5);
            }
            else if (selectLine == LineDescription.LineWS6)
            {
                _DbSetLine.GetProductionCountPerHourWS6(dateTime, LineDescription.LineWS6);
            }
            else if (selectLine == LineDescription.LineWS7)
            {
                _DbSetLine.GetProductionCountPerHourWS6(dateTime, LineDescription.LineWS7);
            }
            else if (selectLine == LineDescription.LineWeil)
            {
                _DbSetLine.GetProductionCountPerHourWeil(dateTime, LineDescription.LineWeil);
            }

            //zapis do bazy odnosnie targetu
            if (_LineParameters.ActualTotalParts > 0 && _LineParameters.ActualTotalParts != _DbSetLine.Target)
                _DbSetLine.SetTarget(selectLine, _LineParameters.ActualTotalParts, tryb12h);

            _LineParameters.TrybPracy12h = tryb12h;
            _LineParameters.SetValues(selectLine, _DbSetLine.LineData, _LineParameters.ActualTotalParts > 0 ? _LineParameters.ActualTotalParts : _DbSetLine.Target);

            if (_LineParameters.ActualTotalParts == 0)
            {
                _LineParameters.ActualTotalParts = _DbSetLine.Target;
            }

            _LineParameters.TotalWeeklyProduction = _DbSetLine.GetSumWeeklyProduction(selectLine).Sum();

            return View(_LineParameters);
        }
    }
}

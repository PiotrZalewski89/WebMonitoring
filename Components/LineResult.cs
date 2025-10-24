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

        public IViewComponentResult Invoke(string selectLine, LineParametersWS _LineParameters, bool tryb12h = false, string partNumber = "")
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
            else if (selectLine == LineDescription.LineWS3Hr12CC)
            {
                _DbSetLine.GetProductionCountPerHourWS3Hr12CC(dateTime, LineDescription.LineWS3Hr12CC);
            }
            else if (selectLine == LineDescription.LineWS8_GPF)
            {
                _DbSetLine.GetProductionCountPerHourWS4(dateTime, LineDescription.LineWS8_GPF, tryb12h);
            }
            else if (selectLine == LineDescription.LineWS8_BJA)
            {
                _DbSetLine.GetProductionCountPerHourWS4(dateTime, LineDescription.LineWS8_BJA, tryb12h);
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
                _DbSetLine.GetProductionCountPerHourWS7(dateTime, LineDescription.LineWS7);
            }
            else if (selectLine == LineDescription.LineWeil)
            {
                _DbSetLine.GetProductionCountPerHourWeil(dateTime, LineDescription.LineWeil);
            }
            else if (selectLine == LineDescription.LineSDF)
            {
                _DbSetLine.GetProductionCountPerHourSdf(dateTime, LineDescription.LineSDF);
            }
            else if (selectLine == LineDescription.LineWS2HR18)
            {
                _DbSetLine.GetProductionCountPerHourWS2_HR18(dateTime);
            }
            else if (selectLine == LineDescription.LineWS9)
            {
                _DbSetLine.GetProductionCountPerHourWS9(dateTime);
            }
            else if (selectLine == LineDescription.LineWS10)
            {
                //"976.119.213.F"
                //"976.119.213.G"
                //"976.119.213.H"
                //"976.119.213.J"
                //"976.119.213.K"
                //"976.119.364.G"
                //"976.119.364.H"
                //"976.119.368.C"
                //"976.119.369.E"
                //"976.119.520.E"
                //"976.119.535.B"
                //"976.119.714.D"
                if (!string.IsNullOrEmpty(partNumber))
                    _DbSetLine.GetProductionCountPerHourWS10(dateTime, partNumber).Wait();
                else 
                    _DbSetLine.GetProductionCountPerHourWS10(dateTime).Wait();
            }

            //zapis do bazy odnosnie targetu
            if (_LineParameters.ActualTotalParts > 0 && _LineParameters.ActualTotalParts != _DbSetLine.Target)
                _DbSetLine.SetTarget(selectLine, _LineParameters.ActualTotalParts, tryb12h, partNumber);

            _LineParameters.TrybPracy12h = tryb12h;
            if (_DbSetLine.LineData is { })
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

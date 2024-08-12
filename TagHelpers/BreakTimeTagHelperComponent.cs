
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using WebMonitoring.Models;

namespace WebMonitoring.TagHelpers
{
    [HtmlTargetElement("div", Attributes = "line")]
    public class BreakTimeTagHelperComponent : TagHelper
    {
        private List<BreakTime> BreakTimes { get; set; } = new List<BreakTime>()
        {
            new BreakTime(LineDescription.LineWS1, 1, 10, 0, 11, 50),
            new BreakTime(LineDescription.LineWS1, 2, 18, 0, 19, 50),
            new BreakTime(LineDescription.LineWS1, 3, 2, 0, 3, 50),
            new BreakTime(LineDescription.LineWS2, 1, 10, 0, 11, 50),
            new BreakTime(LineDescription.LineWS2, 2, 18, 0, 19, 50),
            new BreakTime(LineDescription.LineWS2, 3, 2, 0, 3, 50),
            new BreakTime(LineDescription.LineWS3, 1, 9, 30, 11, 40),
            new BreakTime(LineDescription.LineWS3, 2, 17, 30, 19, 40),
            new BreakTime(LineDescription.LineWS3, 3, 1, 30, 3, 30),
            new BreakTime(LineDescription.LineWS4, 1, 10, 30, 12, 0),
            new BreakTime(LineDescription.LineWS4, 2, 10, 0, 20, 0),
            new BreakTime(LineDescription.LineWS4, 3, 2, 0, 4, 0),
            new BreakTime(LineDescription.LineWS5, 1, 10, 30, 11, 50),
            new BreakTime(LineDescription.LineWS5, 2, 10, 0, 19, 50),
            new BreakTime(LineDescription.LineWS5, 3, 2, 0, 3, 50),

            new BreakTime(LineDescription.LineWS7, 1, 10, 30, 11, 50),
            new BreakTime(LineDescription.LineWS7, 2, 10, 0, 19, 50),
            new BreakTime(LineDescription.LineWS7, 3, 2, 0, 3, 50),

            new BreakTime(LineDescription.LineWS6, 1, 10, 30, 11, 50),
            new BreakTime(LineDescription.LineWS6, 2, 10, 0, 19, 50),
            new BreakTime(LineDescription.LineWS6, 3, 2, 0, 3, 50),
            new BreakTime(LineDescription.LineWS4M260, 1, 10, 30, 12, 0),
            new BreakTime(LineDescription.LineWS4M260, 2, 10, 0, 20, 0),
            new BreakTime(LineDescription.LineWS4M260, 3, 2, 0, 4, 0),
            new BreakTime(LineDescription.LineWeil, 1, 10, 30, 12, 0),
            new BreakTime(LineDescription.LineWeil, 2, 10, 0, 20, 0),
            new BreakTime(LineDescription.LineWeil, 3, 2, 0, 4, 0),
            new BreakTime(LineDescription.LineWS8_BJA, 1, 10, 30, 12, 0),
            new BreakTime(LineDescription.LineWS8_BJA, 2, 10, 0, 20, 0),
            new BreakTime(LineDescription.LineWS8_BJA, 3, 2, 0, 4, 0),
            new BreakTime(LineDescription.LineWS8_GPF, 1, 10, 30, 12, 0),
            new BreakTime(LineDescription.LineWS8_GPF, 2, 10, 0, 20, 0),
            new BreakTime(LineDescription.LineWS8_GPF, 3, 2, 0, 4, 0),
             new BreakTime(LineDescription.LineSDF, 1, 10, 30, 11, 50),
            new BreakTime(LineDescription.LineSDF, 2, 10, 0, 19, 50),
            new BreakTime(LineDescription.LineSDF, 3, 2, 0, 3, 50)
        };

        private BreakTime BreakTime { get; set; }

        public string Line { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (output.TagName == "div")
            {
                if (Line == LineDescription.LineWS3BLP1
                    || Line == LineDescription.LineWS3BLP2
                    || Line == LineDescription.LineWS3BLP3
                    || Line == LineDescription.LineWS3A)
                    Line = LineDescription.LineWS3;
                else if (Line == LineDescription.LineWS1CNH
                    || Line == LineDescription.LineWS1V50)
                    Line = LineDescription.LineWS1;
                else if (Line == LineDescription.LineWS4 
                   || Line == LineDescription.LineWS4M260)
                    Line = LineDescription.LineWS4;
                else if (Line == LineDescription.LineWS8_BJA)
                    Line = LineDescription.LineWS8_BJA;
                else if (Line == LineDescription.LineWS8_GPF)
                    Line = LineDescription.LineWS8_GPF;
                else if (Line == LineDescription.LineWeil)
                    Line = LineDescription.LineWeil;

                BreakTime = GetBreakTime(Line);

                output.TagMode = TagMode.StartTagAndEndTag;

                TagBuilder main = new TagBuilder("img");

                main.Attributes.Add("id", "imgBreakTime");
                //main.Attributes.Add("src", @"/images/lunchTime.jpg");
                main.Attributes.Add("style", "height: 600px; width: 600px; border-radius:100px; position: absolute;");
                //main.Attributes.Add("hidden", "hidden");

                //main.InnerHtml.AppendHtml("id='imgBreakTime' src='~/images/lunchTime.jpg' style='height: 600px; width: 600px; border-radius:100px; position: absolute; ' hidden='hidden' ");

                TagBuilder script = new TagBuilder("script");
                script.InnerHtml.AppendHtml(
                @" $(document).ready(function () {
                    var element = $('#imgBreakTime');

                    var heightWin = window.innerHeight;
                    var widthWin = window.innerWidth;

                    var positionTop = (heightWin / 2 - 300).toString() + 'px';
                    var positionLeft = (widthWin / 2 - 300).toString() + 'px';

                    element.css('top', positionTop);
                    element.css('left', positionLeft);

                    breakTime();
                    setInterval('breakTime()', 30000); //30 seconds
                });


                function breakTime()
                {

                    var element = $('#imgBreakTime');

                    var time = new Date();

                    var startLunchTime = new Date(time.getFullYear(), time.getMonth(), time.getDate(), " + BreakTime.LunchHour + " , " + BreakTime.LunchMinutes + @", 0);
                    var stopLunchTime = new Date(startLunchTime);
                    stopLunchTime.setMinutes(stopLunchTime.getMinutes() + 30);

                    var startBreakTime = new Date(time.getFullYear(), time.getMonth(), time.getDate(), " + BreakTime.BreakHour + " , " + BreakTime.BreakMinutes + @", 0);
                    var stopBreakTime = new Date(startBreakTime);
                    stopBreakTime.setMinutes(stopBreakTime.getMinutes() + 10);

                    var compareTime = new Date(time.getFullYear(), time.getMonth(), time.getDate(), time.getHours(), time.getMinutes(), time.getSeconds());
                    
                    if (compareTime >= startLunchTime && compareTime < stopLunchTime)
                    {
                        element.attr('src', '/images/lunchTime.jpg');
                        element.removeAttr('hidden');
                    }
                    else if(compareTime >= startBreakTime && compareTime < stopBreakTime)
                    {
                        element.attr('src', '/images/breakTime3.jpg');
                        element.removeAttr('hidden');
                    }
                    else
                    {
                        element.attr('hidden', 'hidden');
                    }
                }
                ");

                main.InnerHtml.AppendHtml(script);
                output.Content.AppendHtml(main);

                //output.Content.AppendHtml(script);
            }           
        }

        private BreakTime GetBreakTime(string line)
        {
            //pobranie infromacji o zmianie
            DateTime dateTime = DateTime.Now;

            int shift = dateTime.GetShift();

            //szukanie danych po kolekcji
            var result = BreakTimes.Find(x => x.Line == line && x.Shift == shift); ;
            return result;
        }
    }

    public class BreakTime
    {
        public string Line { get; set; }
        public int Shift { get; set; }
        public int LunchHour { get; set; }
        public int LunchMinutes { get; set; }
        public int BreakHour { get; set; }
        public int BreakMinutes { get; set; }

        public BreakTime() { }

        public BreakTime(string line, int shift, int lunchHour, int lunchMinutes, int breakHour, int breakMinutes)
        {
            Line = line;
            Shift = shift;
            LunchHour = lunchHour;
            LunchMinutes = lunchMinutes;
            BreakHour = breakHour;
            BreakMinutes = breakMinutes;
        }
    }
}

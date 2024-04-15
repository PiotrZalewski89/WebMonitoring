
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using WebMonitoring.Models;

namespace WebMonitoring.TagHelpers
{
    [HtmlTargetElement("div", Attributes = "for, weekly-production")]
    public class ChartTagHelperComponent : TagHelper
    {
        private string TagId { get; set; }
        public WeeklyProduction WeeklyProduction { get; set; }

        public ModelExpression For { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (output.TagName == "div")
            {
                TagId = For.Model.ToString();

                output.TagMode = TagMode.StartTagAndEndTag;

                TagBuilder main = new TagBuilder("div");

                main.InnerHtml.AppendHtml("<h4 style=\"text-align: center;\">" + WeeklyProduction.Description + " - Suma: " + WeeklyProduction.Total + "</h4>");

                TagBuilder chart = new TagBuilder("canvas");
                chart.Attributes.Add("id", TagId);
                chart.Attributes.Add("class", "myChart");
                chart.Attributes.Add("style", "width: 100%; max-width:400px; height: 300px; ");

                main.InnerHtml.AppendHtml(chart);

                //TagBuilder script = new TagBuilder("script");
                //script.InnerHtml.AppendHtml(
                //@"{
            
                //    var pn = " + WeeklyProduction.Monday + "; " +
                //    "var wt = " + WeeklyProduction.Tuesday + "; " +
                //    "var sr = " + WeeklyProduction.Wednesday + "; " +
                //    "var cz = " + WeeklyProduction.Thursday + "; " +
                //    "var pt = " + WeeklyProduction.Friday + "; " +
                //    "var sb = " + WeeklyProduction.Saturday + "; " +
                //    "var nd = " + WeeklyProduction.Sunday + @"; " +
                //    "var target = [" + WeeklyProduction.Target[0] * WeeklyProduction.ActiveShifts[0]
                //    + "," + WeeklyProduction.Target[1] * WeeklyProduction.ActiveShifts[1]
                //    + "," + WeeklyProduction.Target[2] * WeeklyProduction.ActiveShifts[2]
                //    + "," + WeeklyProduction.Target[3] * WeeklyProduction.ActiveShifts[3]
                //    + "," + WeeklyProduction.Target[4] * WeeklyProduction.ActiveShifts[4]
                //    + "," + WeeklyProduction.Target[5] * WeeklyProduction.ActiveShifts[5]
                //    + "," + WeeklyProduction.Target[6] * WeeklyProduction.ActiveShifts[6] + @"];

                //    var xValues = ['Poniedziałek', 'Wtorek', 'Środa', 'Czwartek', 'Piątek', 'Sobota', 'Niedziela'];
                //    var yValues = [pn, wt, sr, cz, pt, sb, nd];
                //    var barColors = ['yellow', 'green', 'blue', 'orange', 'brown', 'gray', 'red'];
                //    var xTargets = [target[0], target[1], target[2], target[3], target[4], target[5], target[6]];
                
                //    var result" + TagId + @";

                //    result" + TagId + @" = new Chart('" + TagId + @"', {                    
                //            data: {
                //                labels: this.xValues,
                //                datasets: [
                //                {
                //                  type: 'line',
                //                  data: this.xTargets,
                //                  fill: false,
                //                  borderColor: 'rgb(54, 162, 235)',
                //                  label: 'Target',
                //                },
                //                {
                //                    type: 'bar',
                //                    backgroundColor: barColors,
                //                    data: this.yValues,
                //                    label: 'Wynik'
                //                }]
                //            },
                //            options:
                //                {
                //                legend: { display: false },
                //                title:
                //                    {
                //                    display: true,
                //                    text: 'Wykaz produkcji w ciągu tygodnia'
                //                }
                //            }
                //        });
                

                //   //this.setRefresh(result" + TagId + @");
                //}

                ////function setRefresh(result" + TagId + @")
                ////{
                ////    var idleInterval = setInterval('refreshChart(result" + TagId + @")', 10000);
                ////}


                ////function refreshChart(result" + TagId + @"){
                ////    console.log(result" + TagId + @");
                ////    $.getJSON('/api/production')
                ////            .done(function(data) {
                ////               console.log(data.toString());
                ////    });

                ////    result" + TagId + @".config.data.datasets[1].data = yValues;
                ////    result" + TagId + @".config.data.datasets[0].data = xTargets;
                ////    result" + TagId + @".update();               
                ////}

                //");

                //TagBuilder scriptRefresh = new TagBuilder("script");
                //scriptRefresh.InnerHtml.AppendHtml(
                //@"{
                //    $(document).ready(function () {
                //        //var idleInterval = setInterval('refreshChart()', 10000);
                //        refreshChart();
                //    });


                //    function refreshChart(){
                        
                //        console.log( $('div').children());

                //        //$.getJSON('/api/production')
                //        //        .done(function(data) {
                //        //           console.log(data.toString());
                //        //});

                //        //result" + TagId + @".config.data.datasets[1].data = yValues;
                //        //result" + TagId + @".config.data.datasets[0].data = xTargets;
                //        //result" + TagId + @".update();               
                //    }
                //}");
                //main.InnerHtml.AppendHtml(script);
                //main.InnerHtml.AppendHtml(scriptRefresh);
                output.Content.AppendHtml(main);
            }
        }
    }
}

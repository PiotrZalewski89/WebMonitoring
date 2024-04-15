using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.DataBase;
using WebMonitoring.Table.Production;

namespace WebMonitoring.Models
{
    public class DbSetLineSTF
    {
        private StorageStationDbContext context;

        private DbProduction _Production = new DbProduction(new ProductionDbContext());

        private string ResultOk => "OK";

        private string[] Line = new string[]
       {
            "STF 3",
            "STF 4",
            "STF 5",
            "STF 6"
       };

        private string[] Model = new string[]
        {
            "BR10 GPF", //0
            "BR10 BJA", //1
            "HR10", //2
            "HR16" //3
        };

        private DbProduction Production { get; set; } = new DbProduction(new ProductionDbContext());

        public List<ProductionPlan> Target => GetTarget();

        public Dictionary<string, List<int>> STF3 { get; set; }
        public Dictionary<string, List<int>> STF4 { get; set; }
        //public Dictionary<string, List<int>> STF4_BR10_GPF { get; set; }
        //public Dictionary<string, List<int>> STF4_BR10_BJA { get; set; }
        public Dictionary<string, List<int>> STF5 { get; set; }
        public Dictionary<string, List<int>> STF6 { get; set; }
        //public Dictionary<string, List<int>> STF6_HR16 { get; set; }


        public DbSetLineSTF(StorageStationDbContext ctx)
        {
            context = ctx;
        }

        public void GetProductionCountPerHourSTF(DateTime dateTime)
        {
            STF3 = new Dictionary<string, List<int>>();
            STF4 = new Dictionary<string, List<int>>();
            //STF4_BR10_GPF = new Dictionary<string, List<int>>();
            //STF4_BR10_BJA = new Dictionary<string, List<int>>();
            STF5 = new Dictionary<string, List<int>>();
            STF6 = new Dictionary<string, List<int>>();
            //STF6_HR16 = new Dictionary<string, List<int>>();

            //pobranie danych dla linii stf3
            //dane dla hr16
            STF3.Add(Model[3], SumProductionModel(Line[0], Model[3], dateTime));

            //pobranie danych dla linii stf4
            //dane br10 gpf
            STF4.Add(Model[0], SumProductionModel(Line[1], Model[0], dateTime));
            //dane br10 bja
            STF4.Add(Model[1], SumProductionModel(Line[1], Model[1], dateTime));
            //dane hr10 gpf
            STF4.Add(Model[2], SumProductionModel(Line[1], Model[2], dateTime));

            //pobranie danych dla linii stf5
            //dane dla hr10
            STF5.Add(Model[2], SumProductionModel(Line[2], Model[2], dateTime));

            //pobranie danych dla linii stf6
            //dane dla hr10
            STF6.Add(Model[2], SumProductionModel(Line[3], Model[2], dateTime));
            //dane dla hr16
            STF6.Add(Model[3], SumProductionModel(Line[3], Model[3], dateTime));

            GetTarget();
        }

        private List<int> SumProductionModel(string line, string model, DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTimeFrom.AddHours(1);

            List<string> partNumber = _Production.GetPartNumber(model);

            List<int> temp = new List<int>();

            List<int> parts = new List<int>();

            int result;

            for (int i = 0; i < 8; i++)
            {
                result = 0;

                var frameTimeUtcFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                var frameTimeUtcTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

                foreach (var m in partNumber)
                {
                    var sqlResult = context.PanelFontijneL1s
                          .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo)
                          .Select(x => x.ManufacturingLotTraceCode);

                    sqlResult = context.PanelFontijneL1s
                          .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo)
                          .Select(x => x.OempartNumber);


                    if (line == Line[0])
                        temp.Add(context.PanelFontijneL1s
                           .Where(x => (x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo) && x.OempartNumber.Contains(m))
                           .Select(x => x.ManufacturingLotTraceCode)
                           .Count());
                    else if (line == Line[1])
                        temp.Add(context.PanelFontijneL1s
                           .Where(x => (x.FrameTime2 >= frameTimeUtcFrom && x.FrameTime2 < frameTimeUtcTo) && x.OempartNumber.Contains(m))
                           .Count());
                    else if (line == Line[2])
                        temp.Add(context.PanelFontijneL1s
                           .Where(x => (x.FrameTime3 >= frameTimeUtcFrom && x.FrameTime3 < frameTimeUtcTo) && x.OempartNumber.Contains(m))
                           .Count());
                    else if (line == Line[3])
                        temp.Add(context.PanelFontijneL1s
                           .Where(x => (x.FrameTime4 >= frameTimeUtcFrom && x.FrameTime4 < frameTimeUtcTo) && x.OempartNumber.Contains(m))
                           .Count());

                    if (temp?.Count > 0)
                    {
                        for (int j = 0; j < temp.Count; j++)
                        {
                            result += temp[j];
                        }

                        temp.Clear();                        
                    }


                }

                dateTimeFrom = dateTimeFrom.AddHours(1);
                dateTimeTo = dateTimeTo.AddHours(1);

                parts.Add(result);
            }


            parts.Add(parts.Sum());

            return parts;
        }

        public int GetCountFromDaySTF(DateTime dateTime, string line)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddDays(1);

            var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc_AllDay();
            var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc_AllDay();

            if (line == LineDescription.LineSTF3)
                return context.PanelFontijneL1s
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                   .Count();
            else if (line == LineDescription.LineSTF4)
                return context.PanelFontijneL1s
                   .Where(x => x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo)
                   .Count();
            else if (line == LineDescription.LineSTF5)
                return context.PanelFontijneL1s
                   .Where(x => x.FrameTime3 >= frameTimeFrom && x.FrameTime3 < frameTimeTo)
                   .Count();
            else if (line == LineDescription.LineSTF6)
                return context.PanelFontijneL1s
                   .Where(x => x.FrameTime4 >= frameTimeFrom && x.FrameTime4 < frameTimeTo)
                   .Count();
            else
                return 0;
        }
             

        public List<ProductionPlan> GetTarget()
        {
            List<ProductionPlan> productions = new List<ProductionPlan>();

            foreach (var model in Model)
            {
                var result = Production.GetTarget(LineDescription.LineSTF3 + " " + model);

                if (STF3.Keys.Contains(model))
                    productions.Add(result?.Length > 0 ? result[0] : IfLackOfDataSetTempProductionPlan(LineDescription.LineSTF3 + " " + model));

                result = Production.GetTarget(LineDescription.LineSTF4 + " " + model);

                if (STF4.Keys.Contains(model))
                    productions.Add(result?.Length > 0 ? result[0] : IfLackOfDataSetTempProductionPlan(LineDescription.LineSTF4 + " " + model));

                result = Production.GetTarget(LineDescription.LineSTF5 + " " + model);

                if (STF5.Keys.Contains(model))
                    productions.Add(result?.Length > 0 ? result[0] : IfLackOfDataSetTempProductionPlan(LineDescription.LineSTF5 + " " + model));

                result = Production.GetTarget(LineDescription.LineSTF6 + " " + model);

                if (STF6.Keys.Contains(model))
                    productions.Add(result?.Length > 0 ? result[0] : IfLackOfDataSetTempProductionPlan(LineDescription.LineSTF6 + " " + model));

            }

            return productions;
        }

        public void SetTarget(string line, int target)
        {
            Production.SetTarget(line, target);
        }

        private ProductionPlan IfLackOfDataSetTempProductionPlan(string line)
        {
            var dateTime = DateTime.Now;
            
            ProductionPlan productionPlan = new ProductionPlan();

            productionPlan.Id = 1;
            productionPlan.Target = DbProduction.DefaultTarget[7];
            productionPlan.CallendarWeek = dateTime.CalendarWeek();
            productionPlan.OperationDate = dateTime;

            productionPlan.Line = line;

            return productionPlan;
        }

        public int ActiveShift(DateTime dateTime, string line)
        {
            int shifts = 0;

            var dateTimeFrom = dateTime.Date;
            dateTimeFrom = dateTimeFrom.AddHours(6);
            var dateTimeTo = dateTime.Date;
            dateTimeTo = dateTimeTo.AddHours(14);

            var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

            for (int i = 0; i < 3; i++)
            {
                int result = 0;
                if (line == LineDescription.LineSTF3)
                {
                    result = context.PanelFontijneL1s
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                   .Count();

                    if (result > 10)
                        shifts++;
                }
                else if (line == LineDescription.LineSTF4)
                {
                    result = context.PanelFontijneL1s
                  .Where(x => x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo)
                  .Count();

                    if (result > 10)
                        shifts++;
                }
                else if (line == LineDescription.LineSTF5)
                {
                    result = context.PanelFontijneL1s
                   .Where(x => x.FrameTime3 >= frameTimeFrom && x.FrameTime3 < frameTimeTo)
                   .Count();

                    if (result > 10)
                        shifts++;
                }
                else if (line == LineDescription.LineSTF6)
                {
                    result = context.PanelFontijneL1s
                   .Where(x => x.FrameTime4 >= frameTimeFrom && x.FrameTime4 < frameTimeTo)
                   .Count();

                    if (result > 10)
                        shifts++;
                }            

                dateTimeFrom = dateTimeFrom.AddHours(8);
                dateTimeTo = dateTimeTo.AddHours(8);

                frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();


            }

            return shifts;
        }

        public int[] GetDailyRaport(DateTime dateTime, string line)
        {
            int[] partsShift = new int[3];

            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddHours(8);

            for (int i = 0; i < 3; i++)
            {
                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

                if (line == LineDescription.LineSTF3M260)
                    partsShift[i] = context.PanelFontijneL1s
                                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.CvmMeasurementOkNok == ResultOk) && !string.IsNullOrEmpty(x.ManufacturingLotTraceCodeOutlet))
                                          .Count();
                else if (line == LineDescription.LineSTF3)
                    partsShift[i] = context.PanelFontijneL1s
                                 .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.CvmMeasurementOkNok == ResultOk) && string.IsNullOrEmpty(x.ManufacturingLotTraceCodeOutlet))
                                 .Count();
                else if (line == LineDescription.LineSTF4)
                {
                    var dbProd = new ProductionDbContext();
                    var list = dbProd.Referencjas.Where(x => x.Model.Contains("BR10"));

                    foreach(var l in list)
                    {
                        partsShift[i] += context.PanelFontijneL1s
                                 .Where(x => (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo && x.CvmMeasurementOkNok == ResultOk) && x.ManufacturingLotTraceCode.Contains(l.ReferencjaKlient))
                                 .Count();
                    }
                }
                else if (line == LineDescription.LineSTF4HR10)
                {
                    var dbProd = new ProductionDbContext();
                    var list = dbProd.Referencjas.Where(x => x.Model.Contains("HR10"));

                    foreach (var l in list)
                    {
                        partsShift[i] += context.PanelFontijneL1s
                                 .Where(x => (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo && x.CvmMeasurementOkNok == ResultOk) && x.ManufacturingLotTraceCode.Contains(l.ReferencjaKlient))
                                 .Count();
                    }
                }
                else if (line == LineDescription.LineSTF5)
                    partsShift[i] = context.PanelFontijneL1s
                       .Where(x => (x.FrameTime3 >= frameTimeFrom && x.FrameTime3 < frameTimeTo && x.CvmMeasurementOkNok == ResultOk))
                       .Count();
                else if (line == LineDescription.LineSTF6)
                {
                    var dbProd = new ProductionDbContext();
                    var list = dbProd.Referencjas.Where(x => x.Model.Contains("HR16"));

                    foreach (var l in list)
                    {
                        partsShift[i] += context.PanelFontijneL1s
                                 .Where(x => (x.FrameTime4 >= frameTimeFrom && x.FrameTime4 < frameTimeTo && x.CvmMeasurementOkNok == ResultOk) && x.ManufacturingLotTraceCode.Contains(l.ReferencjaKlient))
                                 .Count();
                    }
                }
                else if (line == LineDescription.LineSTF6HR10)
                {
                    var dbProd = new ProductionDbContext();
                    var list = dbProd.Referencjas.Where(x => x.Model.Contains("HR10"));

                    foreach (var l in list)
                    {
                        partsShift[i] += context.PanelFontijneL1s
                                 .Where(x => (x.FrameTime4 >= frameTimeFrom && x.FrameTime4 < frameTimeTo && x.CvmMeasurementOkNok == ResultOk) && x.ManufacturingLotTraceCode.Contains(l.ReferencjaKlient))
                                 .Count();
                    }
                }


                dateTimeFrom = dateTimeFrom.AddHours(8);
                dateTimeTo = dateTimeTo.AddHours(8);
            }

            return partsShift;
        }

    }
}

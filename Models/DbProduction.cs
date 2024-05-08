using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.DataBase;
using WebMonitoring.Table.Production;

namespace WebMonitoring.Models
{
    public class DbProduction
    {
        private ProductionDbContext context { get; set; }

        private int NumberOfDayForWeek => 7;

        public static int[] DefaultTarget { get; set; } = new int[]
        {
            60, //0 -cnh ws1
            50, //1 - v50 ws1
            500, //2 - hr16 ws2
            1290, //3 - hr10 ws3b
            280,//4 - br10 ws4
            22, //5 - cnh 537 ws5
            8, //6 - cnh 529 ws6
            661, //7 - stf 3-6
            800, //8 - weil
            80,//ws7
        };

        public DbProduction(ProductionDbContext ctx)
        {
            context = ctx;
        }

        public ProductionPlan[] GetTarget(string line, bool trybPracy12h = false)
        {
            ProductionPlan[] result;

            DateTime dateTime = DateTime.Now;

            string shift = dateTime.GetShift().ToString();

            if (trybPracy12h)
                line += "_12h";

            result = context.ProductionPlans
                    .Where(x => x.Line == line && x.ProductionShift == shift)
                    .OrderByDescending(x => x.OperationDate)
                    .Take(1)
                    .ToArray();

            return result;
        }

        public void SetTarget(string line, int target, bool trybPracy12h = false)
        {
            ProductionPlan productionPlans = new ProductionPlan();

            var dateTime = DateTime.Now;

            if (trybPracy12h)
                line += "_12h";

            productionPlans.CallendarWeek = dateTime.CalendarWeek();
            productionPlans.Line = line;
            productionPlans.OperationDate = dateTime;
            productionPlans.Target = target;
            productionPlans.ProductionShift = dateTime.GetShift().ToString();

            context.Add(productionPlans);
            context.SaveChanges();
        }

        public List<string> GetPartNumber(string model)
        {
            var result = context.Referencjas
                .Where(x => x.Model.Contains(model))
                .Select(x => x.ReferencjaKlient)
                .ToList();

            return result;
        }

        public List<string> GetPartNumberKatcon(string model)
        {
            var result = context.Referencjas
                .Where(x => x.Model.Contains(model))
                .Select(x => x.ReferencjaKatcon)
                .ToList();

            return result;
        }

        private int DefaultTargetForLine(string line)
        {
            if(LineDescription.LineSTF3 == line || LineDescription.LineSTF4 == line || LineDescription.LineSTF5 == line || LineDescription.LineSTF6 == line ||LineDescription.LineWS7==line)
            {
                return DefaultTarget[7];
            }
            else if(LineDescription.LineWS1CNH == line)
            {
                return DefaultTarget[0];
            }
            else if (LineDescription.LineWS1V50 == line)
            {
                return DefaultTarget[1];
            }
            else if (LineDescription.LineWS2 == line)
            {
                return DefaultTarget[2];
            }
            else if (LineDescription.LineWS3 == line)
            {
                return DefaultTarget[3];
            }
            else if (LineDescription.LineWS2B_GPF == line)
            {
                return DefaultTarget[4];
            }
            else if (LineDescription.LineWS2B_BJA == line)
            {
                return DefaultTarget[4];
            }
            else if (LineDescription.LineWS5 == line)
            {
                return DefaultTarget[5];
            }
            else if (LineDescription.LineWS6 == line)
            {
                return DefaultTarget[6];
            }
            else if (LineDescription.LineWS7 == line)
            {
                return DefaultTarget[9];
            }
            else if (LineDescription.LineWeil == line)
            {
                return DefaultTarget[8];
            }

            return 0;
        }

        public List<int> GetTargetsForDashbord1(DateTime dateTime, string line, string shift)
        {
            List<ProductionPlan> result;

            int CW = dateTime.CalendarWeek();

            List<int> weekTarget = new List<int>();

            List<DateTime> dateTimes = new List<DateTime>();

            int tempTarget = 0;

            var lastDay = dateTime.LastDay();
            var firstDay = dateTime.FirstDay();

            //pobranie 1 daty z cw
            result = context.ProductionPlans
                        .Where(x => x.Line.Contains(line) && x.ProductionShift == shift && x.OperationDate <= lastDay)
                        .OrderByDescending(x => x.OperationDate)
                        .Take(1)
                        .ToList();

            //sortowanie po CW
            if (result?.Count > 0)
            {
                DateTime getDate = (DateTime)result[0].OperationDate;

                DateTime checkDate = getDate.Date;

                dateTimes.Add(checkDate);
                weekTarget.Add(result[0].Target);

                // weekTarget.Reverse();

                if (dateTimes?.Count > 0)
                {

                    //brakujace dni z prawej strony
                    int missingDaysToLastDay = lastDay.DayOfYear - dateTime.DayOfYear;

                    //brakujace dni z lewej strony 
                    int missingDaysToFirstDay = dateTime.DayOfYear - firstDay.DayOfYear;

                    //sprawdzenie roku - wazne na przełomie
                    //if(dateTimes[0].Year == dateTime.Year)


                    if (missingDaysToLastDay > 0)
                    {

                        int days = getDate.DayOfYear - dateTime.DayOfYear;

                        if (dateTime.DayOfYear < getDate.DayOfYear)
                        {
                            var tempResult = context.ProductionPlans
                           .Where(x => x.Line == line && x.ProductionShift == shift && x.OperationDate < getDate)
                           .OrderByDescending(x => x.OperationDate)
                           .Take(1)
                           .ToList();

                            if(tempResult?.Count > 0)
                            {
                                for (int i = 0; i < days; i++)
                                {
                                    weekTarget.Add(tempResult[0].Target);
                                }
                            }
                            else
                            {
                                for (int i = 0; i < days; i++)
                                {
                                    weekTarget.Add(result[0].Target);
                                }
                            }
                            
                        }

                        if(getDate.DayOfYear < lastDay.DayOfYear)
                        {
                            int missTarget = lastDay.DayOfYear - getDate.DayOfYear;

                            for (int i = 0; i < missTarget && i < NumberOfDayForWeek; i++)
                            {
                                weekTarget.Insert(i, result[0].Target);
                            }
                        }
                        else
                        {
                            if (days < 0)
                                days = 0;

                            for (int i = 0; i < missingDaysToLastDay - days; i++)
                            {
                                weekTarget.Add(result[0].Target);
                            }
                        }
                       
                    }

                    if (missingDaysToFirstDay > 0 && weekTarget?.Count < NumberOfDayForWeek)
                    {
                        DateTime whitoutDate = getDate;

                        //pobranie kolejnej daty i targetu
                        if (firstDay.DayOfYear != getDate.DayOfYear)
                        {
                            result = context.ProductionPlans
                            .Where(x => x.Line == line && x.ProductionShift == shift && x.OperationDate < whitoutDate)
                            .OrderByDescending(x => x.OperationDate)
                            .Take(1)
                            .ToList();
                        }

                        tempTarget = 0;

                        if (result?.Count > 0)
                        {
                            dateTimes.Add((DateTime)result[0].OperationDate);
                            tempTarget = result[0].Target;
                        }
                        else
                        {
                            if(firstDay.DayOfYear != getDate.DayOfYear)
                            {
                                result = context.ProductionPlans
                               .Where(x => x.Line == line && x.ProductionShift == null && x.OperationDate < whitoutDate)
                               .OrderByDescending(x => x.OperationDate)
                               .Take(1)
                               .ToList();

                                if (result?.Count > 0)
                                {
                                    dateTimes.Add((DateTime)result[0].OperationDate);
                                    tempTarget = result[0].Target;
                                }
                                else
                                {
                                    tempTarget = DefaultTargetForLine(line);
                                    dateTimes.Add(checkDate);
                                }
                            }
                        }

                        //sprawdzenie czy ostatni dzień jest wiekszy badz rowny ostatniej dacie

                        do
                        {
                            if (firstDay.DayOfYear == getDate.DayOfYear)
                            {
                                weekTarget.Add(tempTarget);
                            }
                            else if (firstDay.DayOfYear >= dateTimes[dateTimes.Count - 1].DayOfYear)
                            {
                                weekTarget.Add(tempTarget);
                            }
                            else if (firstDay.DayOfYear < dateTimes[dateTimes.Count - 1].DayOfYear)
                            {
                                if (result?.Count > 0)
                                    weekTarget.Add(result[0].Target);
                                else
                                    weekTarget.Add(tempTarget);

                                whitoutDate = dateTimes[dateTimes.Count - 1];

                                result = context.ProductionPlans
                               .Where(x => x.Line == line && x.ProductionShift == shift && x.OperationDate < whitoutDate)
                               .OrderByDescending(x => x.OperationDate)
                               .Take(1)
                               .ToList();
                            }

                        } while (weekTarget.Count < NumberOfDayForWeek);
                    }
                }
                else
                {
                    for (int i = 0; i < NumberOfDayForWeek; i++)
                    {
                        weekTarget.Add(0);
                    }
                }
            }
            else
            {
                tempTarget = DefaultTargetForLine(line);

                for (int i = 0; i < NumberOfDayForWeek; i++)
                {
                    weekTarget.Add(tempTarget);
                }
            }

            weekTarget.Reverse();

            return weekTarget;
        }


        public List<int> GetTargetsForDashbord(DateTime dateTime, string line, string shift)
        {
            List<int> weekTarget = new List<int>();

            const int maxDays = 7;
            int tempTarget = 0;

            var lastDay = dateTime.LastDay();
            var firstDay = dateTime.FirstDay();

            DateTime dt1;
            _ = DateTime.TryParse("06.03.2023 00:00:00", out dt1);
            DateTime dt2;
            _ = DateTime.TryParse("11.03.2023 00:00:00", out dt2);
                     
            //sprawdzenie targetu dla poszczegolnego dnia
            for (int i  = 0; i < maxDays; i++)
            {
                var result = CheckTarget(firstDay.AddDays(i), line, shift);

                if (result?.Length > 0)
                {
                    if (line == LineDescription.LineWS3)
                    {
                        if (DateTime.Compare(dt1, firstDay.AddDays(i)) <= 0 && DateTime.Compare(dt2, firstDay.AddDays(i)) >= 0)
                        {
                            if (result[0].Target > 1066)
                            {
                                result[0].Target = 1066;
                            }
                        }
                    }

                    weekTarget.Add(result[0].Target);
                }
                else
                {
                    var resultLast = CheckLastTarget(firstDay.AddDays(i), line, shift);

                    if (resultLast?.Length > 0)
                    {
                        if (line == LineDescription.LineWS3)
                        {
                            if (DateTime.Compare(dt1, firstDay.AddDays(i)) <= 0 && DateTime.Compare(dt2, firstDay.AddDays(i)) >= 0)
                            {
                                if (resultLast[0].Target > 1066)
                                {
                                    resultLast[0].Target = 1066;
                                }
                            }
                        }

                        weekTarget.Add(resultLast[0].Target);
                    }
                    else
                    {
                        weekTarget.Add(DefaultTargetForLine(line));
                    }
                }
            }            

            return weekTarget;
        }

        private ProductionPlan[] CheckTarget(DateTime dateTime, string line, string shift)
        {
            return context.ProductionPlans
                        .Where(x => x.Line == line && x.ProductionShift == shift && x.OperationDate == dateTime)
                        .OrderByDescending(x => x.OperationDate)
                        .Take(1)
                        .ToArray();
        }

        private ProductionPlan[] CheckLastTarget(DateTime dateTime, string line, string shift)
        {
            return context.ProductionPlans
                        .Where(x => x.Line == line && x.ProductionShift == shift && x.OperationDate <= dateTime)
                        .OrderByDescending(x => x.OperationDate)
                        .Take(1)
                        .ToArray();
        }

        public int CheckDailyTarget(DateTime dateTime, string line, string shift)
        {
            var addDay = dateTime.AddDays(1);

            var target = context.ProductionPlans
                        .Where(x => x.Line == line && x.ProductionShift == shift && x.OperationDate <= addDay)
                        .OrderByDescending(x => x.OperationDate)
                        .Take(1)
                        .Select(x => x.Target)
                        .ToArray();

            if (target?.Length == 0)
            {
                target = context.ProductionPlans
                        .Where(x => x.Line == line && x.ProductionShift == shift && x.OperationDate <= dateTime)
                        .OrderByDescending(x => x.OperationDate)
                        .Take(1)
                        .Select(x => x.Target)
                        .ToArray();
            }

            return target?.Length > 0 ? target[0] : 0;
        }
    }
}

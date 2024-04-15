using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMonitoring.Models
{
    public class WeeklyProduction
    {
        public int Total => PutValue();

        public Shifts Shifts { get; set; }

        private List<int> target;
        public List<int> Target
        {
            get 
            {
                if (target == null)
                    target = new List<int>();
                else
                    target.Clear();

                //monday
                if (Monday > 0)
                    target.Add(SumTarget(ActiveShifts[0], 0));
                else
                    target.Add(0);

                //Tuesday
                if (Tuesday > 0)
                    target.Add(SumTarget(ActiveShifts[1], 1));
                else
                    target.Add(0);

                //Wednesday
                if (Wednesday > 0)
                    target.Add(SumTarget(ActiveShifts[2], 2));
                else
                    target.Add(0);

                //Thursday
                if (Thursday > 0)
                    target.Add(SumTarget(ActiveShifts[3], 3));
                else
                    target.Add(0);

                //Friday
                if (Friday > 0)
                    target.Add(SumTarget(ActiveShifts[4], 4));
                else
                    target.Add(0);

                //Saturday
                if (Saturday > 0)
                    target.Add(SumTarget(ActiveShifts[5], 5));
                else
                    target.Add(0);

                //Sunday
                if (Sunday > 0)
                    target.Add(SumTarget(ActiveShifts[6], 6));
                else
                    target.Add(0);

                return target; 
            }          
        }
        public int Monday { get; set; } = 10;
        public int Tuesday { get; set; } = 20;
        public int Wednesday { get; set; } = 30;
        public int Thursday { get; set; } = 20;
        public int Friday { get; set; } = 10;
        public int Saturday { get; set; }
        public int Sunday { get; set; }

        public string Description { get; set; }
        public string Line { get; set; }
        public bool Update { get;set; }

        public List<int> ActiveShifts { get; set; }

        private IDbSetLine _DbSetLine { get; set; }

        public WeeklyProduction()
        {
            _DbSetLine = new DbSetLine();
        }

        private int PutValue()
        {
            return Monday + Tuesday + Wednesday + Thursday + Friday + Saturday + Sunday;
        }

        public void SetValues(IList<int> date)
        {
            Monday = date[0];
            Tuesday = date[1];
            Wednesday = date[2];
            Thursday = date[3];
            Friday = date[4];
            Saturday = date[5];
            Sunday = date[6];
        }


        private int SumTarget(int activeShift, int positionDay)
        {
            if (activeShift == 1)
                return Shifts.Shift_1[positionDay];
            else if (activeShift == 2)
                return Shifts.Shift_1[positionDay] + Shifts.Shift_2[positionDay];
            else if (activeShift == 3)
                return Shifts.Shift_1[positionDay] + Shifts.Shift_2[positionDay] + Shifts.Shift_3[positionDay];

            return 0;
        }

        public WeeklyProduction Production(string line)
        {
            WeeklyProduction weeklyProduction = new WeeklyProduction();
            var tempLine = line != LineDescription.LineWS2B_BJA.Replace(" ", "_") && line != LineDescription.LineWS2B_GPF.Replace(" ", "_") ? line : line == LineDescription.LineWS2B_BJA.Replace(" ", "_") ? LineDescription.LineWS2B_BJA : LineDescription.LineWS2B_GPF;
            weeklyProduction.Line = line;
            weeklyProduction.Description = line;
            weeklyProduction.ActiveShifts = _DbSetLine.GetSumWeeklyActiveShifts(tempLine);
            weeklyProduction.Shifts = _DbSetLine.GetTargetForProduction(tempLine, DateTime.Now);
            weeklyProduction.SetValues(_DbSetLine.GetSumWeeklyProduction(tempLine));

            return weeklyProduction;
        }

    }

    public class Shifts
    {
        public List<int> Shift_1 { get; set; }
        public List<int> Shift_2 { get; set; }
        public List<int> Shift_3 { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMonitoring.Models
{
    public class LineParameters
    {

        public bool TrybPracy12h { get; set; }
        public int Divide => TrybPracy12h ? 12 : 8;
        public int MaxCells => TrybPracy12h ? 13 : 9;
        public Dictionary<string, LineValues> LineData { get; set; }

        public ActiveColumn ActiveColumn { get; set; } = new ActiveColumn();

        public string Line { get; set; }

        [Range(1, int.MaxValue)]
        public int ActualTotalParts { get; set; }       

        public UrlData Url { get; set; } = new UrlData();

        public int TotalWeeklyProduction { get; set; }
       
    }

    public class LineValues
    {

        public List<int> Goal { get; set; }
        public List<int> Result { get; set; }
        public bool TrybPracy12h { get; set; }

        public LineValues()
        {
            Goal = new List<int>();
            Result = new List<int>();
        }

        public LineValues(List<int> goal, List<int> result)
        {
            Goal = goal;
            Result = result;
        }

        //lunch time
        //4h - 30min
        //6h - 10 min
        //8h - 10min
        private double MaxWorkTime => TrybPracy12h ? 11 : 7.16;
        private int FullHour => 60;
        private int LunchTime => 30;
        private int PauseTime => 50;
        private int PasueTime12h => 40;

        public virtual List<int> GetValues(int target, int numberOfStation, int[] workTime)
        {
            List<int> goals = new List<int>();

            int hourlyGoal = Convert.ToInt32(target / MaxWorkTime);

            //ustawienie poszczegolnych celi na kazda godzine
            foreach (var time in workTime)
            {
                if (time == FullHour)
                    goals.Add(hourlyGoal / numberOfStation);
                else if (time == LunchTime)
                    goals.Add((hourlyGoal / numberOfStation) / 2);
                else if (time == PauseTime)
                    goals.Add(Convert.ToInt32(Math.Ceiling((hourlyGoal / numberOfStation) * 0.83)));
                else if (time == PasueTime12h)
                    goals.Add(Convert.ToInt32(Math.Ceiling((hourlyGoal / numberOfStation) * 0.665)));
            }

            int restHourlyGoal = 0;

            if (numberOfStation > 1)
                restHourlyGoal = target - (goals.Sum() + (target / numberOfStation));
            else
                restHourlyGoal = target - goals.Sum();

            if (restHourlyGoal > 0 && restHourlyGoal != goals.Sum())
            {
                for(int i = 0; i < goals.Count; i++)
                {
                    if (i > 0)
                    {
                        goals[i]++;
                        restHourlyGoal--;
                    }

                    if (restHourlyGoal == 0)
                        break;
                }
            }

            //target - kolumna 9
            goals.Add(target / numberOfStation);

            return goals;
        }

    }

    public class ActiveColumn
    {
        private int[] FirstShift = new int[]
        {
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13
        };

        private int[] SecondShift = new[]
        {
            14,
            15,
            16,
            17,
            18,
            19,
            20,
            21
        };

        private int[] ThirdShift = new[]
        {
            22,
            23,
            0,
            1,
            2,
            3,
            4,
            5
        };

        private int[] FirstShift12 = new int[]
       {
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13,
            14,
            15,
            16,
            17,
            18
       };

        private int[] SecondShift12 = new[]
        {            
            19,
            20,
            21,
            22,
            23,
            0,
            1,
            2,
            3,
            4,
            5
        };

        public bool TrybPracy12h { get; set; }


        public List<bool> Get { get => ShowActiveColumns(TrybPracy12h); }

        private List<bool> ShowActiveColumns(bool tryb12h = false)
        {
            List<bool> temp = new List<bool>();

            var dateTime = DateTime.Now;

            if (tryb12h)
            {
                if (dateTime.Hour >= 6 && dateTime.Hour < 18)
                {
                    foreach (var h in FirstShift12)
                    {
                        if (h <= dateTime.Hour)
                            temp.Add(true);
                        else
                            temp.Add(false);
                    }
                }
                else if (dateTime.Hour >= 18 && dateTime.Hour < 24 || (dateTime.Hour >= 0 && dateTime.Hour < 6))
                {
                    if (dateTime.Hour >= 18 && dateTime.Hour < 24)
                    {
                        foreach (var h in SecondShift12)
                        {
                            if (h <= dateTime.Hour)
                                temp.Add(true);
                            else
                                temp.Add(false);
                        }
                    }
                    else if (dateTime.Hour >= 0 && dateTime.Hour < 6)
                    {
                        for (int i = 0; i < SecondShift12.Length - 4; i++)
                        {
                            temp.Add(true);
                        }
                        for (int i = 2; i < SecondShift12.Length; i++)
                        {
                            if (i <= dateTime.Hour)
                                temp.Add(true);
                            else
                                temp.Add(false);
                        }
                    }
                }
            }
            else
            {
                if (dateTime.Hour >= 6 && dateTime.Hour < 14)
                {
                    foreach (var h in FirstShift)
                    {
                        if (h <= dateTime.Hour)
                            temp.Add(true);
                        else
                            temp.Add(false);
                    }
                }
                else if (dateTime.Hour >= 14 && dateTime.Hour < 22)
                {
                    foreach (var h in SecondShift)
                    {
                        if (h <= dateTime.Hour)
                            temp.Add(true);
                        else
                            temp.Add(false);
                    }
                }
                else if ((dateTime.Hour >= 22 && dateTime.Hour < 24) || (dateTime.Hour >= 0 && dateTime.Hour < 6))
                {
                    if (dateTime.Hour >= 22 && dateTime.Hour < 24)
                    {
                        foreach (var h in ThirdShift)
                        {
                            if (h <= dateTime.Hour)
                                temp.Add(true);
                            else
                                temp.Add(false);
                        }
                    }
                    else if (dateTime.Hour >= 0 && dateTime.Hour < 6)
                    {
                        for (int i = 0; i < ThirdShift.Length - 4; i++)
                        {
                            temp.Add(true);
                        }
                        for (int i = 2; i < ThirdShift.Length; i++)
                        {
                            if (i <= dateTime.Hour)
                                temp.Add(true);
                            else
                                temp.Add(false);
                        }
                    }
                }
            }

            return temp;
        }
    }   

    public class BreakTime
    {
        public DateTime LunchTime { get; set; }
        public DateTime ShortbreakTime { get; set; }

    }

  
}

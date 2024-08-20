using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMonitoring.Models
{
    public class LineParametersWS : LineParameters
    {
        //private Dictionary<string, int> GoalWS3A = new Dictionary<string, int>
        //{
        //    "Cela0LP1", 
        //}
        private int[] WorkTimeLineWS1CNH = new int[]
        {
            60,
            60,
            60,
            30,
            60,
            50,
            60,
            50
        };

        private int[] WorkTimeLineWS1V50 = new int[]
        {
            60,
            60,
            60,
            30,
            60,
            50,
            60,
            50
        };

        private int[] WorkTimeLineWS2 = new int[]
        {
            60,
            60,
            60,
            60,
            30,
            50,
            60,
            50
        };

        private int[] WorkTimeLineWS2HR18 = new int[]
        {
            60,
            60,
            60,
            60,
            30,
            50,
            60,
            50
        };

        private int[] WorkTimeLineWS3 = new int[]
        {
            60,
            60,
            60,
            30,
            60,
            50,
            60,
            50
        };

        private int[] WorkTimeLineWS4GPF = new int[]
        {
            60,
            60,
            60,
            30,
            60,
            50,
            60,
            50
        };

        private int[] WorkTimeLineWS4M260 = new int[]
    {
            60,
            60,
            60,
            60,
            30,
            60,
            50,
            50
    };

        private int[] WorkTimeLineWS4BJA = new int[]
        {
            60,
            60,
            60,
            30,
            60,
            50,
            60,
            50
        };

        private int[] WorkTimeLine12h = new int[]
        {
            60,
            60,
            60,
            30,
            60,
            60,
            60,
            60,
            50,
            60,
            40,
            60
          };

        private int[] WorkTimeLineWS5 = new int[]
        {
            60,
            60,
            60,
            30,
            60,
            50,
            60,
            50
        };

        private int[] WorkTimeLineWS6 = new int[]
        {
            60,
            60,
            60,
            30,
            60,
            50,
            60,
            50
        };

        private int[] WorkTimeLineSdf = new int[]
        {
            60,
            60,
            60,
            30,
            60,
            50,
            60,
            50
        };

        private int[] WorkTimeLineWS7 = new int[]
        {
            60,
            60,
            60,
            30,
            60,
            50,
            60,
            50
        };

        private int[] NumberOfStationsWS1CNH = new int[]
        {
            1,
            1,
            1,
            1,
            1,
            1,
            1
        };

        private int[] NumberOfStationsWS1V50 = new int[]
        {
            1,
            1,
            1,
            1,
            1,
            1,
            1
        };

        private int[] NumberOfStationsWS2 = new int[]
        {
            3,//cela 1
            3,//cela 2
            3,//cela 2 lp1
            1,//PLT 
            1,//marking
            1,//cela 3
            1,//flt
            1,//fg
            1,//odkurzacz
            1//cl            
        };

        private int[] NumberOfStationsWS2HR18 = new int[]
        {
            1,//Welding Cell 
            1,//leak tester 
            1,//final gauge
            1,//vacuum
            1,//control loop            
        };


        private int[] NumberOfStationsWS3A = new int[]
        {
            1,//0lp1
            1,//1lp1
            1,//1lp2            
            1,//1lp2 rurki
            1,//2lp1
            1,//2lp2
            1,//1lp1 gpf
            1//2lp1 gpf
        };

        private int[] NumberOfStationsWS3B = new int[]
        {
            3,//cell3
            3,//plt
            3,//enc
            3,//wkretak
            2,//homo
            2,//flt
            2,//gauge
            2,//vacum
            2//cl
        };

        private int[] NumberOfStationsWS8Br10GPF = new int[]
        {
            //1,
            1,
            1,
            1,
            1,
            1,
            1
        };

        private int[] NumberOfStationsWS4M260 = new int[]
        {
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1
        };

        private int[] NumberOfStationsWS8Br10BJA = new int[]
        {
            1,
            1,
            1,
            1,
            1,
            1,
            1
        };

        private int[] NumberOfStationsWS5 = new int[]
        {
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1
        };

        private int[] NumberOfStationsWS6 = new int[]
       {
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1
       };

        private int[] NumberOfStationsSdf = new int[]
        {
            1,
            1,
            1,
            1
        };
        private int[] NumberOfStationsWS7 = new int[]
        {
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1
        };

        public void SetValues(string selectedLine, IDictionary<string, List<int>> Results, int target)
        {
            Line = selectedLine;

            if (LineData?.Count > 0)
                LineData.Clear();
            else
                LineData = new Dictionary<string, LineValues>();

            //pobranie liczby stanowisk 
            int[] NumberOfStations = GetNumberOfStations(selectedLine);

            //pobranie czasu pracy
            int[] WorkTime = GetWorkTime(selectedLine, TrybPracy12h);

            //utworzenie celów godzinowych
            int goal = target / Divide;

            //target
            int currentTarget = 0;

            foreach(var r in Results.Keys)
            {
                LineValues lineValues = new LineValues();

                int index = 0;

                for(int i = 0; i< Results.Keys.Count; i++)
                {
                    if (Results.Keys.ElementAt(i) == r)
                    {
                        index = i;
                        break;
                    }                        
                }

                if (NumberOfStations != null && WorkTime != null)
                {
                    currentTarget = SetTargetForCell(selectedLine, target, index);
                    lineValues.TrybPracy12h = TrybPracy12h;
                    if ((Line == LineDescription.LineWS3BLP1 || Line == LineDescription.LineWS3BLP2 || Line == LineDescription.LineWS3BLP3)
                        && (r == "Cela 3 LP1" || r == "Cela 3 LP2" || r == "Cela 3 LP3" || r == "Wkrętak LP1" || r == "Wkrętak LP2" || r == "Wkrętak LP3"))
                    {
                        lineValues.Goal = lineValues.GetValues(currentTarget, 1, WorkTime);
                    }
                    else
                        lineValues.Goal = lineValues.GetValues(currentTarget, NumberOfStations[index], WorkTime);

                    lineValues.Result = Results[r];
                }
                else
                {
                    var last = Results[r].Last();
                    lineValues.TrybPracy12h = TrybPracy12h;

                    foreach (var i in Results[r])
                    {
                        if (!i.Equals(last))
                        {
                            lineValues.Goal.Add(goal);
                        }
                        else
                        {
                            lineValues.Goal.Add(target);
                        }
                        lineValues.Result.Add(i);
                    }
                }

                LineData.Add(r, lineValues);
            }
        }

        private int[] GetNumberOfStations(string selectedLine)
        {
            if (selectedLine == LineDescription.LineWS3BLP1 || selectedLine == LineDescription.LineWS3BLP2 || selectedLine == LineDescription.LineWS3BLP3)
                return NumberOfStationsWS3B;
            else if (selectedLine == LineDescription.LineWS3A)
                return NumberOfStationsWS3A;
            else if (selectedLine == LineDescription.LineWS2)
                return NumberOfStationsWS2;
            else if (selectedLine == LineDescription.LineWS8_GPF)
                return NumberOfStationsWS8Br10GPF;
            else if (selectedLine == LineDescription.LineWS8_BJA)
                return NumberOfStationsWS8Br10BJA;
            else if (selectedLine == LineDescription.LineWS4M260)
                return NumberOfStationsWS4M260;
            else if (selectedLine == LineDescription.LineWS5)
                return NumberOfStationsWS5;
            else if (selectedLine == LineDescription.LineWS6)
                return NumberOfStationsWS6;
            else if (selectedLine == LineDescription.LineWS7)
                return NumberOfStationsWS7;
            else if (selectedLine == LineDescription.LineWS1CNH)
                return NumberOfStationsWS1CNH;
            else if (selectedLine == LineDescription.LineWS1V50)
                return NumberOfStationsWS1V50;
            else if (selectedLine == LineDescription.LineSDF)
                return NumberOfStationsSdf;
            else if (selectedLine == LineDescription.LineWS2HR18)
                return NumberOfStationsWS2HR18;
            //else if (selectedLine == LineDescription.LineWeil)
            //    return NumberOfStationsWeil;
            else
                return null;
        }

        private int[] GetWorkTime(string selectedLine, bool tryb12h = false)
        {
            if (selectedLine == LineDescription.LineWS3A
                || selectedLine == LineDescription.LineWS3BLP1
                || selectedLine == LineDescription.LineWS3BLP2
                || selectedLine == LineDescription.LineWS3BLP3)
                return WorkTimeLineWS3;
            else if (selectedLine == LineDescription.LineWS8_GPF)
            {
                if (tryb12h)
                    return WorkTimeLine12h;
                else
                    return WorkTimeLineWS4GPF;
            }
            else if (selectedLine == LineDescription.LineWS8_BJA)
            {
                if (tryb12h)
                    return WorkTimeLine12h;
                else
                    return WorkTimeLineWS4BJA;
            }
            else if (selectedLine == LineDescription.LineWS4M260)
            {
                if (tryb12h)
                    return WorkTimeLine12h;
                else
                    return WorkTimeLineWS4M260;
            }
            else if (selectedLine == LineDescription.LineWS2)
                return WorkTimeLineWS2;
            else if (selectedLine == LineDescription.LineWS2HR18)
                return WorkTimeLineWS2HR18;
            else if (selectedLine == LineDescription.LineWS5)
                return WorkTimeLineWS5;
            else if (selectedLine == LineDescription.LineWS6)
                return WorkTimeLineWS6;
            else if (selectedLine == LineDescription.LineWS1CNH)
                return WorkTimeLineWS1CNH;
            else if (selectedLine == LineDescription.LineWS1V50)
                return WorkTimeLineWS1V50;
            else if (selectedLine == LineDescription.LineWS7)
                return WorkTimeLineWS7;
            else if (selectedLine == LineDescription.LineSDF)
                return WorkTimeLineSdf;
            //else if (selectedLine == LineDescription.LineWeil)
            //    return WorkTimeLineWeil;
            else
                return null;
        }

        //funkcja do ustawienia targetu dla poszczegilnyhc cel spawalniczych. Target brany jest z głownego planu produkcyjnego
        private int SetTargetForCell(string line, int target, int positionIndex)
        {
            int[] numberOfStations;

            if (line == LineDescription.LineWS3A)
            {
                numberOfStations = GetNumberOfStations(line);


                //nowy target - ustawienie dla kazdej celi indywidualnie
                //ustawienie targetu dla celi 0, 1 gpf, 2 gpf
                if (positionIndex == 0 || positionIndex == 6 || positionIndex == 7)
                {
                    return 1300;// Convert.ToInt32(Math.Ceiling(target * 0.73)) * numberOfStations[positionIndex];
                }
                //ustawienie targetu dla celi 1
                else if (positionIndex == 1 || positionIndex  == 2)
                {
                    return 800;// Convert.ToInt32(Math.Ceiling(target * 0.42)) * numberOfStations[positionIndex];
                }
                //ustawienie targetu dla celi 2
                else if (positionIndex >= 4 && positionIndex < 6)
                {
                    return 650; //Convert.ToInt32(Math.Ceiling(target * 0.465)) * numberOfStations[positionIndex]; //default value 0.465
                }
                //ustawienie targetu dla celi 1 lp1 rurki
                else if (positionIndex == 3)
                {
                    return 2000;// Convert.ToInt32(Math.Ceiling(target * 1.395)) * numberOfStations[positionIndex]; //default value 1.395
                }

            }
            else if(line == LineDescription.LineWS2)
            {
                numberOfStations = GetNumberOfStations(line);
                //ustawienie targettu dla celi 1, 2, 2lp1
                if (positionIndex >= 0 && positionIndex < 2)
                {
                    return Convert.ToInt32(Math.Ceiling(target / 1.0));
                }
                else if (positionIndex == 2)
                {
                    return Convert.ToInt32(Math.Ceiling(target / 0.9));
                }                
            }
            else if (line == LineDescription.LineWS3BLP1 || line == LineDescription.LineWS3BLP2 || line == LineDescription.LineWS3BLP3)
            {
                //ustawienie targettu dla celi 3lp1/2/3
                if (positionIndex == 0 || positionIndex == 3)
                {
                    return 650;
                }
            }

            return target;
        }
    }
  
}

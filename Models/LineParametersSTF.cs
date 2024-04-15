using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMonitoring.Models
{
    public class LineParametersSTF : LineParameters
    {
        private int[] WorkTime= new int[]
        {
            50,
            60,
            60,
            30,
            60,
            50,
            60,
            60
        };

        public int[] Goal = new int[]
        {
            78,
            92,
            92,
            46,
            92,
            92,
            77,
            92,
            661
        };

        public Dictionary<string, List<int>> Goals { get; set; } = new Dictionary<string, List<int>>();

        public new DbSetLineSTF LineData { get; set; }

        public Dictionary<string, int> TotalParts { get; set; } = new Dictionary<string, int>();

        public void SetValues(DbSetLineSTF context)
        {           

            LineData = context;

            LineValues lineValues = new LineValues();

            foreach (var r in LineData.Target)
            {
                Goals.Add(r.Line, lineValues.GetValues(r.Target, 1, WorkTime));
            }

        }
    }

}

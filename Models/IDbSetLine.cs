using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMonitoring.Models
{
    public interface IDbSetLine
    {      
        public Dictionary<string, List<int>> LineData { get; }
        //public int GoalData { get; }
        public int Target { get; set; }
        public void GetProductionCountPerHourWS1(DateTime dateTime, string line);
        public void GetProductionCountPerHourWS2(DateTime dateTime);
        public void GetProductionCountPerHourWS3(DateTime dateTime, string line);
        public void GetProductionCountPerHourWS4(DateTime dateTime, string line, bool tryb12h);
        public void GetProductionCountPerHourWS4M260(DateTime dateTime, string line, bool tryb12h);
        public void GetProductionCountPerHourWS5(DateTime dateTime, string line);
        public void GetProductionCountPerHourWS6(DateTime dateTime, string line);
        public void GetProductionCountPerHourWS7(DateTime dateTime, string line);
        public void GetProductionCountPerHourWeil(DateTime dateTime, string line);
        public void GetProductionCountPerHourSdf(DateTime dateTime, string line);
        public int GetWeeklyProduction(string selectLinen, DateTime dateTime);
        public List<int> GetSumWeeklyProduction(string selectLine);
        public void SetTarget(string selectLine, int target, bool trybPracy12h = false);
        public Shifts GetTargetForProduction(string selectLine, DateTime dateTime);
        public List<int> GetSumWeeklyActiveShifts(string selectLine);
        public int[] GetDailyReport(string selectLine, DateTime dateTime);
    }
}

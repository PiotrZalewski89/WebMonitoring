using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.DataBase;

namespace WebMonitoring.Models
{
    public class DbSetLine : IDbSetLine
    {
        private Dictionary<string, List<int>> _LineData { get; set; }

        private DateTime StartDayOfWeek { get; set; }
        private DateTime EndDayOfWeek { get; set; }

        public Dictionary<string, List<int>> LineData { get => _LineData; }

        public int Target { get; set; }
        virtual public void GetProductionCountPerHourWS1(DateTime dateTime, string line)
        {
            if (line == LineDescription.LineWS1CNH)
            {
                DbSetLineWS1_Cnh dbSet = new DbSetLineWS1_Cnh(new CnhDbContext());

                dbSet.GetProductionCountPerHour(dateTime);

                _LineData = dbSet.LineData;

                Target = dbSet.Target;
            }
            else if (line == LineDescription.LineWS1V50)
            {
                DbSetLineWS1_V50 dbSet = new DbSetLineWS1_V50(new V50_DbContext());

                dbSet.GetProductionCountPerHour(dateTime);

                _LineData = dbSet.LineData;

                Target = dbSet.Target;
            }
        }

        virtual public void GetProductionCountPerHourWS2(DateTime dateTime)
        {
            DbSetLineWS2 dbSet = new DbSetLineWS2(new StorageStationDbContext());

            dbSet.GetProductionCountPerHour(dateTime);

            _LineData = dbSet.LineData;

            Target = dbSet.Target;
        }

        virtual public void GetProductionCountPerHourWS2_HR18(DateTime dateTime)
        {
            DbSetLineWS2HR18 dbSet = new DbSetLineWS2HR18(new StorageStationDbContext());

            dbSet.GetProductionCountPerHour(dateTime);

            _LineData = dbSet.LineData;

            Target = dbSet.Target;
        }

        virtual public void GetProductionCountPerHourWS3(DateTime dateTime, string line)
        {
            DbSetLineWS3 dbSet = new DbSetLineWS3(new StorageStationDbContext(), new ProductionDbContext());

            dbSet.GetProductionCountPerHour(dateTime, line);

            _LineData = dbSet.LineData;

            Target = dbSet.Target;
        }

        virtual public void GetProductionCountPerHourWS4(DateTime dateTime, string line, bool tryb12h)
        {
            DbSetLineWS8 dbSet = new DbSetLineWS8(new StorageStationDbContext(), new ProductionDbContext());

            dbSet.GetProductionCountPerHour(dateTime, line, tryb12h);

            _LineData = dbSet.LineData;
            dbSet.TrybPracy12h = tryb12h;

            Target = dbSet.Target;
        }

        virtual public void GetProductionCountPerHourWS4M260(DateTime dateTime, string line, bool tryb12h)
        {
            DbSetLineWS4M260 dbSet = new DbSetLineWS4M260(new StorageStationDbContext(), new ProductionDbContext());

            dbSet.GetProductionCountPerHourWS4M260(dateTime, line, tryb12h);

            _LineData = dbSet.LineData;
            dbSet.TrybPracy12h = tryb12h;

            Target = dbSet.Target;
        }

        virtual public void GetProductionCountPerHourWS5(DateTime dateTime, string line)
        {
            DbSetLineWS5 dbSet = new DbSetLineWS5(new CnhDbContext());

            dbSet.GetProductionCountPerHour(dateTime);

            _LineData = dbSet.LineData;

            Target = dbSet.Target;
        }

        virtual public void GetProductionCountPerHourWS6(DateTime dateTime, string line)
        {
            DbSetLineWS6 dbSet = new DbSetLineWS6(new CnhDbContext());

            dbSet.GetProductionCountPerHour(dateTime);

            _LineData = dbSet.LineData;

            Target = dbSet.Target;
        }

        virtual public void GetProductionCountPerHourWS7(DateTime dateTime, string line)
        {
            DbSetLineWS7 dbSet = new DbSetLineWS7(new CnhDbContext());

            dbSet.GetProductionCountPerHour(dateTime);

            _LineData = dbSet.LineData;

            Target = dbSet.Target;
        }

        virtual public void GetProductionCountPerHourWeil(DateTime dateTime, string line)
        {
            DbSetLineShell dbSet = new DbSetLineShell(new ProductionDbContext());

            dbSet.GetProductionCountPerHourWeil(dateTime);

            _LineData = dbSet.LineData;

            Target = dbSet.Target;
        }

        virtual public void GetProductionCountPerHourSdf(DateTime dateTime, string line)
        {
            DbSetPipeSDF dbSet = new DbSetPipeSDF(new PipeDbContext());

            dbSet.GetProductionCountPerHour(dateTime);

            _LineData = dbSet.LineData;

            Target = dbSet.Target;
        }

        virtual public int GetWeeklyProduction(string selectLine, DateTime dateTime)
        {
            if (selectLine == LineDescription.LineWS1CNH)
            {
                DbSetLineWS1_Cnh dbSet = new DbSetLineWS1_Cnh(new CnhDbContext());

                return dbSet.GetCountFromDayWS1(dateTime);
            }
            else if (selectLine == LineDescription.LineWS1V50)
            {
                DbSetLineWS1_V50 dbSet = new DbSetLineWS1_V50(new V50_DbContext());

                return dbSet.GetCountFromDayWS1(dateTime);
            }
            else if (selectLine == LineDescription.LineWS2)
            {
                DbSetLineWS2 dbSet = new DbSetLineWS2(new StorageStationDbContext());

                return dbSet.GetCountFromDayWS2(dateTime);
            }
            else if (selectLine == LineDescription.LineWS2HR18)
            {
                DbSetLineWS2HR18 dbSet = new DbSetLineWS2HR18(new StorageStationDbContext());

                return dbSet.GetCountFromDayWS2HR18(dateTime);
            }
            else if (selectLine == LineDescription.LineWS3BLP1 || selectLine == LineDescription.LineWS3BLP2)
            {
                DbSetLineWS3 dbSet = new DbSetLineWS3(new StorageStationDbContext());

                if (selectLine == LineDescription.LineWS3BLP1)
                {
                    return dbSet.GetCountFromDayWS3BLP1(dateTime);
                }
                else if (selectLine == LineDescription.LineWS3BLP2)
                {
                    return dbSet.GetCountFromDayWS3BLP2(dateTime);
                }
            }
            else if (selectLine == LineDescription.LineWS8_BJA || selectLine == LineDescription.LineWS8_GPF || selectLine == LineDescription.LineWS4)
            {
                DbSetLineWS8 dbSet = new DbSetLineWS8(new StorageStationDbContext());

                return dbSet.GetCountFromDayWS4(selectLine, dateTime);
            }
            else if (selectLine == LineDescription.LineWS4M260)
            {
                DbSetLineWS4M260 dbSet = new DbSetLineWS4M260(new StorageStationDbContext());

                return dbSet.GetCountFromDayWS4M260(selectLine, dateTime);
            }
            else if (selectLine == LineDescription.LineWS5)
            {
                DbSetLineWS5 dbSet = new DbSetLineWS5(new CnhDbContext());

                return dbSet.GetCountFromDayWS5(dateTime);
            }
            else if (selectLine == LineDescription.LineWS6)
            {
                DbSetLineWS6 dbSet = new DbSetLineWS6(new CnhDbContext());

                return dbSet.GetCountFromDayWS6(dateTime);
            }
            else if (selectLine == LineDescription.LineWS7)
            {
                DbSetLineWS7 dbSet = new DbSetLineWS7(new CnhDbContext());

                return dbSet.GetCountFromDayWS7(dateTime);
            }
            else if (selectLine == LineDescription.LineSTF3)
            {
                DbSetLineSTF dbSet = new DbSetLineSTF(new StorageStationDbContext());

                return dbSet.GetCountFromDaySTF(dateTime, LineDescription.LineSTF3);
            }
            else if (selectLine == LineDescription.LineSTF4)
            {
                DbSetLineSTF dbSet = new DbSetLineSTF(new StorageStationDbContext());

                return dbSet.GetCountFromDaySTF(dateTime, LineDescription.LineSTF4);
            }
            else if (selectLine == LineDescription.LineSTF5)
            {
                DbSetLineSTF dbSet = new DbSetLineSTF(new StorageStationDbContext());

                return dbSet.GetCountFromDaySTF(dateTime, LineDescription.LineSTF5);
            }
            else if (selectLine == LineDescription.LineSTF6)
            {
                DbSetLineSTF dbSet = new DbSetLineSTF(new StorageStationDbContext());

                return dbSet.GetCountFromDaySTF(dateTime, LineDescription.LineSTF6);
            }
            else if (selectLine == LineDescription.LineWeil)
            {
                DbSetLineShell dbSet = new DbSetLineShell(new ProductionDbContext());

                return dbSet.GetCountFromDay(dateTime);
            }
            else if (selectLine == LineDescription.LineSDF)
            {
                DbSetPipeSDF dbSet = new DbSetPipeSDF(new PipeDbContext());

                return dbSet.GetCountFromDayPipeSdf(dateTime);
            }

            return 0;
        }

        virtual public Shifts GetTargetForProduction(string selectLine, DateTime dateTime)
        {
            Shifts shift = new Shifts();

            DbProduction dbProduction = new DbProduction(new ProductionDbContext());

            for(int i = 1; i <= 3; i++)
            {
                if(i == 1)
                {
                    shift.Shift_1 = dbProduction.GetTargetsForDashbord(dateTime, selectLine, i.ToString());
                }
                else if (i == 2)
                {
                    shift.Shift_2 = dbProduction.GetTargetsForDashbord(dateTime, selectLine, i.ToString());
                }
                else if (i == 3)
                {
                    shift.Shift_3 = dbProduction.GetTargetsForDashbord(dateTime, selectLine, i.ToString());
                }
            }

            return shift;
        }

        virtual public void SetTarget(string selectLine, int target, bool trybPracy12h = false)
        {
            if (selectLine == LineDescription.LineWS2)
            {
                DbSetLineWS2 dbSet = new DbSetLineWS2(new StorageStationDbContext());

                dbSet.Target = target;
            }
            else if (selectLine == LineDescription.LineWS2HR18 || selectLine == LineDescription.LineWS2HR18)
            {
                DbSetLineWS2HR18 dbSet = new DbSetLineWS2HR18(new StorageStationDbContext());

                dbSet.Target = target;
            }
            else if (selectLine == LineDescription.LineWS3BLP1 || selectLine == LineDescription.LineWS3BLP2)
            {
                DbSetLineWS3 dbSet = new DbSetLineWS3(new StorageStationDbContext());

                dbSet.Target = target;
            }
            else if (selectLine == LineDescription.LineWS8_BJA || selectLine == LineDescription.LineWS8_GPF)
            {
                DbSetLineWS8 dbSet = new DbSetLineWS8(new StorageStationDbContext());

                dbSet.TrybPracy12h = trybPracy12h;
                dbSet.Target = target;
            }
            else if (selectLine == LineDescription.LineWS4M260)
            {
                DbSetLineWS4M260 dbSet = new DbSetLineWS4M260(new StorageStationDbContext());

                dbSet.TrybPracy12h = trybPracy12h;
                dbSet.Target = target;
            }
            else if (selectLine == LineDescription.LineWS1CNH)
            {
                DbSetLineWS1_Cnh dbSet = new DbSetLineWS1_Cnh(new CnhDbContext());

                dbSet.Target = target;
            }
            else if (selectLine == LineDescription.LineWS1V50)
            {
                DbSetLineWS1_V50 dbSet = new DbSetLineWS1_V50(new V50_DbContext());

                dbSet.Target = target;
            }
            else if (selectLine == LineDescription.LineWS5)
            {
                DbSetLineWS5 dbSet = new DbSetLineWS5(new CnhDbContext());

                dbSet.Target = target;
            }
            else if (selectLine == LineDescription.LineWS6)
            {
                DbSetLineWS6 dbSet = new DbSetLineWS6(new CnhDbContext());

                dbSet.Target = target;
            }
            //poniżej chyba nie, bo to jest tam gdzie nie ma skanowania
            //else if (selectLine == LineDescription.LineWS7)
            //{
            //    DbSetLineWS7 dbSet = new DbSetLineWS7(new CnhDbContext());

            //    dbSet.Target = target;
            //}
            else if (selectLine == LineDescription.LineWeil)
            {
                DbSetLineShell dbSet = new DbSetLineShell(new ProductionDbContext());

                dbSet.Target = target;
            }
            else if (selectLine == LineDescription.LineWS7)
            {
                DbSetLineWS7 dbSet = new DbSetLineWS7(new CnhDbContext());

                dbSet.Target = target;
            }
            else if (selectLine == LineDescription.LineSDF)
            {
                DbSetPipeSDF dbSet = new DbSetPipeSDF(new PipeDbContext());

                dbSet.Target = target;
            }
        }

        private void ProductionWeek()
        {
            var dateTime = DateTime.Now.Date;

            dateTime = dateTime.AddHours(6);

            StartDayOfWeek = dateTime.FirstDay();
            EndDayOfWeek = dateTime.LastDay();
        }

        public List<int> GetSumWeeklyProduction(string selectLine)
        {
            List<int> datePerDay = new List<int>();

            ProductionWeek();

            int days = (EndDayOfWeek.DayOfYear - StartDayOfWeek.DayOfYear) + 1;

            for (int i = 0; i < days; i++)
            {
                //if (selectLine == LineDescription.LineWS2)
                //{
                //    datePerDay.Add(GetWeeklyProduction(selectLine, StartDayOfWeek.AddDays(i)));
                //}
                //else 
                if (selectLine == LineDescription.LineWS3A 
                    || selectLine == LineDescription.LineWS3 
                    || selectLine == LineDescription.LineWS3BLP1 
                    || selectLine == LineDescription.LineWS3BLP2 
                    || selectLine == LineDescription.LineWS3BLP3)
                {
                    int result_1 = GetWeeklyProduction(LineDescription.LineWS3BLP1, StartDayOfWeek.AddDays(i));
                    int result_2 = GetWeeklyProduction(LineDescription.LineWS3BLP2, StartDayOfWeek.AddDays(i));

                    datePerDay.Add(result_1 + result_2);
                }
                else
                {
                    datePerDay.Add(GetWeeklyProduction(selectLine, StartDayOfWeek.AddDays(i)));
                }
               
            }

            return datePerDay;
        }

        public List<int> GetSumWeeklyActiveShifts(string selectLine)
        {
            List<int> datePerDay = new List<int>();

            ProductionWeek();

            int days = (EndDayOfWeek.DayOfYear - StartDayOfWeek.DayOfYear) + 1;

            for (int i = 0; i < days; i++)
            {
                datePerDay.Add(GetWeeklyActiveShifts(selectLine, StartDayOfWeek.AddDays(i)));
            }

            return datePerDay;
        }

        public int GetWeeklyActiveShifts(string selectLine, DateTime dateTime)
        {
            if (selectLine == LineDescription.LineWS3)
            {
                DbSetLineWS3 dbSet = new DbSetLineWS3(new StorageStationDbContext());

                return dbSet.ActiveShift(dateTime);
            }

            if (selectLine == LineDescription.LineWS1CNH)
            {
                DbSetLineWS1_Cnh dbSet = new DbSetLineWS1_Cnh(new CnhDbContext());

                return dbSet.ActiveShift(dateTime);
            }
            else if (selectLine == LineDescription.LineWS1V50)
            {
                DbSetLineWS1_V50 dbSet = new DbSetLineWS1_V50(new V50_DbContext());

                return dbSet.ActiveShift(dateTime);
            }
            else if (selectLine == LineDescription.LineWS2)
            {
                DbSetLineWS2 dbSet = new DbSetLineWS2(new StorageStationDbContext());

                return dbSet.ActiveShift(dateTime);
            }
            else if (selectLine == LineDescription.LineWS2HR18)
            {
                DbSetLineWS2HR18 dbSet = new DbSetLineWS2HR18(new StorageStationDbContext());

                return dbSet.ActiveShift(dateTime);
            }
            else if (selectLine == LineDescription.LineWS3BLP1 || selectLine == LineDescription.LineWS3BLP2 || selectLine == LineDescription.LineWS3)
            {
                DbSetLineWS3 dbSet = new DbSetLineWS3(new StorageStationDbContext());

                return dbSet.ActiveShift(dateTime);
            }
            else if (selectLine == LineDescription.LineWS8_BJA || selectLine == LineDescription.LineWS8_GPF || selectLine == LineDescription.LineWS4)
            {
                DbSetLineWS8 dbSet = new DbSetLineWS8(new StorageStationDbContext());

                return dbSet.ActiveShift(selectLine, dateTime);
            }
            else if (selectLine == LineDescription.LineWS5)
            {
                DbSetLineWS5 dbSet = new DbSetLineWS5(new CnhDbContext());

                return dbSet.ActiveShift(dateTime);
            }
            else if (selectLine == LineDescription.LineWS6)
            {
                DbSetLineWS6 dbSet = new DbSetLineWS6(new CnhDbContext());

                return dbSet.ActiveShift(dateTime);
            }
            else if (selectLine == LineDescription.LineWS7)
            {
                DbSetLineWS7 dbSet = new DbSetLineWS7(new CnhDbContext());

                return dbSet.ActiveShift(dateTime);
            }
            else if (selectLine == LineDescription.LineSTF3)
            {
                DbSetLineSTF dbSet = new DbSetLineSTF(new StorageStationDbContext());

                return dbSet.ActiveShift(dateTime, LineDescription.LineSTF3);
            }
            else if (selectLine == LineDescription.LineSTF4)
            {
                DbSetLineSTF dbSet = new DbSetLineSTF(new StorageStationDbContext());

                return dbSet.ActiveShift(dateTime, LineDescription.LineSTF4);
            }
            else if (selectLine == LineDescription.LineSTF5)
            {
                DbSetLineSTF dbSet = new DbSetLineSTF(new StorageStationDbContext());

                return dbSet.ActiveShift(dateTime, LineDescription.LineSTF5);
            }
            else if (selectLine == LineDescription.LineSTF6)
            {
                DbSetLineSTF dbSet = new DbSetLineSTF(new StorageStationDbContext());

                return dbSet.ActiveShift(dateTime, LineDescription.LineSTF6);
            }
            else if (selectLine == LineDescription.LineWeil)
            {
                DbSetLineShell dbSet = new DbSetLineShell(new ProductionDbContext());

                return dbSet.ActiveShift(dateTime);
            }
            else if (selectLine == LineDescription.LineSDF)
            {
                DbSetPipeSDF dbSet = new DbSetPipeSDF(new PipeDbContext());

                return dbSet.ActiveShift(dateTime);
            }

            return 1;
        }

        public int[] GetDailyReport(string selectLine, DateTime dateTime)
        {
            int[] partsPerShift = new int[3];

            if (selectLine == LineDescription.LineWS3)
            {
                DbSetLineWS3 dbSet = new DbSetLineWS3(new StorageStationDbContext());

                partsPerShift =  dbSet.GetDailyRaport(dateTime);
            }

            if (selectLine == LineDescription.LineWS1CNH)
            {
                DbSetLineWS1_Cnh dbSet = new DbSetLineWS1_Cnh(new CnhDbContext());

                partsPerShift = dbSet.GetDailyRaport(dateTime);
            }
            else if (selectLine == LineDescription.LineWS1V50)
            {
                DbSetLineWS1_V50 dbSet = new DbSetLineWS1_V50(new V50_DbContext());

                partsPerShift = dbSet.GetDailyRaport(dateTime);
            }
            else if (selectLine == LineDescription.LineWS2)
            {
                DbSetLineWS2 dbSet = new DbSetLineWS2(new StorageStationDbContext());

                partsPerShift = dbSet.GetDailyRaport(dateTime);
            }
            else if (selectLine == LineDescription.LineWS2HR18)
            {
                DbSetLineWS2HR18 dbSet = new DbSetLineWS2HR18(new StorageStationDbContext());

                partsPerShift = dbSet.GetDailyRaport(dateTime);
            }
            else if (selectLine == LineDescription.LineWS8_BJA || selectLine == LineDescription.LineWS8_GPF || selectLine == LineDescription.LineWS4)
            {
                DbSetLineWS8 dbSet = new DbSetLineWS8(new StorageStationDbContext());

                partsPerShift = dbSet.GetDailyRaport(dateTime, selectLine == LineDescription.LineWS8_BJA ? "BR10 BJA" : "BR10 GPF");
            }
            else if (selectLine == LineDescription.LineWS4M260)
            {
                DbSetLineWS4M260 dbSet = new DbSetLineWS4M260(new StorageStationDbContext());

                partsPerShift = dbSet.GetDailyRaport(dateTime, LineDescription.LineWS4M260);
            }
            else if (selectLine == LineDescription.LineWS5)
            {
                DbSetLineWS5 dbSet = new DbSetLineWS5(new CnhDbContext());

                partsPerShift = dbSet.GetDailyRaport(dateTime);
            }
            else if (selectLine == LineDescription.LineWS6)
            {
                DbSetLineWS6 dbSet = new DbSetLineWS6(new CnhDbContext());

                partsPerShift = dbSet.GetDailyRaport(dateTime);
            }
            else if (selectLine == LineDescription.LineWS7)
            {
                DbSetLineWS7 dbSet = new DbSetLineWS7(new CnhDbContext());

                partsPerShift = dbSet.GetDailyRaport(dateTime);
            }
            else if (selectLine == LineDescription.LineSTF3 || selectLine == LineDescription.LineSTF3M260)
            {
                DbSetLineSTF dbSet = new DbSetLineSTF(new StorageStationDbContext());

                partsPerShift = dbSet.GetDailyRaport(dateTime, selectLine);
            }
            else if (selectLine == LineDescription.LineSTF3M260)
            {
                DbSetLineSTF dbSet = new DbSetLineSTF(new StorageStationDbContext());

                partsPerShift = dbSet.GetDailyRaport(dateTime, selectLine);
            }
            else if (selectLine == LineDescription.LineSTF4 || selectLine == LineDescription.LineSTF4HR10)
            {
                DbSetLineSTF dbSet = new DbSetLineSTF(new StorageStationDbContext());

                partsPerShift = dbSet.GetDailyRaport(dateTime, selectLine);
            }
            else if (selectLine == LineDescription.LineSTF5)
            {
                DbSetLineSTF dbSet = new DbSetLineSTF(new StorageStationDbContext());

                partsPerShift = dbSet.GetDailyRaport(dateTime, selectLine);
            }
            else if (selectLine == LineDescription.LineSTF6 || selectLine == LineDescription.LineSTF6HR10)
            {
                DbSetLineSTF dbSet = new DbSetLineSTF(new StorageStationDbContext());

                partsPerShift = dbSet.GetDailyRaport(dateTime, selectLine);
            }
            else if (selectLine == LineDescription.LineWeil)
            {
                DbSetLineShell dbSet = new DbSetLineShell(new ProductionDbContext());

                partsPerShift = dbSet.GetDailyRaport(dateTime);
            }
            else if (selectLine == LineDescription.LineSDF)
            {
                DbSetPipeSDF dbSet = new DbSetPipeSDF(new PipeDbContext());

                partsPerShift = dbSet.GetDailyRaport(dateTime);
            }

            return partsPerShift;
        }
    }
}

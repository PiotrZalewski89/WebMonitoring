
using System;
using System.Collections.Generic;
using System.Linq;
using WebMonitoring.DataBase;

namespace WebMonitoring.Models
{
    public class DbSetLineWS2HR18
    {
        private StorageStationDbContext DbContext;

        private string ResultOk => "OK";
        private string Remove => "Remove";
        private string L1 => "L1";
        private string L1_D2 => "L1_D2";
        private string L2_D1 => "L2_D1";

        private string[] DescriptionWS2_HR18 = new string[]
       {
            "Cela spawalnicza",
            "Tester szczelności",
            "Sprawdzian geometrii",
            "Odkurzacz",
            "Control Loop KJ"
       };

        private Dictionary<string, List<int>> _LineData { get; set; }

        public Dictionary<string, List<int>> LineData { get => _LineData; }

        private DbProduction Production { get; set; } = new DbProduction(new ProductionDbContext());

        private int target = 0;
        public int Target
        {
            get
            {
                if (target == 0)
                {
                    var result = Production.GetTarget(LineDescription.LineWS2HR18);

                    if (result?.Length > 0)
                        target = result[0].Target;
                    else
                        target = DbProduction.DefaultTarget[2];
                }
                //FileJson json = new FileJson();
                //target = json.DeserializeFromFile<int>(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Target", @"\LiniaWs2.json");
                return target;
            }
            set
            {
                target = value;
                Production.SetTarget(LineDescription.LineWS2HR18, target);
            }
        }

        public List<int> Cela_spawalnicza { get; set; }

        public List<int> Tester_szczelności { get; set; }

        public List<int> Sprawdzian_geometrii { get; set; }

        public List<int> Odkurzacz { get; set; }
        public List<int> ControlLoop_KJ { get; set; }


        public DbSetLineWS2HR18(StorageStationDbContext ctx)
        {
            DbContext = ctx;
        }

        public void GetProductionCountPerHour(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTimeFrom.AddHours(1);

            _LineData = new Dictionary<string, List<int>>();

            Cela_spawalnicza = new List<int>();
            Tester_szczelności = new List<int>();
            Sprawdzian_geometrii = new List<int>();
            Odkurzacz = new List<int>();
            ControlLoop_KJ = new List<int>();


            for (int i = 0; i < 8; i++)
            {
                var frameTimeUtcFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                var frameTimeUtcTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();

                Cela_spawalnicza.Add(DbContext.Hr18WeldingCellL5s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                Tester_szczelności.Add(DbContext.Hr18LeaktesterL5s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikTestu == ResultOk)
                   .Count());

                Sprawdzian_geometrii.Add(DbContext.Hr18FinalGaugeL5s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                Odkurzacz.Add(DbContext.Hr18VacuumL5s
                  .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                  .Count());

                ControlLoop_KJ.Add(DbContext.Hr18ControlLoopL5s
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk && x.NrPzzw != Remove)
                   .Count());

                dateTimeFrom = dateTimeFrom.AddHours(1);
                dateTimeTo = dateTimeTo.AddHours(1);
            }

            Cela_spawalnicza.Add(Cela_spawalnicza.Sum());
            Tester_szczelności.Add(Tester_szczelności.Sum());
            Sprawdzian_geometrii.Add(Sprawdzian_geometrii.Sum());
            Odkurzacz.Add(Odkurzacz.Sum());
            ControlLoop_KJ.Add(ControlLoop_KJ.Sum());
  

            _LineData.Add(DescriptionWS2_HR18[0], Cela_spawalnicza);
            _LineData.Add(DescriptionWS2_HR18[1], Tester_szczelności);
            _LineData.Add(DescriptionWS2_HR18[2], Sprawdzian_geometrii);
            _LineData.Add(DescriptionWS2_HR18[3], Odkurzacz);
            _LineData.Add(DescriptionWS2_HR18[4], ControlLoop_KJ);
        }

        public int GetCountFromDayWS2HR18(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddDays(1);

            var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc_AllDay();
            var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc_AllDay();

            return DbContext.Hr18FinalGaugeL5s
               .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk)
               .Count();
        }

        public int[] GetDailyRaport(DateTime dateTime)
        {
            int[] partsShift = new int[3];

            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddHours(8);

            for (int i = 0; i < 3; i++)
            {
                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

                partsShift[i] = DbContext.Hr18FinalGaugeL5s
                   .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo) && x.WynikOperacji == ResultOk)
                   .Count();

                dateTimeFrom = dateTimeFrom.AddHours(8);
                dateTimeTo = dateTimeTo.AddHours(8);
            }

            return partsShift;
        }

        public int ActiveShift(DateTime dateTime)
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
                var result1 = DbContext.Hr18FinalGaugeL5s
               .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo) && x.WynikOperacji == ResultOk)
               .Count();

                if (result1 > 10 )
                {
                    shifts++;
                }

                dateTimeFrom = dateTimeFrom.AddHours(8);
                dateTimeTo = dateTimeTo.AddHours(8);

                frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();
            }

            return shifts;
        }
    }
}

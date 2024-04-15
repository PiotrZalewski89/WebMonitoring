using System;
using System.Collections.Generic;
using System.Linq;
using WebMonitoring.DataBase;

namespace WebMonitoring.Models
{
    public class DbSetLineWS4M260
    {
        private StorageStationDbContext context;
        private ProductionDbContext dpContext;

        private string[] WS4M260 = new string[]
        {
            "Siezer GBD I/O",
            "Cela 5",
            "Leak tester",
            "Enkapsulacja 1",
            "Enkapsulacja 2",
            "Cela 8",
            "Spawanie pinu",
            "Sprawdzian geometrii",
            "Odkurzacz",
            "Stacja montażowa",
            "Pętla KJ"
        };

        private string ResultOk => "OK";
        private string Remove => "Remove";

        private Dictionary<string, List<int>> _LineData { get; set; }

        public Dictionary<string, List<int>> LineData { get => _LineData; }

        private DbProduction Production { get; set; } = new DbProduction(new ProductionDbContext());

        public static string Line { get; set; }

        private int target = 0;
        public int Target
        {
            get
            {
                if (target == 0)
                {
                    var result = Production.GetTarget(Line, TrybPracy12h);

                    if (result?.Length > 0)
                        target = result[0].Target;
                    else
                        target = DbProduction.DefaultTarget[4];
                }
                return target;
            }
            set
            {
                target = value;
                Production.SetTarget(Line, target, TrybPracy12h);
            }

        }

        public bool TrybPracy12h { get; set; }

        public List<int> SizerGBDio { get; set; }

        public List<int> Cela5 { get; set; }

        public List<int> LT { get; set; }

        public List<int> Enkapsulacja1 { get; set; }

        public List<int> Enkapsulacja2 { get; set; }

        public List<int> Cela8 { get; set; }
        public List<int> SpawaniePinu { get; set; }

        public List<int> SprawdzianGeometrii { get; set; }

        public List<int> Odkurzacz { get; set; }
        public List<int> StacjaMontazowa { get; set; }

        public List<int> PetlaKJ { get; set; }

        public DbSetLineWS4M260(StorageStationDbContext ctx, ProductionDbContext dpCtx)
        {
            context = ctx;
            dpContext = dpCtx;
        }
        public DbSetLineWS4M260(StorageStationDbContext ctx)
        {
            context = ctx;
        }

        public void GetProductionCountPerHourWS4M260(DateTime dateTime, string line, bool tryb12h)
        {
            _LineData = new Dictionary<string, List<int>>();

            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTimeFrom.AddHours(1);

            int hour = tryb12h ? 12 : 8;

            SizerGBDio = new List<int>();
            Cela5 = new List<int>();
            LT = new List<int>();
            Enkapsulacja1 = new List<int>();
            Enkapsulacja2 = new List<int>();
            Cela8 = new List<int>();
            SpawaniePinu = new List<int>();
            SprawdzianGeometrii = new List<int>();
            StacjaMontazowa = new List<int>();
            Odkurzacz = new List<int>();
            PetlaKJ = new List<int>();

            const string m260a = "M260A";

            IQueryable<int?> parts;

            for (int i = 0; i < hour; i++)
            {
                var frameTimeUtcFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                var frameTimeUtcTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();

                parts = dpContext.Ws4Cela5s
                     .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.Model == m260a)
                     .Select(x => x.IloscSztuk);

                Cela5.Add((int)parts.Sum());

                SizerGBDio.Add(context.M260GbdIoCalibrationL4s
                        .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                        .Count());

                LT.Add(context.M260LeakTesterAndMarkingL4s
                      .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikTestu == ResultOk)
                      .Count());

                Enkapsulacja1.Add(context.M260EncapsulationBodyL4s
                      .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                      .Count());

                Enkapsulacja2.Add(context.M260EncapsulationPipeL4s
                        .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                        .Count());

                Cela8.Add(context.M260ResistanceWeldingL4s
                       .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                       .Count());

                SpawaniePinu.Add(context.M260PressStationL4s
                       .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                       .Count());

                SprawdzianGeometrii.Add(context.M260GeometryGaugeL4s
                       .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                       .Count());

                Odkurzacz.Add(context.M260VacuumL4s
                        .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                        .Count());

                StacjaMontazowa.Add(context.M260BracketChecksL4s
                        .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                        .Count());

                PetlaKJ.Add(context.M260ControlLoopL4s
                       .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk && x.NrPzzw != Remove)
                       .Count());

                dateTimeFrom = dateTimeFrom.AddHours(1);
                dateTimeTo = dateTimeTo.AddHours(1);
            }

            SizerGBDio.Add(SizerGBDio.Sum());
            Cela5.Add(Cela5.Sum());
            LT.Add(LT.Sum());
            Enkapsulacja1.Add(Enkapsulacja1.Sum());
            Enkapsulacja2.Add(Enkapsulacja2.Sum());
            Cela8.Add(Cela8.Sum());
            SpawaniePinu.Add(SpawaniePinu.Sum());
            SprawdzianGeometrii.Add(SprawdzianGeometrii.Sum());
            Odkurzacz.Add(Odkurzacz.Sum());
            StacjaMontazowa.Add(StacjaMontazowa.Sum());
            PetlaKJ.Add(PetlaKJ.Sum());

            _LineData.Add(WS4M260[0], SizerGBDio);
            _LineData.Add(WS4M260[1], Cela5);
            _LineData.Add(WS4M260[2], LT);
            _LineData.Add(WS4M260[3], Enkapsulacja1);
            _LineData.Add(WS4M260[4], Enkapsulacja2);
            _LineData.Add(WS4M260[5], Cela8);
            _LineData.Add(WS4M260[6], SpawaniePinu);
            _LineData.Add(WS4M260[7], SprawdzianGeometrii);
            _LineData.Add(WS4M260[8], Odkurzacz);
            _LineData.Add(WS4M260[9], StacjaMontazowa);
            _LineData.Add(WS4M260[10], PetlaKJ);
        }


        public int GetCountFromDayWS4M260(string line, DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddDays(1);

            var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime_AllDay();
            var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime_AllDay();

            return context.M260ControlLoopL4s
               .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk && x.NrPzzw != Remove)
               .Count();
        }

        public int[] GetDailyRaport(DateTime dateTime, string model)
        {
            int[] partsShift = new int[3];

            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddHours(8);

            for (int i = 0; i < 3; i++)
            {
                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();

                partsShift[i] += context.M260ControlLoopL4s
                   .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo) && x.WynikOperacji == ResultOk && x.NrPzzw != Remove)
                   .Count();

                dateTimeFrom = dateTimeFrom.AddHours(8);
                dateTimeTo = dateTimeTo.AddHours(8);
            }

            return partsShift;
        }

        public int ActiveShift(string line, DateTime dateTime)
        {
            int shifts = 0;

            var dateTimeFrom = dateTime.Date;
            dateTimeFrom = dateTimeFrom.AddHours(6);
            var dateTimeTo = dateTime.Date;
            dateTimeTo = dateTimeTo.AddHours(14);

            var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
            var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();

            for (int i = 0; i < 3; i++)
            {
                var result = context.M260ControlLoopL4s
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.NrPzzw != Remove && x.WynikOperacji == ResultOk)
                   .Count();

                if (result > 10)
                {
                    shifts++;
                }

                dateTimeFrom = dateTimeFrom.AddHours(8);
                dateTimeTo = dateTimeTo.AddHours(8);

                frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
                frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();

            }

            return shifts;
        }
    }
}

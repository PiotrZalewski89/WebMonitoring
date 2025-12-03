
using System;
using System.Collections.Generic;
using System.Linq;
using WebMonitoring.DataBase;

namespace WebMonitoring.Models
{
    public class DbSetLineWS9
    {
        private StorageStationDbContext DbContext;

        private string ResultOk => "OK";
        private string Remove => "Remove";

        private string[] DescriptionWS9 = new string[]
       {
            "Cela spawalnicza nr1",
            "Cela spawalnicza nr2",
            "Cela spawalnicza nr3",
            "Cela spawalnicza nr4",
            "AutoLine 1",
            "AutoLine 2",
            "Kontrola Jakości 1",
            "Kontrola Jakości 2"
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
                    var result = Production.GetTarget(LineDescription.LineWS9);

                    if (result?.Length > 0)
                        target = result[0].Target;
                    else
                        target = DbProduction.DefaultTarget[11];
                }
                return target;
            }
            set
            {
                target = value;
                Production.SetTarget(LineDescription.LineWS9, target);
            }
        }

        public List<int> WeldingCell_1 { get; set; }
        public List<int> WeldingCell_2 { get; set; }
        public List<int> WeldingCell_3 { get; set; }
        public List<int> WeldingCell_4 { get; set; }
        public List<int> AL1 { get; set; }
        public List<int> AL2 { get; set; }
        public List<int> ControlLoopL1 { get; set; }
        public List<int> ControlLoopL2 { get; set; }



        public DbSetLineWS9(StorageStationDbContext ctx)
        {
            DbContext = ctx;
        }

        public void GetProductionCountPerHour(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTimeFrom.AddHours(1);

            _LineData = new Dictionary<string, List<int>>();

            WeldingCell_1 = new();
            WeldingCell_2 = new();
            WeldingCell_3 = new();
            WeldingCell_4 = new();
            AL1 = new();
            AL2 = new();
            ControlLoopL1 = new();
            ControlLoopL2 = new();


            for (int i = 0; i < 8; i++)
            {
                var frameTimeUtcFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                var frameTimeUtcTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();

                WeldingCell_1.Add(DbContext.Hr12ufWeldingCellL6s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii == "L1_STN1")
                   .Count());

                WeldingCell_2.Add(DbContext.Hr12ufWeldingCellL6s
                .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii == "L2_STN1")
                .Count());

                WeldingCell_3.Add(DbContext.Hr12ufWeldingCellL6s
                .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii == "L3_STN1")
                .Count());

                WeldingCell_4.Add(DbContext.Hr12ufWeldingCellL6s
                .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii == "L4_STN1")
                .Count());

                AL1.Add(DbContext.Hr12ufMarkingL6s
                  .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii == "L1")
                  .Count());

                ControlLoopL1.Add(DbContext.Hr12ufControlLoopL6s
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk && x.NrPzzw != Remove && x.NrLinii == "L1")
                   .Count());

                AL2.Add(DbContext.Hr12ufMarkingL6s
                  .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii == "L2")
                  .Count());

                ControlLoopL2.Add(DbContext.Hr12ufControlLoopL6s
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk && x.NrPzzw != Remove && x.NrLinii == "L2")
                   .Count());

                dateTimeFrom = dateTimeFrom.AddHours(1);
                dateTimeTo = dateTimeTo.AddHours(1);
            }

            WeldingCell_1.Add(WeldingCell_1.Sum());
            WeldingCell_2.Add(WeldingCell_2.Sum());
            WeldingCell_3.Add(WeldingCell_3.Sum());
            WeldingCell_4.Add(WeldingCell_4.Sum());
            AL1.Add(AL1.Sum());
            AL2.Add(AL2.Sum());
            ControlLoopL1.Add(ControlLoopL1.Sum());
            ControlLoopL2.Add(ControlLoopL2.Sum());


            _LineData.Add(DescriptionWS9[0], WeldingCell_1);
            _LineData.Add(DescriptionWS9[1], WeldingCell_2);
            _LineData.Add(DescriptionWS9[2], WeldingCell_3);
            _LineData.Add(DescriptionWS9[3], WeldingCell_4);
            _LineData.Add(DescriptionWS9[4], AL1);
            _LineData.Add(DescriptionWS9[5], AL2);
            _LineData.Add(DescriptionWS9[6], ControlLoopL1);
            _LineData.Add(DescriptionWS9[7], ControlLoopL2);
        }

        public int GetCountFromDayWS9(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddDays(1);

            var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc_AllDay();
            var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc_AllDay();

            return DbContext.Hr12ufFinalGaugeL6s
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

                partsShift[i] = DbContext.Hr12ufFinalGaugeL6s
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
                var result1 = DbContext.Hr12ufFinalGaugeL6s
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

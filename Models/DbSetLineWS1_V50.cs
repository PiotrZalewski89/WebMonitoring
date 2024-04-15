using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.DataBase;

namespace WebMonitoring.Models
{
    public class DbSetLineWS1_V50
    {
        private V50_DbContext context;

        private string ResultOk => "OK";
        private string Remove => "Remove";

        private string[] WS1 = new string[]
       {
            "Etap 1",
            "Preleak tester",
            "Sprawdzian geometrii",
            "Final leak tester",
            "Wkrętak",
            "Reprint",
            "Pętla KJ"
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
                    var result = Production.GetTarget(LineDescription.LineWS1V50);

                    if (result?.Length > 0)
                        target = result[0].Target;
                    else
                        target = DbProduction.DefaultTarget[1];
                }
                return target;
            }
            set
            {
                target = value;
                Production.SetTarget(LineDescription.LineWS1V50, target);
            }
        }

        public List<int> Etap1 { get; set; }

        public List<int> PLT { get; set; }

        public List<int> SprawdzianGeometrii { get; set; }

        public List<int> FLT { get; set; }

        public List<int> Wkretak { get; set; }

        public List<int> Reprint { get; set; }

        public List<int> PetlaKJ { get; set; }


        public DbSetLineWS1_V50(V50_DbContext ctx)
        {
            context = ctx;
        }

        public void GetProductionCountPerHour(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTimeFrom.AddHours(1);

            _LineData = new Dictionary<string, List<int>>();

            Etap1 = new List<int>();
            PLT = new List<int>();
            SprawdzianGeometrii = new List<int>();
            FLT = new List<int>();
            Wkretak = new List<int>();
            Reprint = new List<int>();
            PetlaKJ = new List<int>();

            for (int i = 0; i < 8; i++)
            {
                var frameTimeUtcFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                var frameTimeUtcTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();

                Etap1.Add(context.V50Etap1s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                Wkretak.Add(context.V50Torques
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                Reprint.Add(context.V50Reprints
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                PLT.Add(context.V50PreleakTesters
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                FLT.Add(context.V50FinalleakTesters
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                SprawdzianGeometrii.Add(context.V50Checkfixtures
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                PetlaKJ.Add(context.V50PetlaKontrolnaL1s
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk && x.NrPzzw != Remove)
                   .Count());

                dateTimeFrom = dateTimeFrom.AddHours(1);
                dateTimeTo = dateTimeTo.AddHours(1);
            }

            Etap1.Add(Etap1.Sum());
            Wkretak.Add(Wkretak.Sum());
            PLT.Add(PLT.Sum());
            Reprint.Add(Reprint.Sum());
            FLT.Add(FLT.Sum());
            SprawdzianGeometrii.Add(SprawdzianGeometrii.Sum());
            PetlaKJ.Add(PetlaKJ.Sum());

            _LineData.Add(WS1[0], Etap1);
            _LineData.Add(WS1[1], PLT);
            _LineData.Add(WS1[2], SprawdzianGeometrii);
            _LineData.Add(WS1[3], FLT);
            _LineData.Add(WS1[4], Wkretak);
            _LineData.Add(WS1[5], Reprint);
            _LineData.Add(WS1[6], PetlaKJ);
        }

        public int GetCountFromDayWS1(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddDays(1);

            var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc_AllDay();
            var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc_AllDay();

            return context.V50Torques
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

                partsShift[i] = context.V50Torques
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
                var result = context.V50Torques
               .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk)
               .Count();

                if (result > 0)
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

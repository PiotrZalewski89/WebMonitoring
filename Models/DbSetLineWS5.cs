using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.DataBase;

namespace WebMonitoring.Models
{
    public class DbSetLineWS5
    {
        private CnhDbContext context;

        private string ResultOk => "OK";
        private string Remove => "Remove";

        private string[] WS5 = new string[]
       {
            "Etap 1",
            "Etap 2",
            "Etap 3",
            "Preleak tester",
            "Final leak tester",
            "Etap 4",
            "Sprawdzian geometrii",
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
                    var result = Production.GetTarget(LineDescription.LineWS5);

                    if (result?.Length > 0)
                        target = result[0].Target;
                    else
                        target = DbProduction.DefaultTarget[5];
                }

                //FileJson json = new FileJson();
                //target = json.DeserializeFromFile<int>(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Target", @"\LiniaWs5.json");

                return target;
            }
            set
            {
                target = value;
                Production.SetTarget(LineDescription.LineWS5, target);
            }
        }

        public List<int> Etap1 { get; set; }

        public List<int> Etap2 { get; set; }

        public List<int> Etap3 { get; set; }

        public List<int> PLT { get; set; }

        public List<int> Etap4 { get; set; }

        public List<int> FLT { get; set; }

        public List<int> SprawdzianGeometrii { get; set; }

        public List<int> PetlaKJ { get; set; }


        public DbSetLineWS5(CnhDbContext ctx)
        {
            context = ctx;
        }

        public void GetProductionCountPerHour(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTimeFrom.AddHours(1);

            _LineData = new Dictionary<string, List<int>>();

            Etap1 = new List<int>();
            Etap2 = new List<int>();
            Etap3 = new List<int>();
            PLT = new List<int>();
            Etap4 = new List<int>();
            FLT = new List<int>();
            SprawdzianGeometrii = new List<int>();
            PetlaKJ = new List<int>();

            for (int i = 0; i < 8; i++)
            {
                var frameTimeUtcFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                var frameTimeUtcTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();

                Etap1.Add(context.CnhEtap1s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                Etap2.Add(context.CnhEtap2s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                Etap3.Add(context.CnhEtap3s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                Etap4.Add(context.CnhEtap4s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                PLT.Add(context.CnhPreleakTesters
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                FLT.Add(context.CnhFinalleakTesters
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                SprawdzianGeometrii.Add(context.CnhChecks
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                PetlaKJ.Add(context.Ws5CnhPetlaKontrolnaL1s
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk && x.NrPaleta != Remove)
                   .Count());

                dateTimeFrom = dateTimeFrom.AddHours(1);
                dateTimeTo = dateTimeTo.AddHours(1);
            }

            Etap1.Add(Etap1.Sum());
            Etap2.Add(Etap2.Sum());
            Etap3.Add(Etap3.Sum());
            PLT.Add(PLT.Sum());
            Etap4.Add(Etap4.Sum());
            FLT.Add(FLT.Sum());
            SprawdzianGeometrii.Add(SprawdzianGeometrii.Sum());
            PetlaKJ.Add(PetlaKJ.Sum());

            _LineData.Add(WS5[0], Etap1);
            _LineData.Add(WS5[1], Etap2);
            _LineData.Add(WS5[2], Etap3);
            _LineData.Add(WS5[3], PLT);
            _LineData.Add(WS5[4], FLT);
            _LineData.Add(WS5[5], Etap4);
            _LineData.Add(WS5[6], SprawdzianGeometrii);
            _LineData.Add(WS5[7], PetlaKJ);
        }

        public int GetCountFromDayWS5(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddDays(1);

            return context.CnhChecks
               .Where(x => (x.DtOperacji >= dateTimeFrom && x.DtOperacji < dateTimeTo) && x.WynikOperacji == ResultOk)
               .Count();
        }

        public int[] GetDailyRaport(DateTime dateTime)
        {
            int[] partsShift = new int[3];

            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddHours(8);

            for (int i = 0; i < 3; i++)
            {

                partsShift[i] = context.CnhChecks
                   .Where(x => (x.DtOperacji >= dateTimeFrom && x.DtOperacji < dateTimeTo) && x.WynikOperacji == ResultOk)
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
                var result = context.CnhChecks
               .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk)
               .Count();

                int range = Target > 0 ? Convert.ToInt32(Math.Ceiling(Target * 0.05)) : 0;

                if (result > 1)
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

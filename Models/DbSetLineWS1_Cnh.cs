using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.DataBase;

namespace WebMonitoring.Models
{
    public class DbSetLineWS1_Cnh
    {
        private CnhDbContext context;

        private string ResultOk => "OK";
        private string Remove => "Remove";

        private string[] WS1 = new string[]
       {
            "Etap 1",
            "Leak tester Etap 1",
            "Składanie osłon",
            "Leak tester Etap 2",
            "Final leak tester",
            "Czyszczenie",
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
                    var result = Production.GetTarget(LineDescription.LineWS1CNH);

                    if (result?.Length > 0)
                        target = result[0].Target;
                    else
                        target = DbProduction.DefaultTarget[0];
                }

                //FileJson json = new FileJson();
                //target = json.DeserializeFromFile<int>(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Target", @"\LiniaWs1Cnh.json");
                return target;
            }
            set
            {
                target = value;
                Production.SetTarget(LineDescription.LineWS1CNH, target);
            }
        }

        public List<int> Etap1 { get; set; }
        public List<int> LT_Etap1 { get; set; }
        public List<int> SkaldanieOslon { get; set; }
        public List<int> LT_Etap2 { get; set; }
        public List<int> FLT { get; set; }

        public List<int> Czyszczenie { get; set; }

        public List<int> PetlaKJ { get; set; }


        public DbSetLineWS1_Cnh(CnhDbContext ctx)
        {
            context = ctx;
        }

        public void GetProductionCountPerHour(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTimeFrom.AddHours(1);

            _LineData = new Dictionary<string, List<int>>();

            Etap1 = new List<int>();
            LT_Etap1 = new List<int>();
            SkaldanieOslon = new List<int>();
            LT_Etap2 = new List<int>();
            FLT = new List<int>();
            Czyszczenie = new List<int>();
            PetlaKJ = new List<int>();

            for (int i = 0; i < 8; i++)
            {
                var frameTimeUtcFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                var frameTimeUtcTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();

                Etap1.Add(context.Ws1CnhEtap1s
                  .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk)
                  .Count());

                LT_Etap1.Add(context.Ws1CnhLeakTesterEtap1s
                  .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk)
                  .Count());

                SkaldanieOslon.Add(context.Ws1CnhSkladanieOslons
                  .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk)
                  .Count());

                LT_Etap2.Add(context.Ws1CnhLeakTesterEtap2s
                  .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk)
                  .Count());

                FLT.Add(context.Ws1CnhFinalLeaktesterL3s
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk)
                   .Count());

                Czyszczenie.Add(context.Ws1CnhCleaningL3s
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk && x.NrPaleta != Remove)
                   .Count());

                PetlaKJ.Add(context.Ws1CnhPetlaKontrolnaL3s
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk && x.NrPaleta != Remove)
                   .Count());

                dateTimeFrom = dateTimeFrom.AddHours(1);
                dateTimeTo = dateTimeTo.AddHours(1);
            }

            Etap1.Add(Etap1.Sum());
            LT_Etap1.Add(LT_Etap1.Sum());
            SkaldanieOslon.Add(SkaldanieOslon.Sum());
            LT_Etap2.Add(LT_Etap2.Sum());
            FLT.Add(FLT.Sum());
            Czyszczenie.Add(Czyszczenie.Sum());
            PetlaKJ.Add(PetlaKJ.Sum());

            _LineData.Add(WS1[0], Etap1);
            _LineData.Add(WS1[1], LT_Etap1);
            _LineData.Add(WS1[2], SkaldanieOslon);
            _LineData.Add(WS1[3], LT_Etap2);
            _LineData.Add(WS1[4], FLT);
            _LineData.Add(WS1[5], Czyszczenie);
            _LineData.Add(WS1[6], PetlaKJ);
        }

        public int GetCountFromDayWS1(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddDays(1);

            var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime_AllDay();
            var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime_AllDay();

            return context.Ws1CnhCleaningL3s
               .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk && x.NrPaleta != Remove)
               .Count();
        }

        public int[] GetDailyRaport(DateTime dateTime)
        {
            int[] partsShift = new int[3];

            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddHours(8);

            for (int i = 0; i < 3; i++)
            {
                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();

                partsShift[i] = context.Ws1CnhCleaningL3s
                   .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo) && x.WynikOperacji == ResultOk && x.NrPaleta != Remove)
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

            var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
            var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();

            for (int i = 0; i < 3; i++)
            {
                var result = context.Ws1CnhCleaningL3s
               .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.NrPaleta != Remove && x.WynikOperacji == ResultOk)
               .Count();

                int range = Target > 0 ? Convert.ToInt32(Math.Ceiling(Target * 0.05)) : 0;

                if (result > range)
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

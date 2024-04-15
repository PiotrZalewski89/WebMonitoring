using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.DataBase;

namespace WebMonitoring.Models
{
    public class DbSetLineWS6
    {
        private CnhDbContext context;
        private string ResultOk => "OK";
        private string Remove => "Remove";

        private string[] WS6= new string[]
       {
            "Etap 1",
            "Etap 2",
            "Preleak tester sekcja A",
            "Preleak tester sekcja B",
            "Etap 3",
            "Etap 4",
            "Final leak tester",
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
                    var result = Production.GetTarget(LineDescription.LineWS6);

                    if (result?.Length > 0)
                        target = result[0].Target;
                    else
                        target = DbProduction.DefaultTarget[6];
                }
                //FileJson json = new FileJson();
                //target = json.DeserializeFromFile<int>(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Target", @"\LiniaWs6.json");

                return target;
            }
            set
            {
                target = value;
                Production.SetTarget(LineDescription.LineWS6, target);
            }
        }

        public List<int> Etap1 { get; set; }

        public List<int> Etap2 { get; set; }

        public List<int> Etap3 { get; set; }

        public List<int> Etap4 { get; set; }

        public List<int> PLTA { get; set; 
        }
        public List<int> PLTB { get; set; }

        public List<int> FLT { get; set; }

        public List<int> SprawdzianGeometrii { get; set; }

        public List<int> PetlaKJ { get; set; }


        public DbSetLineWS6(CnhDbContext ctx)
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
            Etap4 = new List<int>();
            PLTA = new List<int>();
            PLTB = new List<int>();
            FLT = new List<int>();
            SprawdzianGeometrii = new List<int>();
            PetlaKJ = new List<int>();

            for (int i = 0; i < 8; i++)
            {
                var frameTimeUtcFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                var frameTimeUtcTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();

                Etap1.Add(context.Cnh529Etap3s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                Etap2.Add(context.Cnh529Etap3s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                Etap3.Add(context.Cnh529Etap3s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                Etap4.Add(context.Cnh529Etap4s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                PLTA.Add(context.Cnh529PreleakTesterSekcjaAs
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                PLTB.Add(context.Cnh529PreleakTesterSekcjaBs
                  .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                  .Count());

                FLT.Add(context.Cnh529FinalleakTesters
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                SprawdzianGeometrii.Add(context.Cnh529Checks
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                PetlaKJ.Add(context.Ws6CnhPetlaKontrolnaL2s
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk && x.NrPaleta != Remove)
                   .Count());

                dateTimeFrom = dateTimeFrom.AddHours(1);
                dateTimeTo = dateTimeTo.AddHours(1);
            }

            Etap1.Add(Etap1.Sum());
            Etap2.Add(Etap2.Sum());
            Etap3.Add(Etap3.Sum());
            PLTA.Add(PLTA.Sum());
            PLTB.Add(PLTB.Sum());
            Etap4.Add(Etap4.Sum());
            FLT.Add(FLT.Sum());
            SprawdzianGeometrii.Add(SprawdzianGeometrii.Sum());
            PetlaKJ.Add(PetlaKJ.Sum());

            _LineData.Add(WS6[0], Etap1);
            _LineData.Add(WS6[1], Etap2);
            _LineData.Add(WS6[2], PLTA);
            _LineData.Add(WS6[3], PLTB);
            _LineData.Add(WS6[4], Etap3);
            _LineData.Add(WS6[5], Etap4);
            _LineData.Add(WS6[6], FLT);
            _LineData.Add(WS6[7], SprawdzianGeometrii);
            _LineData.Add(WS6[8], PetlaKJ);
        }

        public int GetCountFromDayWS6(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddDays(1);

            return context.Cnh529Checks
               .Where(x => x.DtOperacji >= dateTimeFrom && x.DtOperacji < dateTimeTo && x.WynikOperacji == ResultOk)
               .Count();
        }

        public int[] GetDailyRaport(DateTime dateTime)
        {
            int[] partsShift = new int[3];

            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddHours(8);

            for (int i = 0; i < 3; i++)
            {
                partsShift[i] = context.Cnh529Checks
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
                var result = context.Cnh529Checks
               .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk)
               .Count();

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

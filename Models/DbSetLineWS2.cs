
using System;
using System.Collections.Generic;
using System.Linq;
using WebMonitoring.DataBase;

namespace WebMonitoring.Models
{
    public class DbSetLineWS2
    {
        private StorageStationDbContext DbContext;

        private string ResultOk => "OK";
        private string Remove => "Remove";
        private string L1 => "L1";
        private string L1_D2 => "L1_D2";
        private string L2_D1 => "L2_D1";

        private string[] DescriptionWS2 = new string[]
       {
            "Cela 1 Lp2",
            "Cela 2 Lp2",
            "Cela 2 Lp1",
            "Preleak tester",
            "Znakowanie osłony",
            "Cela 3 Lp2 / 4 Lp1",
            "Final leak tester",
            "Sprawdzian geometrii",
            "Odkurzacz",
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
                    var result = Production.GetTarget(LineDescription.LineWS2);

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
                Production.SetTarget(LineDescription.LineWS2, target);
            }
        }

        public List<int> Cela1Lp2 { get; set; }

        public List<int> Cela2Lp2 { get; set; }

        public List<int> Cela2Lp1 { get; set; }

        public List<int> PLT { get; set; }
        public List<int> Marking { get; set; }
        public List<int> Cela3 { get; set; }

        public List<int> FLT { get; set; }

        public List<int> SprawdzianGeometrii { get; set; }

        public List<int> Odkurzacz { get; set; }

        public List<int> PetlaKJ { get; set; }


        public DbSetLineWS2(StorageStationDbContext ctx)
        {
            DbContext = ctx;
        }

        public void GetProductionCountPerHour(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTimeFrom.AddHours(1);

            _LineData = new Dictionary<string, List<int>>();

            Cela1Lp2 = new List<int>();
            Cela2Lp2 = new List<int>();
            Cela2Lp1 = new List<int>();
            PLT = new List<int>();
            Marking = new List<int>();
            Cela3 = new List<int>();
            FLT = new List<int>();
            SprawdzianGeometrii = new List<int>();
            Odkurzacz = new List<int>();
            PetlaKJ = new List<int>();

            for (int i = 0; i < 8; i++)
            {
                var frameTimeUtcFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                var frameTimeUtcTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();

                Cela1Lp2.Add(DbContext.VCela1And2Hr16L3Monitorings
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii == L1)
                   .Count());

                Cela2Lp2.Add(DbContext.VCela1And2Hr16L3Monitorings
                   .Where(x => x.FrameTime2 >= frameTimeUtcFrom && x.FrameTime2 < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii == L1_D2)
                   .Count());

                Cela2Lp1.Add(DbContext.VCela1And2Hr16L3Monitorings
                      .Where(x => x.FrameTime3 >= frameTimeUtcFrom && x.FrameTime3 < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii == L2_D1)
                      .Count());

                var c1 = DbContext.VCela3Hr16L3Monitorings
                .Where(x => (x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo) && x.WynikOperacji == ResultOk)
                .Count();

                var c2 = DbContext.VCela3Hr16L3Monitorings
                   .Where(x => (x.FrameTime2 >= frameTimeUtcFrom && x.FrameTime2 < frameTimeUtcTo) && x.WynikOperacji == ResultOk)
                   .Count();

                var c3 = DbContext.VCela3Hr16L3Monitorings
                  .Where(x => (x.FrameTime3 >= frameTimeUtcFrom && x.FrameTime3 < frameTimeUtcTo) && x.WynikOperacji == ResultOk)
                  .Count();

                var c4 = DbContext.VCela3Hr16L3Monitorings
                .Where(x => (x.FrameTime4 >= frameTimeUtcFrom && x.FrameTime4 < frameTimeUtcTo) && x.WynikOperacji == ResultOk)
                .Count();

                Cela3.Add(c1 + c2 + c3 + c4);

                //Cela3.Add(await context.VCela3Hr16L3Monitorings
                //   .Where(x => ((x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo) || (x.FrameTime2 >= frameTimeUtcFrom && x.FrameTime2 < frameTimeUtcTo)) && x.WynikOperacji == ResultOk)
                //   .CountAsync());

                var plt1 = DbContext.VPreleaktesterHr16L3Monitoirngs
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikTestu == ResultOk && string.IsNullOrEmpty(x.NrGrawerka))
                   .GroupBy(x => x.NrShella)
                   .Count();

                var plt2 = DbContext.VPreleaktesterHr16L3Monitoirngs
                   .Where(x => x.FrameTime2 >= frameTimeUtcFrom && x.FrameTime2 < frameTimeUtcTo && x.WynikTestu == ResultOk && string.IsNullOrEmpty(x.NrGrawerka))
                   .GroupBy(x => x.NrShella)
                   .Count();

                PLT.Add(plt1 + plt2);

                //PLT2.Add(context.VPreleaktesterHr16L3Monitoirngs
                //   .Where(x => x.FrameTime2 >= frameTimeUtcFrom && x.FrameTime2 < frameTimeUtcTo && x.WynikTestu == ResultOk && x.NrLinii == L1_D2)
                //   .Count());

                var m1 = DbContext.PreleaktesterHr16L3s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikTestu == ResultOk && !string.IsNullOrEmpty(x.NrGrawerka))
                   .Count();

                var m2 = DbContext.PreleaktesterHr16L3s
                   .Where(x => x.FrameTime2 >= frameTimeUtcFrom && x.FrameTime2 < frameTimeUtcTo && x.WynikTestu == ResultOk && !string.IsNullOrEmpty(x.NrGrawerka))
                   .Count();

                Marking.Add(m1 + m2);

                FLT.Add(DbContext.VFinalLeaktesterHr16L3Monitorings
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikTestu == ResultOk)
                   .Count());

                SprawdzianGeometrii.Add(DbContext.VFinalGaugeHr16L3Monitorings
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                var vc1 = DbContext.VOdkurzaczHr16L3Monitorings
                   .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo) && x.WynikOperacji == ResultOk)
                   .GroupBy(x => x.NrGrawerka)
                   .Count();

                var vc2 = DbContext.VOdkurzaczHr16L3Monitorings
                   .Where(x => (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo) && x.WynikOperacji == ResultOk)
                   .GroupBy(x => x.NrGrawerka)
                   .Count();

                Odkurzacz.Add(vc1 + vc2);

                //Odkurzacz.Add(await context.VOdkurzaczHr16L3Monitorings
                //.Where(x => ((x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo) || (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo)) && x.WynikOperacji == ResultOk)
                //.CountAsync());

                PetlaKJ.Add(DbContext.VPetlaKontrolnaHr16L3Monitorings
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk && x.NrPaleta != Remove)
                   .Count());

                dateTimeFrom = dateTimeFrom.AddHours(1);
                dateTimeTo = dateTimeTo.AddHours(1);
            }

            Cela1Lp2.Add(Cela1Lp2.Sum());
            Cela2Lp2.Add(Cela2Lp2.Sum());
            Cela2Lp1.Add(Cela2Lp1.Sum());
            PLT.Add(PLT.Sum());
            Marking.Add(Marking.Sum());
            Cela3.Add(Cela3.Sum());
            FLT.Add(FLT.Sum());
            SprawdzianGeometrii.Add(SprawdzianGeometrii.Sum());
            Odkurzacz.Add(Odkurzacz.Sum());
            PetlaKJ.Add(PetlaKJ.Sum());

            _LineData.Add(DescriptionWS2[0], Cela1Lp2);
            _LineData.Add(DescriptionWS2[1], Cela2Lp2);
            _LineData.Add(DescriptionWS2[2], Cela2Lp1);
            _LineData.Add(DescriptionWS2[3], PLT);
            _LineData.Add(DescriptionWS2[4], Marking);
            _LineData.Add(DescriptionWS2[5], Cela3);
            _LineData.Add(DescriptionWS2[6], FLT);
            _LineData.Add(DescriptionWS2[7], SprawdzianGeometrii);
            _LineData.Add(DescriptionWS2[8], Odkurzacz);
            _LineData.Add(DescriptionWS2[9], PetlaKJ);
        }

        public int GetCountFromDayWS2(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddDays(1);

            var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc_AllDay();
            var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc_AllDay();

            return DbContext.VFinalGaugeHr16L3Monitorings
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

                partsShift[i] = DbContext.VFinalGaugeHr16L3Monitorings
                   .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo) && x.WynikOperacji == ResultOk)
                   .Count();

                dateTimeFrom = dateTimeFrom.AddHours(8);
                dateTimeTo = dateTimeTo.AddHours(8);
            }


            dateTimeFrom = dateTime;
            dateTimeTo = dateTime.AddHours(8);

            for (int i = 0; i < 3; i++)
            {
                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

                partsShift[i] += DbContext.VFinalGaugeHr16L3Monitorings
                   .Where(x => (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo) && x.WynikOperacji == ResultOk)
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
                var result1 = DbContext.VFinalGaugeHr16L3Monitorings
               .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo) && x.WynikOperacji == ResultOk)
               .Count();

                var result2 = DbContext.VFinalGaugeHr16L3Monitorings
               .Where(x => (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo) && x.WynikOperacji == ResultOk)
               .Count();

                if (result1 > 10 || result2 > 10)
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

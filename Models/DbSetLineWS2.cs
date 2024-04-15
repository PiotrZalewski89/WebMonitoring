using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.DataBase;

namespace WebMonitoring.Models
{
    public class DbSetLineWS2
    {
        private StorageStationDbContext context;

        private string ResultOk => "OK";
        private string Remove => "Remove";
        private string L1 => "L1";
        private string L1_D2 => "L1_D2";

        private string[] DescriptionWS2 = new string[]
       {
            "Cela 1",
            "Cela 2",
            "Preleak tester nr1",
            "Preleak tester nr2",
            "Cela 3",
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

        public List<int> Cela1 { get; set; }

        public List<int> Cela2 { get; set; }

        public List<int> PLT1 { get; set; }

        public List<int> PLT2 { get; set; }

        public List<int> Cela3 { get; set; }

        public List<int> FLT { get; set; }

        public List<int> SprawdzianGeometrii { get; set; }

        public List<int> Odkurzacz { get; set; }

        public List<int> PetlaKJ { get; set; }


        public DbSetLineWS2(StorageStationDbContext ctx)
        {
            context = ctx;
        }

        public void GetProductionCountPerHour(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTimeFrom.AddHours(1);

            _LineData = new Dictionary<string, List<int>>();

            Cela1 = new List<int>();
            Cela2 = new List<int>();
            PLT1 = new List<int>();
            PLT2 = new List<int>();
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

                Cela1.Add(context.VCela1And2Hr16L3Monitorings
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii == L1)
                   .Count());

                Cela2.Add(context.VCela1And2Hr16L3Monitorings
                   .Where(x => x.FrameTime2 >= frameTimeUtcFrom && x.FrameTime2 < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii == L1_D2)
                   .Count());

                var c1 = context.VCela3Hr16L3Monitorings
                .Where(x => (x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo) && x.WynikOperacji == ResultOk)
                .Count();

                var c2 = context.VCela3Hr16L3Monitorings
                   .Where(x => (x.FrameTime2 >= frameTimeUtcFrom && x.FrameTime2 < frameTimeUtcTo) && x.WynikOperacji == ResultOk)
                   .Count();

                Cela3.Add(c1 + c2);

                //Cela3.Add(await context.VCela3Hr16L3Monitorings
                //   .Where(x => ((x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo) || (x.FrameTime2 >= frameTimeUtcFrom && x.FrameTime2 < frameTimeUtcTo)) && x.WynikOperacji == ResultOk)
                //   .CountAsync());

                PLT1.Add(context.VPreleaktesterHr16L3Monitoirngs
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikTestu == ResultOk && x.NrLinii == L1)
                   .Count());

                PLT2.Add(context.VPreleaktesterHr16L3Monitoirngs
                   .Where(x => x.FrameTime2 >= frameTimeUtcFrom && x.FrameTime2 < frameTimeUtcTo && x.WynikTestu == ResultOk && x.NrLinii == L1_D2)
                   .Count());

                FLT.Add(context.VFinalLeaktesterHr16L3Monitorings
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikTestu == ResultOk)
                   .Count());

                SprawdzianGeometrii.Add(context.VFinalGaugeHr16L3Monitorings
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                var vc1 = context.VOdkurzaczHr16L3Monitorings
                   .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo) && x.WynikOperacji == ResultOk)
                   .Count();

                var vc2 = context.VOdkurzaczHr16L3Monitorings
                   .Where(x => (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo) && x.WynikOperacji == ResultOk)
                   .Count();

                Odkurzacz.Add(vc1 + vc2);

                //Odkurzacz.Add(await context.VOdkurzaczHr16L3Monitorings
                //.Where(x => ((x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo) || (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo)) && x.WynikOperacji == ResultOk)
                //.CountAsync());

                PetlaKJ.Add(context.VPetlaKontrolnaHr16L3Monitorings
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk && x.NrPaleta != Remove)
                   .Count());

                dateTimeFrom = dateTimeFrom.AddHours(1);
                dateTimeTo = dateTimeTo.AddHours(1);
            }

            Cela1.Add(Cela1.Sum());
            Cela2.Add(Cela2.Sum());
            PLT1.Add(PLT1.Sum());
            PLT2.Add(PLT2.Sum());
            Cela3.Add(Cela3.Sum());
            FLT.Add(FLT.Sum());
            SprawdzianGeometrii.Add(SprawdzianGeometrii.Sum());
            Odkurzacz.Add(Odkurzacz.Sum());
            PetlaKJ.Add(PetlaKJ.Sum());

            _LineData.Add(DescriptionWS2[0], Cela1);
            _LineData.Add(DescriptionWS2[1], Cela2);
            _LineData.Add(DescriptionWS2[2], PLT1);
            _LineData.Add(DescriptionWS2[3], PLT2);
            _LineData.Add(DescriptionWS2[4], Cela3);
            _LineData.Add(DescriptionWS2[5], FLT);
            _LineData.Add(DescriptionWS2[6], SprawdzianGeometrii);
            _LineData.Add(DescriptionWS2[7], Odkurzacz);
            _LineData.Add(DescriptionWS2[8], PetlaKJ);
        }

        public int GetCountFromDayWS2(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddDays(1);

            var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime_AllDay();
            var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime_AllDay();

            return context.VPetlaKontrolnaHr16L3Monitorings
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

                partsShift[i] = context.VPetlaKontrolnaHr16L3Monitorings
                   .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo) && x.WynikOperacji == ResultOk && x.NrPaleta != Remove)
                   .Count();

                dateTimeFrom = dateTimeFrom.AddHours(8);
                dateTimeTo = dateTimeTo.AddHours(8);
            }


            dateTimeFrom = dateTime;
            dateTimeTo = dateTime.AddHours(8);

            for (int i = 0; i < 3; i++)
            {
                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();

                partsShift[i] += context.VPetlaKontrolnaHr16L3Monitorings
                   .Where(x => (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo) && x.WynikOperacji == ResultOk && x.NrPaleta != Remove)
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
                var result1 = context.VPetlaKontrolnaHr16L3Monitorings
               .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo) && x.NrPaleta != Remove && x.WynikOperacji == ResultOk)
               .Count();

                var result2 = context.VPetlaKontrolnaHr16L3Monitorings
               .Where(x => (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo) && x.NrPaleta != Remove && x.WynikOperacji == ResultOk)
               .Count();

                if (result1 > 10 || result2 > 10)
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

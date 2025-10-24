using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.DataBase;

namespace WebMonitoring.Models
{
    public class DbSetLineWS3Hr12CC
    {
        private StorageStationDbContext context;
        private ProductionDbContext dpContext;

        private string ResultOk => "OK";
        private string Remove => "Remove";

        private string[] DescriptionWS3A = new string[8]
        {
            "Cela 0 LP1",
            "Cela 1 LP1",
            "Cela 1 LP2",
            "Cela 2 LP1",
            "Cela 2 LP2",
            "Cela 1 LP1 GPF",
            "Cela 2 LP1 GPF",
            "Cela 1 LP2 RURKI"
        };

        private string[] DescriptionWS3BLP1 = new string[]
        {
            "Sizer wlot",
            "Sizer wylot",
            "Cela 3 - wlot",
            "Cela 4 - wylot",
            "Preleak tester",
            "Enkapsulacja",
            "Wkrętak",
            "Homologacja",
            "Final leak tester",
            "Deflector",
            "Sprawdzian geometrii",
            "Odkurzacz",
            "Kontrola Jakościowa"
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
                    var result = Production.GetTarget(LineDescription.LineWS3Hr12CC);

                    if (result?.Length > 0)
                        target = result[0].Target;
                    else
                        target = DbProduction.DefaultTarget[13];
                }

                //FileJson json = new FileJson();
                //target = json.DeserializeFromFile<int>(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Target", @"\LiniaWs3.json");

                return target;
            }
            set
            {
                target = value;
                Production.SetTarget(LineDescription.LineWS3Hr12CC, target);
            }
        }      

        //WS3B 
        public List<int> SizerInlet { get; set; }
        public List<int> SizerOutlet { get; set; }
        public List<int> Cela3_Inlet { get; set; }
        public List<int> Cela4_Outlet { get; set; }

        public List<int> PLT { get; set; }

        public List<int> Enkapsulacja { get; set; }

        public List<int> Wkretak { get; set; }

        public List<int> Homologacja { get; set; }

        public List<int> FLT { get; set; }
        public List<int> Deflector { get; set; }

        public List<int> SprawdzianGeometrii { get; set; }

        public List<int> Odkurzacz { get; set; }

        public List<int> CL { get; set; }

       
        public DbSetLineWS3Hr12CC(StorageStationDbContext ctx, ProductionDbContext dpCtx)
        {
            context = ctx;
            dpContext = dpCtx;
        }
        public DbSetLineWS3Hr12CC(StorageStationDbContext ctx)
        {
            context = ctx;
        }

        public DbSetLineWS3Hr12CC(ProductionDbContext dpCtx)
        {
            dpContext = dpCtx;
        }

        public void GetProductionCountPerHour(DateTime dateTime, string line)
        {
            _LineData = new Dictionary<string, List<int>>();

            if (line == LineDescription.LineWS3Hr12CC)
            {
                GetProductionCountPerHourWS3B(dateTime);
            }
        }

        private void GetProductionCountPerHourWS3B(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTimeFrom.AddHours(1);

            SizerInlet = new List<int>();
            SizerOutlet = new List<int>();
            Cela3_Inlet = new List<int>();
            Cela4_Outlet = new List<int>();
            PLT = new List<int>();
            Enkapsulacja = new List<int>();
            Wkretak = new List<int>();
            Homologacja = new List<int>();
            FLT = new List<int>();
            Deflector = new List<int>();
            SprawdzianGeometrii = new List<int>();
            Odkurzacz = new List<int>();
            CL = new List<int>();

            for (int i = 0; i < 8; i++)
            {
                var frameTimeUtcFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                var frameTimeUtcTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();

                SizerInlet.Add(context.Hr12ccSizerGbdInletL7s
                 .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                 .Count());

                SizerOutlet.Add(context.Hr12ccSizerGbdOutletL7s
                 .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                 .Count());

                Cela3_Inlet.Add(context.Hr12ccCell3L7s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                Cela4_Outlet.Add(context.Hr12ccCell4L7s
                 .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                 .Count());

                PLT.Add(context.Hr12ccPreleakTesterL7s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikTestu == ResultOk)
                   .Count());

                Enkapsulacja.Add(context.Hr12ccOutletPressL7s
                 .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                 .Count());

                Wkretak.Add(context.Hr12ccTorqueScrewdriverL7s
                 .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                 .Count());

                Homologacja.Add(context.Hr12ccHomologationL7s
                 .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                 .Count());

                FLT.Add(context.Hr12ccFinalleakTesterL7s
                 .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikTestu == ResultOk)
                 .Count());

                Deflector.Add(context.Hr12ccDeflectorL7s
                 .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                 .Count());

                SprawdzianGeometrii.Add(context.Hr12ccCheckFixtureL7s
                 .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                 .Count());

                Odkurzacz.Add(context.Hr12ccVacuumCleanerL7s
                 .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                 .Count());

                CL.Add(context.Hr12ccControlLoopL7s
                 .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk)
                 .Count());

                dateTimeFrom = dateTimeFrom.AddHours(1);
                dateTimeTo = dateTimeTo.AddHours(1);
            }

            SizerInlet.Add(SizerInlet.Sum());
            SizerOutlet.Add(SizerOutlet.Sum());
            Cela3_Inlet.Add(Cela3_Inlet.Sum());
            Cela4_Outlet.Add(Cela4_Outlet.Sum());
            PLT.Add(PLT.Sum());
            Enkapsulacja.Add(Enkapsulacja.Sum());
            Wkretak.Add(Wkretak.Sum());
            Homologacja.Add(Homologacja.Sum());
            FLT.Add(FLT.Sum());
            Deflector.Add(Deflector.Sum());
            SprawdzianGeometrii.Add(SprawdzianGeometrii.Sum());
            Odkurzacz.Add(Odkurzacz.Sum());
            CL.Add(CL.Sum());

            _LineData.Add(DescriptionWS3BLP1[0], SizerInlet);
            _LineData.Add(DescriptionWS3BLP1[1], SizerOutlet);
            _LineData.Add(DescriptionWS3BLP1[2], Cela3_Inlet);
            _LineData.Add(DescriptionWS3BLP1[3], Cela4_Outlet);
            _LineData.Add(DescriptionWS3BLP1[4], PLT);
            _LineData.Add(DescriptionWS3BLP1[5], Enkapsulacja);
            _LineData.Add(DescriptionWS3BLP1[6], Wkretak);
            _LineData.Add(DescriptionWS3BLP1[7], Homologacja);
            _LineData.Add(DescriptionWS3BLP1[8], FLT);
            _LineData.Add(DescriptionWS3BLP1[9], Deflector);
            _LineData.Add(DescriptionWS3BLP1[10], SprawdzianGeometrii);
            _LineData.Add(DescriptionWS3BLP1[11], Odkurzacz);
            _LineData.Add(DescriptionWS3BLP1[12], CL);
        }

        public int GetCountFromDayWS3B(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddDays(1);

            var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime_AllDay();
            var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime_AllDay();

            return context.Hr12ccCheckFixtureL7s
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

                partsShift[i] = context.Hr12ccCheckFixtureL7s
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

            for(int i = 0; i < 3; i++)
            {
                var result = context.Hr12ccCheckFixtureL7s
                   .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo) && x.WynikOperacji == ResultOk)
                   .Count();

                if (result > 10)
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

        public void Clear()
        {
            _LineData.Clear();

            SizerInlet.Clear();
            SizerOutlet.Clear();
            Cela3_Inlet.Clear();
            Cela4_Outlet.Clear();
            PLT.Clear();
            Enkapsulacja.Clear();
            Wkretak.Clear();
            Homologacja.Clear();
            FLT.Clear();
            Deflector.Clear();
            SprawdzianGeometrii.Clear();
            Odkurzacz.Clear();
            CL.Clear();
        }
    }
}

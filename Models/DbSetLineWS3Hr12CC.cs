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

        private string[] DescriptionHR12CC = new string[]
        {
            "Cela spawalnicza - Basic wlot",
            "Cela spawalnicza - Midclamshell",
            "Sizer wlot",
            "Cela spawalnicza - Basic wlot + midlamshell",
            "Cela spawalnicza - Basic wylot",
            "Sizer wylot",
            "Cela spawalnicza - Basic wlot - midclamshell + wylot",
            "Preleak tester",
            "Enkapsulacja",
            "Wkrętak",
            "Homologacja",
            "Final leak tester",
            "Deflector",
            "Deflecotr gauge",
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
        public List<int> Cela_BasicInlet { get; set; }
        public List<int> Cela_Midlamshell { get; set; }
        public List<int> Cela_BasicInlet_Midlamshell { get; set; }
        public List<int> Cela_BasicOutlet { get; set; }
        public List<int> Cela_BasicInletMidclamshell_BasicOutlet { get; set; }
        public List<int> PLT { get; set; }
        public List<int> Enkapsulacja { get; set; }
        public List<int> Wkretak { get; set; }
        public List<int> Homologacja { get; set; }
        public List<int> FLT { get; set; }
        public List<int> Deflector { get; set; }
        public List<int> DeflectorGauge { get; set; }
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
            Cela_BasicInlet = new List<int>();
            Cela_Midlamshell = new List<int>();
            Cela_BasicInlet_Midlamshell = new List<int>();
            Cela_BasicOutlet = new List<int>();
            Cela_BasicInletMidclamshell_BasicOutlet = new List<int>();
            PLT = new List<int>();
            Enkapsulacja = new List<int>();
            Wkretak = new List<int>();
            Homologacja = new List<int>();
            FLT = new List<int>();
            Deflector = new List<int>();
            DeflectorGauge = new List<int>();
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

                Cela_BasicInlet.Add(context.Hr12ccWeldingCellInletBasicClamshellOp3L7s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                Cela_Midlamshell.Add(context.Hr12ccWeldingCellMidclamshellOp7L7s
                     .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                     .Count());

                Cela_BasicInlet_Midlamshell.Add(context.Hr12ccWeldingCellIntletBasicMidclamshellOp8L7s
                    .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                    .Count());

                Cela_BasicOutlet.Add(context.Hr12ccWeldingCellOutletBasicClamshellOp6L7s
                  .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                  .Count());

                Cela_BasicOutlet.Add(context.Hr12ccWeldingCellOutletBasicClamshellOp6L7s
                  .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                  .Count());

                Cela_BasicInletMidclamshell_BasicOutlet.Add(context.Hr12ccWeldingCellInletOutletBasicMidclamshellL7s
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

                DeflectorGauge.Add(context.Hr12ccDeflectorGaugeL7s
                 .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
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

            Cela_BasicInlet.Add(Cela_BasicInlet.Sum());
            Cela_Midlamshell.Add(Cela_Midlamshell.Sum());
            SizerInlet.Add(SizerInlet.Sum());
            Cela_BasicInlet_Midlamshell.Add(Cela_BasicInlet_Midlamshell.Sum());
            Cela_BasicOutlet.Add(Cela_BasicOutlet.Sum());
            SizerOutlet.Add(SizerOutlet.Sum());
            Cela_BasicInletMidclamshell_BasicOutlet.Add(Cela_BasicInletMidclamshell_BasicOutlet.Sum());
            PLT.Add(PLT.Sum());
            Enkapsulacja.Add(Enkapsulacja.Sum());
            Wkretak.Add(Wkretak.Sum());
            Homologacja.Add(Homologacja.Sum());
            FLT.Add(FLT.Sum());
            Deflector.Add(Deflector.Sum());
            DeflectorGauge.Add(DeflectorGauge.Sum());
            SprawdzianGeometrii.Add(SprawdzianGeometrii.Sum());
            Odkurzacz.Add(Odkurzacz.Sum());
            CL.Add(CL.Sum());

            _LineData.Add(DescriptionHR12CC[0], Cela_BasicInlet);
            _LineData.Add(DescriptionHR12CC[1], Cela_Midlamshell);
            _LineData.Add(DescriptionHR12CC[2], SizerInlet);
            _LineData.Add(DescriptionHR12CC[3], Cela_BasicInlet_Midlamshell);
            _LineData.Add(DescriptionHR12CC[4], Cela_BasicOutlet);
            _LineData.Add(DescriptionHR12CC[5], SizerOutlet);
            _LineData.Add(DescriptionHR12CC[6], Cela_BasicInletMidclamshell_BasicOutlet);
            _LineData.Add(DescriptionHR12CC[7], PLT);
            _LineData.Add(DescriptionHR12CC[8], Enkapsulacja);
            _LineData.Add(DescriptionHR12CC[9], Wkretak);
            _LineData.Add(DescriptionHR12CC[10], Homologacja);
            _LineData.Add(DescriptionHR12CC[11], Deflector);
            _LineData.Add(DescriptionHR12CC[12], DeflectorGauge);
            _LineData.Add(DescriptionHR12CC[13], SprawdzianGeometrii);
            _LineData.Add(DescriptionHR12CC[14], Odkurzacz);
            _LineData.Add(DescriptionHR12CC[15], CL);
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
            Cela_BasicInlet.Clear();
            Cela_BasicInletMidclamshell_BasicOutlet.Clear();
            Cela_BasicInlet_Midlamshell.Clear();
            Cela_BasicOutlet.Clear();
            Cela_Midlamshell.Clear();
            PLT.Clear();
            Enkapsulacja.Clear();
            Wkretak.Clear();
            Homologacja.Clear();
            FLT.Clear();
            Deflector.Clear();
            DeflectorGauge.Clear();
            SprawdzianGeometrii.Clear();
            Odkurzacz.Clear();
            CL.Clear();
        }
    }
}

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
            "Cela spawalnicza - Basic wlot (2LP2)",//0
            "Cela spawalnicza - Basic wlot (1GPF1 GPF)",//1
            "Cela spawalnicza - Midclamshell (2LP2)",//2
            "Cela spawalnicza - Midclamshell (1GPF1 GPF)",//3
            "Sizer wlot",//4
            "Cela spawalnicza - Basic wlot + midlamshell (2LP1 GPF)",//5
            "Cela spawalnicza - Basic wlot + midlamshell (3LP1 GPF)",//6
            "Cela spawalnicza - Basic wylot (2LP1 GPF)",//7
            "Cela spawalnicza - Basic wylot (3LP1 GPF)",//8
            "Sizer wylot",//9
            "Cela spawalnicza - Basic wlot - midclamshell + wylot (3LP2)",//10            
            "Cela spawalnicza - Basic wlot - midclamshell + wylot (4LP2)",//11
            "Preleak tester",//12
            "Enkapsulacja",//13
            "Wkrętak",//14
            "Homologacja",//15
            "Final leak tester",//16
            "Deflector",//17
            "Deflecotr gauge",//18
            "Sprawdzian geometrii",//19
            "Odkurzacz",//20
            "Kontrola Jakościowa",//21
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
        public List<int> Cela_BasicInlet_1 { get; set; }
        public List<int> Cela_Midlamshell_1 { get; set; }
        public List<int> Cela_BasicInlet_Midlamshell_1 { get; set; }
        public List<int> Cela_BasicOutlet_1 { get; set; }
        public List<int> Cela_BasicInletMidclamshell_BasicOutlet_1  { get; set; }
        public List<int> Cela_BasicInlet_2 { get; set; }
        public List<int> Cela_Midlamshell_2 { get; set; }
        public List<int> Cela_BasicInlet_Midlamshell_2 { get; set; }
        public List<int> Cela_BasicOutlet_2 { get; set; }
        public List<int> Cela_BasicInletMidclamshell_BasicOutlet_2 { get; set; }
        public List<int> PLT_L1 { get; set; }
        public List<int> PLT_L2 { get; set; }
        public List<int> PLT_L3 { get; set; }
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

        public void GetProductionCountPerHour(DateTime dateTime, string line, bool postProces = true)
        {
            _LineData = new Dictionary<string, List<int>>();

            if (line == LineDescription.LineWS3Hr12CC)
            {
                if (postProces)
                    GetProductionCountPerHourWS3B_postProces(dateTime);
                else
                    GetProductionCountPerHourWS3B_Welding(dateTime); 
            }
        }

        private void GetProductionCountPerHourWS3B_Welding(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTimeFrom.AddHours(1);

            SizerInlet = new List<int>();
            SizerOutlet = new List<int>();

            Cela_BasicInlet_1 = new List<int>();
            Cela_Midlamshell_1 = new List<int>();
            Cela_BasicInlet_Midlamshell_1 = new List<int>();
            Cela_BasicOutlet_1 = new List<int>();
            Cela_BasicInletMidclamshell_BasicOutlet_1 = new List<int>();

            Cela_BasicInlet_2 = new List<int>();
            Cela_Midlamshell_2 = new List<int>();
            Cela_BasicInlet_Midlamshell_2 = new List<int>();
            Cela_BasicOutlet_2 = new List<int>();
            Cela_BasicInletMidclamshell_BasicOutlet_2 = new List<int>();

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

                Cela_BasicInlet_1.Add(context.Hr12ccWeldingCellInletBasicClamshellOp3L7s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii.Contains("L1"))
                   .Count());

                Cela_BasicInlet_2.Add(context.Hr12ccWeldingCellInletBasicClamshellOp3L7s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii.Contains("L2"))
                   .Count());

                Cela_Midlamshell_1.Add(context.Hr12ccWeldingCellMidclamshellOp7L7s
                     .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii.Contains("L1"))
                     .Count());

                Cela_Midlamshell_2.Add(context.Hr12ccWeldingCellMidclamshellOp7L7s
                     .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii.Contains("L2"))
                     .Count());

                Cela_BasicInlet_Midlamshell_1.Add(context.Hr12ccWeldingCellIntletBasicMidclamshellOp8L7s
                    .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii.Contains("L1"))
                    .Count());

                Cela_BasicInlet_Midlamshell_2.Add(context.Hr12ccWeldingCellIntletBasicMidclamshellOp8L7s
                    .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii.Contains("L2"))
                    .Count());

                Cela_BasicOutlet_1.Add(context.Hr12ccWeldingCellOutletBasicClamshellOp6L7s
                  .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii.Contains("L1"))
                  .Count());

                Cela_BasicOutlet_2.Add(context.Hr12ccWeldingCellOutletBasicClamshellOp6L7s
                  .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii.Contains("L2"))
                  .Count());

                Cela_BasicInletMidclamshell_BasicOutlet_1.Add(context.Hr12ccWeldingCellInletOutletBasicMidclamshellL7s
                  .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii.Contains("L2C3"))
                  .Count());

                Cela_BasicInletMidclamshell_BasicOutlet_2.Add(context.Hr12ccWeldingCellInletOutletBasicMidclamshellL7s
                  .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii.Contains("L2C4"))
                  .Count());

              
                dateTimeFrom = dateTimeFrom.AddHours(1);
                dateTimeTo = dateTimeTo.AddHours(1);
            }

            Cela_BasicInlet_1.Add(Cela_BasicInlet_1.Sum());
            Cela_Midlamshell_1.Add(Cela_Midlamshell_1.Sum());
            SizerInlet.Add(SizerInlet.Sum());
            Cela_BasicInlet_Midlamshell_1.Add(Cela_BasicInlet_Midlamshell_1.Sum());
            Cela_BasicOutlet_1.Add(Cela_BasicOutlet_1.Sum());
            SizerOutlet.Add(SizerOutlet.Sum());
            Cela_BasicInletMidclamshell_BasicOutlet_1.Add(Cela_BasicInletMidclamshell_BasicOutlet_1.Sum());
            Cela_BasicInlet_2.Add(Cela_BasicInlet_2.Sum());
            Cela_Midlamshell_2.Add(Cela_Midlamshell_2.Sum());
            Cela_BasicInlet_Midlamshell_2.Add(Cela_BasicInlet_Midlamshell_2.Sum());
            Cela_BasicOutlet_2.Add(Cela_BasicOutlet_2.Sum());
            Cela_BasicInletMidclamshell_BasicOutlet_2.Add(Cela_BasicInletMidclamshell_BasicOutlet_2.Sum());

            _LineData.Add(DescriptionHR12CC[0], Cela_BasicInlet_1);
            _LineData.Add(DescriptionHR12CC[1], Cela_BasicInlet_2);
            _LineData.Add(DescriptionHR12CC[2], Cela_Midlamshell_1);
            _LineData.Add(DescriptionHR12CC[3], Cela_Midlamshell_2);
            _LineData.Add(DescriptionHR12CC[4], SizerInlet);
            _LineData.Add(DescriptionHR12CC[5], Cela_BasicInlet_Midlamshell_1);
            _LineData.Add(DescriptionHR12CC[6], Cela_BasicInlet_Midlamshell_2);
            _LineData.Add(DescriptionHR12CC[7], Cela_BasicOutlet_1);
            _LineData.Add(DescriptionHR12CC[8], Cela_BasicOutlet_2);
            _LineData.Add(DescriptionHR12CC[9], SizerOutlet);
            _LineData.Add(DescriptionHR12CC[10], Cela_BasicInletMidclamshell_BasicOutlet_1);
            _LineData.Add(DescriptionHR12CC[11], Cela_BasicInletMidclamshell_BasicOutlet_2);
        }

        private void GetProductionCountPerHourWS3B_postProces(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTimeFrom.AddHours(1);

            PLT_L1 = new List<int>();
            PLT_L2 = new List<int>();
            PLT_L3 = new List<int>();
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
              
                PLT_L1.Add(context.Hr12ccPreleakTesterL7s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikTestu == ResultOk && x.NrLinii == "L1")
                   .Count());

                PLT_L2.Add(context.Hr12ccPreleakTesterL7s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikTestu == ResultOk && x.NrLinii == "L2")
                   .Count());

                PLT_L3.Add(context.Hr12ccPreleakTesterL7s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikTestu == ResultOk && x.NrLinii == "L3")
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

            PLT_L1.Add(PLT_L1.Sum());
            PLT_L2.Add(PLT_L2.Sum());
            PLT_L3.Add(PLT_L3.Sum());
            Enkapsulacja.Add(Enkapsulacja.Sum());
            Wkretak.Add(Wkretak.Sum());
            Homologacja.Add(Homologacja.Sum());
            FLT.Add(FLT.Sum());
            Deflector.Add(Deflector.Sum());
            DeflectorGauge.Add(DeflectorGauge.Sum());
            SprawdzianGeometrii.Add(SprawdzianGeometrii.Sum());
            Odkurzacz.Add(Odkurzacz.Sum());
            CL.Add(CL.Sum());

            _LineData.Add($"{DescriptionHR12CC[12]}_L1", PLT_L1);
            _LineData.Add($"{DescriptionHR12CC[12]}_L2", PLT_L2);
            _LineData.Add($"{DescriptionHR12CC[12]}_L3", PLT_L3);
            _LineData.Add(DescriptionHR12CC[13], Enkapsulacja);
            _LineData.Add(DescriptionHR12CC[14], Wkretak);
            _LineData.Add(DescriptionHR12CC[15], Homologacja);
            _LineData.Add(DescriptionHR12CC[16], FLT);
            _LineData.Add(DescriptionHR12CC[17], Deflector);
            _LineData.Add(DescriptionHR12CC[18], DeflectorGauge);
            _LineData.Add(DescriptionHR12CC[19], SprawdzianGeometrii);
            _LineData.Add(DescriptionHR12CC[20], Odkurzacz);
            _LineData.Add(DescriptionHR12CC[21], CL);
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
            Cela_BasicInlet_1.Clear();
            Cela_BasicInletMidclamshell_BasicOutlet_1.Clear();
            Cela_BasicInlet_Midlamshell_1.Clear();
            Cela_BasicOutlet_1.Clear();
            Cela_Midlamshell_1.Clear();
            Cela_BasicInlet_2.Clear();
            Cela_BasicInletMidclamshell_BasicOutlet_2.Clear();
            Cela_BasicInlet_Midlamshell_2.Clear();
            Cela_BasicOutlet_2.Clear();
            Cela_Midlamshell_2.Clear();
            PLT_L1.Clear();
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

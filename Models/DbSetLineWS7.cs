using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.DataBase;


namespace WebMonitoring.Models
{
    public class DbSetLineWS7
    {
        private CnhDbContext context;

        private string ResultOk => "OK";
        private string Remove => "Remove";

        private string[] WS7 = new string[]
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
                    var result = Production.GetTarget(LineDescription.LineWS7);

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
                Production.SetTarget(LineDescription.LineWS7, target);
            }
        }

        public List<int> WS7_TT_PRELEAK_TESTER { get; set; }

        public List<int> WS7_TT_WELDING_CELL_2_OP290_STN1 { get; set; }

        public List<int> WS7_TT_WELDING_CELL_2_OP300_STN1 { get; set; }

        public List<int> WS7_TT_WELDING_CELL_2_OP310_STN2 { get; set; }

        public List<int> WS7_TT_WELDING_CELL_3_OP320_STN1 { get; set; }

        public List<int> WS7_TT_WELDING_CELL_3_OP325_STN1 { get; set; }

        public List<int> WS7_TT_WELDING_CELL_3_OP330_STN2 { get; set; }

        public List<int> WS7_TT_MANUAL_WELDING_OP360 { get; set; }

        public List<int> WS7_TT_FINAL_LEAK_TESTER { get; set; }

        public List<int> WS7_TT_MARKING_TESTER { get; set; }

        public List<int> WS7_TT_OP380 { get; set; }

        public List<int> WS7_TT_WELDING_CELL_3_OP390_STN2 { get; set; }

        public List<int> WS7_TT_FINAL_GAUGE { get; set; }

        public List<int> WS7_TT_PETLA_KONTROLNA_L4 { get; set; }



        public DbSetLineWS7(CnhDbContext ctx)
        {
            context = ctx;
        }

        public void GetProductionCountPerHour(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTimeFrom.AddHours(1);

            _LineData = new Dictionary<string, List<int>>();

            WS7_TT_PRELEAK_TESTER = new List<int>();
            WS7_TT_WELDING_CELL_2_OP290_STN1 = new List<int>();
            WS7_TT_WELDING_CELL_2_OP300_STN1 = new List<int>();
            WS7_TT_WELDING_CELL_2_OP310_STN2 = new List<int>();
            WS7_TT_WELDING_CELL_3_OP320_STN1 = new List<int>();
            WS7_TT_WELDING_CELL_3_OP325_STN1 = new List<int>();
            WS7_TT_WELDING_CELL_3_OP330_STN2 = new List<int>();
            WS7_TT_MANUAL_WELDING_OP360 = new List<int>();
            WS7_TT_FINAL_LEAK_TESTER = new List<int>();
            WS7_TT_MARKING_TESTER = new List<int>();
            WS7_TT_OP380 = new List<int>();
            WS7_TT_WELDING_CELL_3_OP390_STN2 = new List<int>();
            WS7_TT_FINAL_GAUGE = new List<int>();
            WS7_TT_PETLA_KONTROLNA_L4 = new List<int>();
           
            for (int i = 0; i < 8; i++)
            {
                var frameTimeUtcFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                var frameTimeUtcTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();

                WS7_TT_PRELEAK_TESTER.Add(context.Ws7TtPreleakTesters
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                WS7_TT_WELDING_CELL_2_OP290_STN1.Add(context.Ws7TtWeldingCell2Op290Stn1s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                WS7_TT_WELDING_CELL_2_OP300_STN1.Add(context.Ws7TtWeldingCell2Op300Stn1s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                WS7_TT_WELDING_CELL_2_OP310_STN2.Add(context.Ws7TtWeldingCell2Op310Stn2s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                WS7_TT_WELDING_CELL_3_OP320_STN1.Add(context.Ws7TtWeldingCell3Op320Stn1s
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                WS7_TT_WELDING_CELL_3_OP325_STN1.Add(context.Ws7TtWeldingCell3Op325Stn1s
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

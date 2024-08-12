﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.DataBase;

namespace WebMonitoring.Models
{
    public class DbSetPipeSDF
    {
        private PipeDbContext DbContext { get; set; }
        private string ResultOk => "OK";
        private string Remove => "Remove";

        private string[] Description = new string[]
        {
            "Tester szczelnośi",
            "Grawerka",
            "Składanie",
            "Kontrola Jakości"
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
                    var result = Production.GetTarget(LineDescription.LineSDF);

                    if (result?.Length > 0)
                        target = result[0].Target;
                    else
                        target = DbProduction.DefaultTarget[10];
                }
                //FileJson json = new FileJson();
                //target = json.DeserializeFromFile<int>(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Target", @"\LiniaWs2.json");
                return target;
            }
            set
            {
                target = value;
                Production.SetTarget(LineDescription.LineSDF, target);
            }
        }

        public List<int> LT { get; set; }

        public List<int> Marking { get; set; }

        public List<int> Assembling { get; set; }
        public List<int> CL { get; set; }

        public DbSetPipeSDF(PipeDbContext ctx)
        {
            DbContext = ctx;
        }

        public void GetProductionCountPerHour(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTimeFrom.AddHours(1);

            _LineData = new Dictionary<string, List<int>>();

            LT = new List<int>();
            Marking = new List<int>();
            Assembling = new List<int>();
            CL = new List<int>();

            for (int i = 0; i < 8; i++)
            {
                var frameTimeUtcFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                var frameTimeUtcTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();

                LT.Add(DbContext.Ws7SdfFinalLeakTesters
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                Marking.Add(DbContext.Ws7SdfMarkings
                  .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                  .Count());

                Assembling.Add(DbContext.Ws7SdfAssemblings
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk)
                   .Count());

                CL.Add(DbContext.Ws7SdfControlLoops
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.Result == true)
                   .Count());

                dateTimeFrom = dateTimeFrom.AddHours(1);
                dateTimeTo = dateTimeTo.AddHours(1);
            }

            LT.Add(LT.Sum());
            Marking.Add(Marking.Sum());
            Assembling.Add(Assembling.Sum());
            CL.Add(CL.Sum());

            _LineData.Add(Description[0], LT);
            _LineData.Add(Description[1], Marking);
            _LineData.Add(Description[2], Assembling);
            _LineData.Add(Description[3], CL);
        }

        public int GetCountFromDayPipeSdf(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddDays(1);

            var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc_AllDay();
            var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc_AllDay();

            return DbContext.Ws7SdfAssemblings
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

                partsShift[i] = DbContext.Ws7SdfAssemblings
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
                var result1 = DbContext.Ws7SdfAssemblings
               .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo) && x.WynikOperacji == ResultOk)
               .Count();

                if (result1 > 10)
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

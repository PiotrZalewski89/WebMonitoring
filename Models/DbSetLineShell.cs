using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.DataBase;

namespace WebMonitoring.Models
{
    public class DbSetLineShell
    {
        private ProductionDbContext context;
        private string ResultOk => "OK";
        private string Remove => "Remove";

        private string[] LineShell = new string[]
       {
            "Weil"
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
                    var result = Production.GetTarget(LineDescription.LineWeil);

                    if (result?.Length > 0)
                        target = result[0].Target;
                    else
                        target = DbProduction.DefaultTarget[8];
                }
                //FileJson json = new FileJson();
                //target = json.DeserializeFromFile<int>(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Target", @"\LiniaWs6.json");

                return target;
            }
            set
            {
                target = value;
                Production.SetTarget(LineDescription.LineWeil, target);
            }
        }

        public List<int> Weil { get; set; }


        public DbSetLineShell(ProductionDbContext ctx)
        {
            context = ctx;
        }

        public void GetProductionCountPerHourWeil(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTimeFrom.AddHours(1);

            _LineData = new Dictionary<string, List<int>>();

            Weil = new List<int>();

            for (int i = 0; i < 8; i++)
            {
                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();


                var dateTimeFromPrev = dateTimeFrom.AddHours(-1);
                var dateTimeToPrev = dateTimeTo.AddHours(-1);

                var frameTimeFromPrev = dateTimeFromPrev.ConvertDateTimeToFrameTime();
                var frameTimeToPrev = dateTimeToPrev.ConvertDateTimeToFrameTime();

                var resultWeil = context.Weils
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                   .ToArray();

                if (resultWeil?.Length > 0)
                {
                    var prevResultWeil = context.Weils
                               .Where(x => x.FrameTime >= frameTimeFromPrev && x.FrameTime < frameTimeToPrev)
                               .ToArray();

                    if (prevResultWeil?.Length > 0)
                    {
                        Weil.Add((int)(resultWeil[resultWeil.Length - 1].IloscSztuk - prevResultWeil[prevResultWeil.Length - 1].IloscSztuk));
                    }
                    else
                    {
                        Weil.Add((int)(resultWeil[resultWeil.Length - 1].IloscSztuk - resultWeil[0].IloscSztuk));
                    }
                }
                else
                {
                    Weil.Add(0);
                }
                

                dateTimeFrom = dateTimeFrom.AddHours(1);
                dateTimeTo = dateTimeTo.AddHours(1);
            }

            Weil.Add(Weil.Sum());

            LineData.Add(LineShell[0], Weil);
        }

        //public int GetCountFromDayWeil(DateTime dateTime)
        //{
        //    var dateTimeFrom = dateTime;
        //    var dateTimeTo = dateTime.AddDays(1);

        //    return context.Cnh529Checks
        //       .Where(x => x.DtOperacji >= dateTimeFrom && x.DtOperacji < dateTimeTo && x.WynikOperacji == ResultOk)
        //       .Count();
        //}

        public int[] GetDailyRaport(DateTime dateTime)
        {
            int[] partsShift = new int[3];

            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddHours(8);

            for (int i = 0; i < 3; i++)
            {

                var dateTimeFromPrev = dateTimeFrom.AddHours(-8);
                var dateTimeToPrev = dateTimeTo.AddHours(-8);

                var resultWeil = context.Weils
                   .Where(x => x.DtOperacji >= dateTimeFrom && x.DtOperacji < dateTimeTo)
                   .ToArray();



                if (resultWeil?.Length > 0)
                {
                    var prevResultWeil = context.Weils
                           .Where(x => x.DtOperacji >= dateTimeFromPrev && x.DtOperacji < dateTimeToPrev)
                           .ToArray();

                    if (prevResultWeil?.Length > 0)
                    {
                        partsShift[i] = (int)(resultWeil[resultWeil.Length - 1].IloscSztuk - prevResultWeil[prevResultWeil.Length - 1].IloscSztuk);
                    }
                    else
                    {
                        partsShift[i] = (int)(resultWeil[resultWeil.Length - 1].IloscSztuk - resultWeil[0].IloscSztuk);
                    }
                }

                dateTimeFrom = dateTimeFrom.AddHours(8);
                dateTimeTo = dateTimeTo.AddHours(8);
            }

            return partsShift;
        }

        public int GetCountFromDay(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddDays(1);


            var dateTimeFromPrev = dateTimeFrom.AddDays(-1);
            var dateTimeToPrev = dateTimeTo.AddDays(-1);

            int result = 0;

            var resultWeil = context.Weils
                   .Where(x => x.DtOperacji >= dateTimeFrom && x.DtOperacji < dateTimeTo)
                   .ToArray();

            if (resultWeil?.Length > 0)
            {
                var prevResultWeil = context.Weils
                         .Where(x => x.DtOperacji >= dateTimeFromPrev && x.DtOperacji < dateTimeToPrev)
                         .ToArray();

                if (prevResultWeil?.Length > 0)
                {
                    result = (int)(resultWeil[resultWeil.Length - 1].IloscSztuk - prevResultWeil[prevResultWeil.Length - 1].IloscSztuk);
                }
                else
                {
                    result = (int)(resultWeil[resultWeil.Length - 1].IloscSztuk - resultWeil[0].IloscSztuk);
                }
            }

            return result;
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
                var result = context.Weils
               .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
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

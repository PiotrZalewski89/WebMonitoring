using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebMonitoring.DataBase;

namespace WebMonitoring.Models
{
    public class DbSetLineWS3
    {
        private StorageStationDbContext context;
        private ProductionDbContext dpContext;

        private string ResultOk => "OK";
        private string Remove => "Remove";
        private string L1 => "L1";
        private string L2 => "L2";
        private string L3 => "L3";

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
            "Cela 3 LP1",
            "Preleak tester LP1",
            "Enkapsulacja LP1",
            "Wkrętak LP1",
            "Homologacja LP1",
            "Final leak tester LP1",
            "Sprawdzian geometrii LP1",
            "Odkurzacz LP1",
            "Pętla KJ LP1"
        };

        private string[] DescriptionWS3BLP2 = new string[]
        {
            "Cela 3 LP2",
            "Preleak tester LP2",
            "Enkapsulacja LP2",
            "Wkrętak LP2",
            "Homologacja LP2",
            "Final leak tester LP2",
            "Sprawdzian geometrii LP2",
            "Odkurzacz LP2",
            "Pętla KJ LP2"
        };

        private string[] DescriptionWS3BLP3 = new string[]
        {   
            "Cela 3 LP3",
            "Preleak tester LP3",
            "Enkapsulacja LP3",
            "Wkrętak LP3"
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
                    var result = Production.GetTarget(LineDescription.LineWS3);

                    if (result?.Length > 0)
                        target = result[0].Target;
                    else
                        target = DbProduction.DefaultTarget[3];
                }

                //FileJson json = new FileJson();
                //target = json.DeserializeFromFile<int>(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Target", @"\LiniaWs3.json");

                return target;
            }
            set
            {
                target = value;
                Production.SetTarget(LineDescription.LineWS3, target);
            }
        }      

        //WS3A
        public List<int> Cela0LP1 { get; set; }

        public List<int> Cela1LP1 { get; set; }

        public List<int> Cela1LP2 { get; set; }

        public List<int> Cela2LP1 { get; set; }

        public List<int> Cela2LP2 { get; set; }

        public List<int> Cela1LP1_GPF { get; set; }

        public List<int> Cela2LP1_GPF { get; set; }

        //WS3B LP1
        public List<int> Cela1LP2_RURKI { get; set; }

        public List<int> Cela3LP1 { get; set; }

        public List<int> PLTLP1 { get; set; }

        public List<int> EnkapsulacjaLP1 { get; set; }

        public List<int> WkretakLP1 { get; set; }

        public List<int> HomologacjaLP1 { get; set; }

        public List<int> FLTLP1 { get; set; }

        public List<int> SprawdzianGeometriiLP1 { get; set; }

        public List<int> OdkurzaczLP1 { get; set; }

        public List<int> PetlaKJLP1 { get; set; }

        //WS3B  LP2
        public List<int> Cela3LP2 { get; set; }

        public List<int> PLTLP2 { get; set; }

        public List<int> EnkapsulacjaLP2 { get; set; }

        public List<int> WkretakLP2 { get; set; }

        public List<int> HomologacjaLP2 { get; set; }

        public List<int> FLTLP2 { get; set; }

        public List<int> SprawdzianGeometriiLP2 { get; set; }

        public List<int> OdkurzaczLP2 { get; set; }

        public List<int> PetlaKJLP2 { get; set; }

        //WS3B LP3
        public List<int> Cela3LP3 { get; set; }

        public List<int> PLTLP3 { get; set; }

        public List<int> EnkapsulacjaLP3 { get; set; }

        public List<int> WkretakLP3 { get; set; }

        public DbSetLineWS3(StorageStationDbContext ctx, ProductionDbContext dpCtx)
        {
            context = ctx;
            dpContext = dpCtx;
        }
        public DbSetLineWS3(StorageStationDbContext ctx)
        {
            context = ctx;
        }

        public DbSetLineWS3(ProductionDbContext dpCtx)
        {
            dpContext = dpCtx;
        }

        public void GetProductionCountPerHour(DateTime dateTime, string line)
        {
            _LineData = new Dictionary<string, List<int>>();

            if (line == LineDescription.LineWS3A)
            {
                GetProductionCountPerHourWS3ALP1(dateTime);
            }
            else if (line == LineDescription.LineWS3BLP1)
            {
                GetProductionCountPerHourWS3BLP1(dateTime);
            }
            else if (line == LineDescription.LineWS3BLP2)
            {
                GetProductionCountPerHourWS3BLP2(dateTime);
            }
            else if (line == LineDescription.LineWS3BLP3)
            {
                GetProductionCountPerHourWS3BLP3(dateTime);
            }
        }

        private void GetProductionCountPerHourWS3ALP1(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTimeFrom.AddHours(1);

            Cela0LP1 = new List<int>();
            Cela1LP1 = new List<int>();
            Cela1LP2 = new List<int>();
            Cela2LP1 = new List<int>();
            Cela2LP2 = new List<int>();
            Cela1LP1_GPF = new List<int>();
            Cela2LP1_GPF = new List<int>();
            Cela1LP2_RURKI = new List<int>();

            for (int i = 0; i < 8; i++)
            {
                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();

                var parts = dpContext.Ws3Cela0lp1s
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                   .Select(x => x.IloscSztuk);

                Cela0LP1.Add((int)parts.Sum());                

                parts = (dpContext.Ws3Cela1lp1s
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                   .Select(x => x.IloscSztuk));

                Cela1LP1.Add((int)parts.Sum());

                parts = (dpContext.Ws3Cela1lp2s
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                   .Select(x => x.IloscSztuk));

                Cela1LP2.Add((int)parts.Sum());

                parts = (dpContext.Ws3Cela2lp1s
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                   .Select(x => x.IloscSztuk));

                Cela2LP1.Add((int)parts.Sum());

                parts = (dpContext.Ws3Cela2lp2s
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                   .Select(x => x.IloscSztuk));

                Cela2LP2.Add((int)parts.Sum());

                parts = (dpContext.Ws3Cela1lp1Gpfs
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                   .Select(x => x.IloscSztuk));

                Cela1LP1_GPF.Add((int)parts.Sum());

                parts = (dpContext.Ws3Cela2lp1Gpfs
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                   .Select(x => x.IloscSztuk));

                Cela2LP1_GPF.Add((int)parts.Sum());

                parts = (dpContext.Ws3Cela1lp2Rurkis
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                   .Select(x => x.IloscSztuk));

                Cela1LP2_RURKI.Add((int)parts.Sum());

                dateTimeFrom = dateTimeFrom.AddHours(1);
                dateTimeTo = dateTimeTo.AddHours(1);
            }

            Cela0LP1.Add(Cela0LP1.Sum());
            Cela1LP1.Add(Cela1LP1.Sum());
            Cela1LP2.Add(Cela1LP2.Sum());
            Cela2LP1.Add(Cela2LP1.Sum());
            Cela2LP2.Add(Cela2LP2.Sum());
            Cela1LP1_GPF.Add(Cela1LP1_GPF.Sum());
            Cela2LP1_GPF.Add(Cela2LP1_GPF.Sum());
            Cela1LP2_RURKI.Add(Cela1LP2_RURKI.Sum());

            _LineData.Add(DescriptionWS3A[0], Cela0LP1);
            _LineData.Add(DescriptionWS3A[1], Cela1LP1);
            _LineData.Add(DescriptionWS3A[2], Cela1LP2);
            _LineData.Add(DescriptionWS3A[7], Cela1LP2_RURKI);
            _LineData.Add(DescriptionWS3A[3], Cela2LP1);
            _LineData.Add(DescriptionWS3A[4], Cela2LP2);
            _LineData.Add(DescriptionWS3A[5], Cela1LP1_GPF);
            _LineData.Add(DescriptionWS3A[6], Cela2LP1_GPF);
        }

        private void GetProductionCountPerHourWS3BLP1(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTimeFrom.AddHours(1);

            Cela3LP1 = new List<int>();
            PLTLP1 = new List<int>();
            EnkapsulacjaLP1 = new List<int>();
            WkretakLP1 = new List<int>();
            HomologacjaLP1 = new List<int>();
            FLTLP1 = new List<int>();
            SprawdzianGeometriiLP1 = new List<int>();
            OdkurzaczLP1 = new List<int>();
            PetlaKJLP1 = new List<int>();

            for (int i = 0; i < 8; i++)
            {
                var frameTimeUtcFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                var frameTimeUtcTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();

                //var parts = dpContext.Ws3Cela5lp1s
                // .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                // .Select(x => x.IloscSztuk);

                //Cela3LP1.Add((int)parts.Sum());

                Cela3LP1.Add(context.VCela8AbbL1Monitorings
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii.Contains(L1))
                   .Count());

                PLTLP1.Add(context.VPreleakTesterMonitorings
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikTestu == ResultOk && x.NrLinii == L1)
                   .Count());

                EnkapsulacjaLP1.Add(context.VInletPressL1Monitorings
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii == L1)
                   .Count());

                WkretakLP1.Add(context.VTorqueScrewdriverL1Monitorings
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii == L1)
                   .Count());

                HomologacjaLP1.Add(context.VHomologationL1Monitorings//hom
                    .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii == L1)
                    .Count());

                FLTLP1.Add(context.VFinalleakTesterMonitorings
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikTestu == ResultOk && x.NrLinii == L1)
                   .Count());

                SprawdzianGeometriiLP1.Add(context.VCheckFixtureL1Monitorings//fg
                   .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii == L1)
                   .Count());

                OdkurzaczLP1.Add(context.VOdkurzaczHr10L1Monitorings
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk && x.NrLinii == L1)
                   .Count());

                PetlaKJLP1.Add(context.VPetlaKontrolnaHr10L1Monitorings
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk && x.NrPaleta != Remove && x.NrLinii == L1)
                   .Count());

                dateTimeFrom = dateTimeFrom.AddHours(1);
                dateTimeTo = dateTimeTo.AddHours(1);
            }

            Cela3LP1.Add(Cela3LP1.Sum());
            PLTLP1.Add(PLTLP1.Sum());
            EnkapsulacjaLP1.Add(EnkapsulacjaLP1.Sum());
            WkretakLP1.Add(WkretakLP1.Sum());
            HomologacjaLP1.Add(HomologacjaLP1.Sum());
            FLTLP1.Add(FLTLP1.Sum());
            SprawdzianGeometriiLP1.Add(SprawdzianGeometriiLP1.Sum());
            OdkurzaczLP1.Add(OdkurzaczLP1.Sum());
            PetlaKJLP1.Add(PetlaKJLP1.Sum());

            _LineData.Add(DescriptionWS3BLP1[0], Cela3LP1);
            _LineData.Add(DescriptionWS3BLP1[1], PLTLP1);
            _LineData.Add(DescriptionWS3BLP1[2], EnkapsulacjaLP1);
            _LineData.Add(DescriptionWS3BLP1[3], WkretakLP1);
            _LineData.Add(DescriptionWS3BLP1[4], HomologacjaLP1);
            _LineData.Add(DescriptionWS3BLP1[5], FLTLP1);
            _LineData.Add(DescriptionWS3BLP1[6], SprawdzianGeometriiLP1);
            _LineData.Add(DescriptionWS3BLP1[7], OdkurzaczLP1);
            _LineData.Add(DescriptionWS3BLP1[8], PetlaKJLP1);
        }

        private void GetProductionCountPerHourWS3BLP2(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTimeFrom.AddHours(1);

            Cela3LP2 = new List<int>();
            PLTLP2 = new List<int>();
            EnkapsulacjaLP2 = new List<int>();
            WkretakLP2 = new List<int>();
            HomologacjaLP2 = new List<int>();
            FLTLP2 = new List<int>();
            SprawdzianGeometriiLP2 = new List<int>();
            OdkurzaczLP2 = new List<int>();
            PetlaKJLP2 = new List<int>();

            for (int i = 0; i < 8; i++)
            {
                var frameTimeUtcFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                var frameTimeUtcTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();

                //var parts = dpContext.Ws3Cela5lp2s
                // .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                // .Select(x => x.IloscSztuk);

                //Cela3LP2.Add((int)parts.Sum());

                Cela3LP2.Add(context.VCela8AbbL1Monitorings
                  .Where(x => x.FrameTime2 >= frameTimeUtcFrom && x.FrameTime2 < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii.Contains(L2))
                  .Count());

                PLTLP2.Add(context.VPreleakTesterMonitorings
                   .Where(x => x.FrameTime2 >= frameTimeUtcFrom && x.FrameTime2 < frameTimeUtcTo && x.WynikTestu == ResultOk && x.NrLinii == L2)
                   .Count());

                EnkapsulacjaLP2.Add(context.VInletPressL1Monitorings
                   .Where(x => x.FrameTime2 >= frameTimeUtcFrom && x.FrameTime2 < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii == L2)
                   .Count());

                WkretakLP2.Add(context.VTorqueScrewdriverL1Monitorings
                   .Where(x => x.FrameTime2 >= frameTimeUtcFrom && x.FrameTime2 < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii == L2)
                   .Count());

                HomologacjaLP2.Add(context.VHomologationL1Monitorings//hom
                    .Where(x => x.FrameTime2 >= frameTimeUtcFrom && x.FrameTime2 < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii == L2)
                    .Count());

                FLTLP2.Add(context.VFinalleakTesterMonitorings
                   .Where(x => x.FrameTime2 >= frameTimeUtcFrom && x.FrameTime2 < frameTimeUtcTo && x.WynikTestu == ResultOk && x.NrLinii == L2)
                   .Count());

                SprawdzianGeometriiLP2.Add(context.VCheckFixtureL1Monitorings//fg
                   .Where(x => x.FrameTime2 >= frameTimeUtcFrom && x.FrameTime2 < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii == L2)
                   .Count());

                OdkurzaczLP2.Add(context.VOdkurzaczHr10L1Monitorings
                   .Where(x => x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo && x.WynikOperacji == ResultOk && x.NrLinii == L2)
                   .Count());

                PetlaKJLP2.Add(context.VPetlaKontrolnaHr10L1Monitorings
                   .Where(x => x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo && x.WynikOperacji == ResultOk && x.NrPaleta != Remove && x.NrLinii == L2)
                   .Count());

                dateTimeFrom = dateTimeFrom.AddHours(1);
                dateTimeTo = dateTimeTo.AddHours(1);
            }

            Cela3LP2.Add(Cela3LP2.Sum());
            PLTLP2.Add(PLTLP2.Sum());
            EnkapsulacjaLP2.Add(EnkapsulacjaLP2.Sum());
            WkretakLP2.Add(WkretakLP2.Sum());
            HomologacjaLP2.Add(HomologacjaLP2.Sum());
            FLTLP2.Add(FLTLP2.Sum());
            SprawdzianGeometriiLP2.Add(SprawdzianGeometriiLP2.Sum());
            OdkurzaczLP2.Add(OdkurzaczLP2.Sum());
            PetlaKJLP2.Add(PetlaKJLP2.Sum());

            _LineData.Add(DescriptionWS3BLP2[0], Cela3LP2);
            _LineData.Add(DescriptionWS3BLP2[1], PLTLP2);
            _LineData.Add(DescriptionWS3BLP2[2], EnkapsulacjaLP2);
            _LineData.Add(DescriptionWS3BLP2[3], WkretakLP2);
            _LineData.Add(DescriptionWS3BLP2[4], HomologacjaLP2);
            _LineData.Add(DescriptionWS3BLP2[5], FLTLP2);
            _LineData.Add(DescriptionWS3BLP2[6], SprawdzianGeometriiLP2);
            _LineData.Add(DescriptionWS3BLP2[7], OdkurzaczLP2);
            _LineData.Add(DescriptionWS3BLP2[8], PetlaKJLP2);
        }

        public void GetProductionCountPerHourWS3BLP3(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTimeFrom.AddHours(1);

            Cela3LP3 = new List<int>();
            PLTLP3 = new List<int>();
            EnkapsulacjaLP3 = new List<int>();
            WkretakLP3 = new List<int>();

            for (int i = 0; i < 8; i++)
            {
                var frameTimeUtcFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                var frameTimeUtcTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();

                // var parts = dpContext.Ws3Cela5lp3s
                //.Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                //.Select(x => x.IloscSztuk);

                // Cela3LP3.Add((int)parts.Sum());

                Cela3LP3.Add(context.VCela8AbbL1Monitorings
                   .Where(x => x.FrameTime3 >= frameTimeUtcFrom && x.FrameTime3 < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii.Contains(L3))
                   .Count());

                PLTLP3.Add(context.VPreleakTesterMonitorings
                   .Where(x => x.FrameTime3 >= frameTimeUtcFrom && x.FrameTime3 < frameTimeUtcTo && x.WynikTestu == ResultOk && x.NrLinii == L3)
                   .Count());

                EnkapsulacjaLP3.Add(context.VInletPressL1Monitorings
                   .Where(x => x.FrameTime3 >= frameTimeUtcFrom && x.FrameTime3 < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii == L3)
                   .Count());

                WkretakLP3.Add(context.VTorqueScrewdriverL1Monitorings
                   .Where(x => x.FrameTime3 >= frameTimeUtcFrom && x.FrameTime3 < frameTimeUtcTo && x.WynikOperacji == ResultOk && x.NrLinii == L3)
                   .Count());             

                dateTimeFrom = dateTimeFrom.AddHours(1);
                dateTimeTo = dateTimeTo.AddHours(1);
            }

            Cela3LP3.Add(Cela3LP3.Sum());
            PLTLP3.Add(PLTLP3.Sum());
            EnkapsulacjaLP3.Add(EnkapsulacjaLP3.Sum());
            WkretakLP3.Add(WkretakLP3.Sum());

            _LineData.Add(DescriptionWS3BLP3[0], Cela3LP3);
            _LineData.Add(DescriptionWS3BLP3[1], PLTLP3);
            _LineData.Add(DescriptionWS3BLP3[2], EnkapsulacjaLP3);
            _LineData.Add(DescriptionWS3BLP3[3], WkretakLP3);
        }

        public int GetCountFromDayWS3BLP1(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddDays(1);

            var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime_AllDay();
            var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime_AllDay();

            return context.VCheckFixtureL1Monitorings
               .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.WynikOperacji == ResultOk && x.NrLinii == L1)
               .Count();
        }

        public int GetCountFromDayWS3BLP2(DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddDays(1);

            var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc_AllDay();
            var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc_AllDay();

            return context.VCheckFixtureL1Monitorings
               .Where(x => x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo && x.WynikOperacji == ResultOk && x.NrLinii == L2)
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

                partsShift[i] = context.VCheckFixtureL1Monitorings
                   .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo) && x.WynikOperacji == ResultOk && x.NrLinii == L1)
                   .Count();

                partsShift[i] += context.VCheckFixtureL1Monitorings
                    .Where(x => (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo) && x.WynikOperacji == ResultOk && x.NrLinii == L2)
                    .Count();

                dateTimeFrom = dateTimeFrom.AddHours(8);
                dateTimeTo = dateTimeTo.AddHours(8);
            }

            return partsShift;
        }

        public int[] GetDailyRaportDaneProdukcyjne(DateTime dateTime, string station)
        {
            int[] partsShift = new int[3];

            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddHours(8);

            IQueryable<int?> parts;

            for (int i = 0; i < 3; i++)
            {
                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

                if (station == "CelaGpf1Lp1")
                {
                    parts = dpContext.Ws3Cela1lp1Gpfs
                          .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                          .Select(x => x.IloscSztuk);

                    partsShift[i] = (int)parts.Sum();
                }

                else if (station == "CelaGpf2Lp1")
                {
                    parts = dpContext.Ws3Cela2lp1Gpfs
                          .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                          .Select(x => x.IloscSztuk);

                    partsShift[i] = (int)parts.Sum();
                }
                else if (station == "CelaGpf3BasicBushingLp1")
                {
                    parts = dpContext.Ws3Cela3lp1Gpfs
                          .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                          .Select(x => x.IloscSztuk);

                    partsShift[i] = (int)parts.Sum();
                }
                else if (station == "CelaGpf3OutletBushingLp1")
                {
                    parts = dpContext.Ws3Cela3lp1Gpfs
                          .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                          .Select(x => x.IloscSztuk);

                    partsShift[i] = (int)parts.Sum();
                }
                else if (station == "Cela1Lp2Rurki")
                {
                    parts = dpContext.Ws3Cela1lp2Rurkis
                          .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                          .Select(x => x.IloscSztuk);

                    partsShift[i] = (int)parts.Sum();
                }
                else if (station == "Cela0Lp1")
                {
                    parts = dpContext.Ws3Cela0lp1s
                          .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                          .Select(x => x.IloscSztuk);

                    partsShift[i] = (int)parts.Sum();
                }
                else if (station == "Cela2Lp1")
                {
                    parts = dpContext.Ws3Cela2lp1s
                          .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                          .Select(x => x.IloscSztuk);

                    partsShift[i] = (int)parts.Sum();
                }
                else if (station == "Cela2Lp2")
                {
                    parts = dpContext.Ws3Cela2lp2s
                          .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                          .Select(x => x.IloscSztuk);

                    partsShift[i] = (int)parts.Sum();
                }

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
                var result = context.VCheckFixtureL1Monitorings
                   .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo) && x.WynikOperacji == ResultOk)
                   .Count();

                result += context.VCheckFixtureL1Monitorings
                   .Where(x => (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo) && x.WynikOperacji == ResultOk)
                   .Count();

                //DateTime dt1;
                //_ = DateTime.TryParse("06.03.2023 00:00:00", out dt1);
                //DateTime dt2;
                //_ = DateTime.TryParse("11.03.2023 00:00:00", out dt2);

                //if (DateTime.Compare(dt1, dateTimeFrom.Date) <= 0 && DateTime.Compare(dt2, dateTimeFrom.Date) >= 0)
                //{
                //    result = result > 1066 ? 1066 : result;
                //}

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

            Cela0LP1.Clear();
            Cela1LP1.Clear();
            Cela1LP2.Clear();
            Cela2LP1.Clear();
            Cela2LP2.Clear();
            Cela1LP1_GPF.Clear();
            Cela2LP1_GPF.Clear();
            Cela1LP2_RURKI.Clear();

            Cela3LP1.Clear();
            PLTLP1.Clear();
            EnkapsulacjaLP1.Clear();
            WkretakLP1.Clear();
            HomologacjaLP1.Clear();
            FLTLP1.Clear();
            SprawdzianGeometriiLP1.Clear();
            OdkurzaczLP1.Clear();
            PetlaKJLP1.Clear();

            Cela3LP2.Clear();
            PLTLP2.Clear();
            EnkapsulacjaLP2.Clear();
            WkretakLP2.Clear();
            HomologacjaLP2.Clear();
            FLTLP2.Clear();
            SprawdzianGeometriiLP2.Clear();
            OdkurzaczLP2.Clear();
            PetlaKJLP2.Clear();

            Cela3LP3.Clear();
            PLTLP3.Clear();
            EnkapsulacjaLP3.Clear();
            WkretakLP3.Clear();
        }
    }
}

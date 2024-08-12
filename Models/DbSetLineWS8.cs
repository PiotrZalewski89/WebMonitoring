using System;
using System.Collections.Generic;
using System.Linq;
using WebMonitoring.DataBase;

namespace WebMonitoring.Models
{
    public class DbSetLineWS8
    {
        private StorageStationDbContext context;
        private ProductionDbContext dpContext;

        private string[] WS8_BJA = new string[]
        {
            "Cela 1",
            "Cela 2",
            "Cela 3",
            "Cela 4",
            "Cela 5",
            "Leak tester",
            "Enkapsulacja",
            "Sprawdzian geometrii",
            "Odkurzacz",
            "Pętla KJ"
        };

        private string[] WS8_GPF = new string[]
        {
            "Cela 1",
            "Cela 2",
            "Cela 3",
            "Cela 4",
            "Cela 5",
            "Leak tester",
            "Wkrętak",
            "Enkapsulacja",
            "Sprawdzian geometrii",
            "Odkurzacz",
            "Pętla KJ"
        };

        private string ResultOk => "OK";
        private string Remove => "Remove";

        private Dictionary<string, List<int>> _LineData { get; set; }

        public Dictionary<string, List<int>> LineData { get => _LineData; }

        private DbProduction Production { get; set; } = new DbProduction(new ProductionDbContext());

        public static string Line { get; set; }

        private int target = 0;
        public int Target
        {
            get
            {
                if (target == 0)
                {
                    var result = Production.GetTarget(Line, TrybPracy12h);

                    if (result?.Length > 0)
                        target = result[0].Target;
                    else
                        target = DbProduction.DefaultTarget[4];
                }

                //FileJson json = new FileJson();
                //if (TrybPracy12h)
                //{
                //    if (Line == LineDescription.LineWS4BJA)
                //        target = json.DeserializeFromFile<int>(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Target", @"\LiniaWs4Bja12h.json");
                //    else if (Line == LineDescription.LineWS4GPF)
                //        target = json.DeserializeFromFile<int>(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Target", @"\LiniaWs4Gpf12h.json");
                //}
                //else
                //{
                //    if (Line == LineDescription.LineWS4BJA)
                //        target = json.DeserializeFromFile<int>(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Target", @"\LiniaWs4Bja.json");
                //    else if (Line == LineDescription.LineWS4GPF)
                //        target = json.DeserializeFromFile<int>(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Target", @"\LiniaWs4Gpf.json");
                //}
                return target;
            }
            set
            {
                target = value;
                Production.SetTarget(Line, target, TrybPracy12h);
            }
        }

        public bool TrybPracy12h { get; set; }

        public List<int> Cela1 { get; set; }

        public List<int> Cela2 { get; set; }

        public List<int> Cela3 { get; set; }

        public List<int> LT { get; set; }

        public List<int> Wkretak { get; set; }

        public List<int> Enkapsulacja { get; set; }

        public List<int> SprawdzianGeometrii { get; set; }

        public List<int> Odkurzacz { get; set; }

        public List<int> PetlaKJ { get; set; }

        public DbSetLineWS8(StorageStationDbContext ctx, ProductionDbContext dpCtx)
        {
            context = ctx;
            dpContext = dpCtx;
        }
        public DbSetLineWS8(StorageStationDbContext ctx)
        {
            context = ctx;
        }

        public void GetProductionCountPerHour(DateTime dateTime, string line, bool tryb12h)
        {
            _LineData = new Dictionary<string, List<int>>();
                     

            if (line == LineDescription.LineWS8_BJA)
            {
                GetProductionCountPerHourWS8_BR10_BJA(dateTime, tryb12h);
            }
            else if (line == LineDescription.LineWS8_GPF)
            {
                 GetProductionCountPerHourWS8_BR10_ED_GPF(dateTime, tryb12h);              
            }
        }

        public void GetProductionCountPerHourWS8_BR10_ED_GPF(DateTime dateTime, bool tryb12h)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTimeFrom.AddHours(1);

            int hour = tryb12h ? 12 : 8;

            //Cela1 = new List<int>();
            //Cela2 = new List<int>();
            //Cela3 = new List<int>();
            LT = new List<int>();
            Wkretak = new List<int>();
            Enkapsulacja = new List<int>();
            SprawdzianGeometrii = new List<int>();
            Odkurzacz = new List<int>();
            PetlaKJ = new List<int>();

            const string br10gpf = "BR10 GPF";

            var partNumber = Production.GetPartNumber(br10gpf);
            //var partNumberKatcon = Production.GetPartNumberKatcon("BR10 GPF");

            IQueryable<int?> parts;

            for (int i = 0; i < hour; i++)
            {
                var frameTimeUtcFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                var frameTimeUtcTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();

                //parts = dpContext.Ws4Cela1s
                //        .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.Model == br10gpf)
                //        .Select(x => x.IloscSztuk);

                //Cela1.Add((int)parts.Sum());

                //parts = dpContext.Ws2bCela2lp1s
                //       .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.Model == br10gpf)
                //       .Select(x => x.IloscSztuk);

                //Cela2.Add((int)parts.Sum());

                //parts = dpContext.Ws4Cela3s
                //     .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.Model == br10gpf)
                //     .Select(x => x.IloscSztuk);

                //Cela3.Add((int)parts.Sum());

                //parts = dpContext.Ws4Cela4s
                //     .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.Model == br10gpf)
                //     .Select(x => x.IloscSztuk);

                //Cela4.Add((int)parts.Sum());

                //foreach (var pn in partNumberKatcon)
                //{
                //    if (Cela1.Count - 1 != i)
                //        Cela1.Add(dpContext.Br10Cela2Danes
                //                 .Where(x => x.DataCzas >= dateTimeFrom && x.DataCzas < dateTimeTo && x.Referencja.Contains(pn))
                //                 .Count());
                //    else
                //        Cela1[i] += dpContext.Br10Cela1Danes
                //                   .Where(x => x.DataCzas >= dateTimeFrom && x.DataCzas < dateTimeTo && x.Referencja.Contains(pn))
                //                   .Count();

                //    if (Cela2.Count - 1 != i)
                //        Cela2.Add(dpContext.Br10Cela2Danes
                //           .Where(x => x.DataCzas >= dateTimeFrom && x.DataCzas < dateTimeTo && x.Referencja.Contains(pn))
                //           .Count());
                //    else
                //        Cela2[i] += dpContext.Br10Cela2Danes
                //                   .Where(x => x.DataCzas >= dateTimeFrom && x.DataCzas < dateTimeTo && x.Referencja.Contains(pn))
                //                   .Count();

                //    if (Cela3.Count - 1 != i)
                //        Cela3.Add(dpContext.Br10Cela3Danes
                //           .Where(x => x.DataCzas >= dateTimeFrom && x.DataCzas < dateTimeTo && x.Referencja.Contains(pn))
                //           .Count());
                //    else
                //        Cela3[i] += dpContext.Br10Cela3Danes
                //                   .Where(x => x.DataCzas >= dateTimeFrom && x.DataCzas < dateTimeTo && x.Referencja.Contains(pn))
                //                   .Count();

                //    if (Cela4.Count - 1 != i)
                //        Cela4.Add(dpContext.Br10Cela4Danes
                //           .Where(x => x.DataCzas >= dateTimeFrom && x.DataCzas < dateTimeTo && x.Referencja.Contains(pn))
                //           .Count());
                //    else
                //        Cela4[i] += dpContext.Br10Cela4Danes
                //                   .Where(x => x.DataCzas >= dateTimeFrom && x.DataCzas < dateTimeTo && x.Referencja.Contains(pn))
                //                   .Count();
                //}

                foreach (var pn in partNumber)
                {           
                    //if (Cela5.Count - 1 != i)
                    //    Cela5.Add(context.VCela5AbbBr10L2Monitorings
                    //       .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.NrShella.Contains(pn) && x.WynikOperacji == ResultOk)
                    //       .Count());
                    //else
                    //    Cela5[i] += context.VCela5AbbBr10L2Monitorings
                    //               .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.NrShella.Contains(pn) && x.WynikOperacji == ResultOk)
                    //               .Count();

                    if (LT.Count - 1 != i)
                        LT.Add(context.VLeakTesterBr10L2Monitorings
                           .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.NrGrawerka.Contains(pn) && x.WynikTestu == ResultOk)
                           .Count());
                    else
                        LT[i] += context.VLeakTesterBr10L2Monitorings
                       .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.NrGrawerka.Contains(pn) && x.WynikTestu == ResultOk)
                       .Count();

                    if (Wkretak.Count - 1 != i)
                        Wkretak.Add(context.VWkretakL2Monitorings
                          .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.NrGrawerka.Contains(pn) && x.WynikOperacji == ResultOk)
                          .Count());
                    else
                        Wkretak[i] += context.VWkretakL2Monitorings
                          .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.NrGrawerka.Contains(pn) && x.WynikOperacji == ResultOk)
                          .Count();

                    if (Enkapsulacja.Count - 1 != i)
                        Enkapsulacja.Add(context.VEnkapsulacjaBr10L2Monitorings
                           .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.NrGrawerka.Contains(pn) && x.WynikOperacji == ResultOk)
                           .Count());
                    else
                        Enkapsulacja[i] += context.VEnkapsulacjaBr10L2Monitorings
                       .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.NrGrawerka.Contains(pn) && x.WynikOperacji == ResultOk)
                       .Count();

                    if (SprawdzianGeometrii.Count - 1 != i)
                        SprawdzianGeometrii.Add(context.VFinalGaugeBr10L2Monitorings
                           .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.NrGrawerka.Contains(pn) && x.WynikOperacji == ResultOk)
                           .Count());
                    else
                        SprawdzianGeometrii[i] += context.VFinalGaugeBr10L2Monitorings
                       .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.NrGrawerka.Contains(pn) && x.WynikOperacji == ResultOk)
                       .Count();

                    if (Odkurzacz.Count - 1 != i)
                        Odkurzacz.Add(context.VOdkurzaczBr10L2Monitorings
                           .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.NrGrawerka.Contains(pn) && x.WynikOperacji == ResultOk)
                           .Count());
                    else
                        Odkurzacz[i] += context.VOdkurzaczBr10L2Monitorings
                       .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.NrGrawerka.Contains(pn) && x.WynikOperacji == ResultOk)
                       .Count();

                    if (PetlaKJ.Count - 1 != i)
                        PetlaKJ.Add(context.VPetlaKontrolnaBr10L2Monitorings
                           .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.NrGrawerka.Contains(pn) && x.WynikOperacji == ResultOk && x.NrPaleta != Remove)
                           .Count());
                    else
                        PetlaKJ[i] += context.VPetlaKontrolnaBr10L2Monitorings
                       .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.NrGrawerka.Contains(pn) && x.WynikOperacji == ResultOk && x.NrPaleta != Remove)
                       .Count();
                }

                dateTimeFrom = dateTimeFrom.AddHours(1);
                dateTimeTo = dateTimeTo.AddHours(1);
            }

            //Cela1.Add(Cela1.Sum());
            //Cela2.Add(Cela2.Sum());
            //Cela3.Add(Cela3.Sum());
            //Cela4.Add(Cela4.Sum());
            //Cela5.Add(Cela5.Sum());
            LT.Add(LT.Sum());
            Wkretak.Add(Wkretak.Sum());
            Enkapsulacja.Add(Enkapsulacja.Sum());
            SprawdzianGeometrii.Add(SprawdzianGeometrii.Sum());
            Odkurzacz.Add(Odkurzacz.Sum());
            PetlaKJ.Add(PetlaKJ.Sum());

            //_LineData.Add(WS2B_GPF[0], Cela1);
            //_LineData.Add(WS2B_GPF[1], Cela2);
            //_LineData.Add(WS2B_GPF[2], Cela3);
            //_LineData.Add(WS2B_GPF[3], Cela4);
            //_LineData.Add(WS2B_GPF[4], Cela5);
            _LineData.Add(WS8_GPF[5], LT);
            _LineData.Add(WS8_GPF[6], Wkretak);
            _LineData.Add(WS8_GPF[7], Enkapsulacja);
            _LineData.Add(WS8_GPF[8], SprawdzianGeometrii);
            _LineData.Add(WS8_GPF[9], Odkurzacz);
            _LineData.Add(WS8_GPF[10], PetlaKJ);
        }

        public void GetProductionCountPerHourWS8_BR10_BJA(DateTime dateTime, bool tryb12h)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTimeFrom.AddHours(1);

            int hour = tryb12h ? 12 : 8;

            //Cela1 = new List<int>();
            Cela2 = new List<int>();
            //Cela3 = new List<int>();
            //Cela4 = new List<int>();
            //Cela5 = new List<int>();
            LT = new List<int>();
            Enkapsulacja = new List<int>();
            SprawdzianGeometrii = new List<int>();
            Odkurzacz = new List<int>();
            PetlaKJ = new List<int>();

            const string br10bja = "BR10 BJA";

            var partNumber = Production.GetPartNumber(br10bja);
           // var partNumberKatcon = Production.GetPartNumberKatcon("BR10 BJA");

            IQueryable<int?> parts;

            for (int i = 0; i < hour; i++)
            {
                var frameTimeUtcFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                var frameTimeUtcTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

                var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTime();
                var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTime();

                //parts = dpContext.Ws4Cela1s
                //     .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.Model == br10bja)
                //     .Select(x => x.IloscSztuk);

                //Cela1.Add((int)parts.Sum());

                parts = dpContext.Ws2bCela2lp1s
                     .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.Model == br10bja)
                     .Select(x => x.IloscSztuk);

                Cela2.Add((int)parts.Sum());

                //parts = dpContext.Ws4Cela3s
                //     .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.Model == br10bja)
                //     .Select(x => x.IloscSztuk);

                //Cela3.Add((int)parts.Sum());

                //parts = dpContext.Ws4Cela4s
                //     .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.Model == br10bja)
                //     .Select(x => x.IloscSztuk);

                //Cela4.Add((int)parts.Sum());

                //parts = dpContext.Ws4Cela5s
                //     .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.Model == br10bja)
                //     .Select(x => x.IloscSztuk);

                //Cela5.Add((int)parts.Sum());

                //foreach (var pn in partNumberKatcon)
                //{
                //    if (Cela1.Count - 1 != i)
                //        Cela1.Add(dpContext.Br10Cela1Danes
                //       .Where(x => x.DataCzas >= dateTimeFrom && x.DataCzas < dateTimeTo && x.Referencja.Contains(pn))
                //       .Count());
                //    else
                //        Cela1[i] += dpContext.Br10Cela1Danes
                //                   .Where(x => x.DataCzas >= dateTimeFrom && x.DataCzas < dateTimeTo && x.Referencja.Contains(pn))
                //                   .Count();

                //    if (Cela2.Count - 1 != i)
                //        Cela2.Add(dpContext.Br10Cela2Danes
                //           .Where(x => x.DataCzas >= dateTimeFrom && x.DataCzas < dateTimeTo && x.Referencja.Contains(pn))
                //           .Count());
                //    else
                //        Cela2[i] += dpContext.Br10Cela2Danes
                //                   .Where(x => x.DataCzas >= dateTimeFrom && x.DataCzas < dateTimeTo && x.Referencja.Contains(pn))
                //                   .Count();

                //    if (Cela3.Count - 1 != i)
                //        Cela3.Add(dpContext.Br10Cela3Danes
                //           .Where(x => x.DataCzas >= dateTimeFrom && x.DataCzas < dateTimeTo && x.Referencja.Contains(pn))
                //           .Count());
                //    else
                //        Cela3[i] += dpContext.Br10Cela3Danes
                //                   .Where(x => x.DataCzas >= dateTimeFrom && x.DataCzas < dateTimeTo && x.Referencja.Contains(pn))
                //                   .Count();

                //    if (Cela4.Count - 1 != i)
                //        Cela4.Add(dpContext.Br10Cela4Danes
                //           .Where(x => x.DataCzas >= dateTimeFrom && x.DataCzas < dateTimeTo && x.Referencja.Contains(pn))
                //           .Count());
                //    else
                //        Cela4[i] += dpContext.Br10Cela4Danes
                //                   .Where(x => x.DataCzas >= dateTimeFrom && x.DataCzas < dateTimeTo && x.Referencja.Contains(pn))
                //                   .Count();

                //    if (Cela5.Count - 1 != i)
                //        Cela5.Add(dpContext.Br10Cela5Danes
                //           .Where(x => x.DataCzas >= dateTimeFrom && x.DataCzas < dateTimeTo && x.Referencja.Contains(pn))
                //           .Count());
                //    else
                //        Cela5[i] += dpContext.Br10Cela5Danes
                //                   .Where(x => x.DataCzas >= dateTimeFrom && x.DataCzas < dateTimeTo && x.Referencja.Contains(pn))
                //                   .Count();
                //}


                foreach (var pn in partNumber)
                {
                    if (LT.Count - 1 != i)
                        LT.Add(context.VLeakTesterBr10L2Monitorings
                           .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.NrGrawerka.Contains(pn) && x.WynikTestu == ResultOk)
                           .Count());
                    else
                        LT[i] += context.VLeakTesterBr10L2Monitorings
                       .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.NrGrawerka.Contains(pn) && x.WynikTestu == ResultOk)
                       .Count();

                    if (Enkapsulacja.Count - 1 != i)
                        Enkapsulacja.Add(context.VEnkapsulacjaBr10L2Monitorings
                           .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.NrGrawerka.Contains(pn) && x.WynikOperacji == ResultOk)
                           .Count());
                    else
                        Enkapsulacja[i] += context.VEnkapsulacjaBr10L2Monitorings
                       .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.NrGrawerka.Contains(pn) && x.WynikOperacji == ResultOk)
                       .Count();

                    if (SprawdzianGeometrii.Count - 1 != i)
                        SprawdzianGeometrii.Add(context.VFinalGaugeBr10L2Monitorings
                           .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.NrGrawerka.Contains(pn) && x.WynikOperacji == ResultOk)
                           .Count());
                    else
                        SprawdzianGeometrii[i] += context.VFinalGaugeBr10L2Monitorings
                       .Where(x => x.FrameTime >= frameTimeUtcFrom && x.FrameTime < frameTimeUtcTo && x.NrGrawerka.Contains(pn) && x.WynikOperacji == ResultOk)
                       .Count();

                    if (Odkurzacz.Count - 1 != i)
                        Odkurzacz.Add(context.VOdkurzaczBr10L2Monitorings
                           .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.NrGrawerka.Contains(pn) && x.WynikOperacji == ResultOk)
                           .Count());
                    else
                        Odkurzacz[i] += context.VOdkurzaczBr10L2Monitorings
                       .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.NrGrawerka.Contains(pn) && x.WynikOperacji == ResultOk)
                       .Count();

                    if (PetlaKJ.Count - 1 != i)
                        PetlaKJ.Add(context.VPetlaKontrolnaBr10L2Monitorings
                           .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.NrGrawerka.Contains(pn) && x.WynikOperacji == ResultOk && x.NrPaleta != Remove)
                           .Count());
                    else
                        PetlaKJ[i] += context.VPetlaKontrolnaBr10L2Monitorings
                       .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.NrGrawerka.Contains(pn) && x.WynikOperacji == ResultOk && x.NrPaleta != Remove)
                       .Count();
                }

                dateTimeFrom = dateTimeFrom.AddHours(1);
                dateTimeTo = dateTimeTo.AddHours(1);

            }

            //Cela1.Add(Cela1.Sum());
            Cela2.Add(Cela2.Sum());
            //Cela3.Add(Cela3.Sum());
            //Cela4.Add(Cela4.Sum());
            //Cela5.Add(Cela5.Sum());
            LT.Add(LT.Sum());
            Enkapsulacja.Add(Enkapsulacja.Sum());
            SprawdzianGeometrii.Add(SprawdzianGeometrii.Sum());
            Odkurzacz.Add(Odkurzacz.Sum());
            PetlaKJ.Add(PetlaKJ.Sum());

            //_LineData.Add(WS2B_BJA[0], Cela1);
            _LineData.Add(WS8_BJA[1], Cela2);
            //_LineData.Add(WS2B_BJA[2], Cela3);
            //_LineData.Add(WS2B_BJA[3], Cela4);
            //_LineData.Add(WS2B_BJA[4], Cela5);
            _LineData.Add(WS8_BJA[5], LT);
            _LineData.Add(WS8_BJA[6], Enkapsulacja);
            _LineData.Add(WS8_BJA[7], SprawdzianGeometrii);
            _LineData.Add(WS8_BJA[8], Odkurzacz);
            _LineData.Add(WS8_BJA[9], PetlaKJ);
        }

        public int GetCountFromDayWS4(string line, DateTime dateTime)
        {
            var dateTimeFrom = dateTime;
            var dateTimeTo = dateTime.AddDays(1);

            var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc_AllDay();
            var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc_AllDay();

            string model = string.Empty;
            int count = 0;

            if (line == LineDescription.LineWS8_BJA)
                model = "BR10 BJA";
            else if (line == LineDescription.LineWS8_GPF)
                model = "BR10 GPF";

            var partNumber = Production.GetPartNumber(model);

            foreach(var pn in partNumber)
            {
                count += context.VFinalGaugeBr10L2Monitorings
               .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.NrGrawerka.Contains(pn) && x.WynikOperacji == ResultOk)
               .Count();
            }

            return count;
        }

        public int[] GetDailyRaport(DateTime dateTime, string model)
        {
            int[] partsShift = new int[3];           

            var partNumber = Production.GetPartNumber(model);

            foreach (var pn in partNumber)
            {
                var dateTimeFrom = dateTime;
                var dateTimeTo = dateTime.AddHours(8);

                for (int i = 0; i < 3; i++)
                {
                    var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
                    var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

                    partsShift[i] += context.VFinalGaugeBr10L2Monitorings
                       .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo) && x.WynikOperacji == ResultOk && x.NrGrawerka.Contains(pn))
                       .Count();

                    dateTimeFrom = dateTimeFrom.AddHours(8);
                    dateTimeTo = dateTimeTo.AddHours(8);
                }
            }

            return partsShift;
        }

        public int ActiveShift(string line, DateTime dateTime)
        {
            int shifts = 0;

            var dateTimeFrom = dateTime.Date;
            dateTimeFrom = dateTimeFrom.AddHours(6);
            var dateTimeTo = dateTime.Date;
            dateTimeTo = dateTimeTo.AddHours(14);

            var frameTimeFrom = dateTimeFrom.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = dateTimeTo.ConvertDateTimeToFrameTimeUtc();

            string model = string.Empty;

            if (line == LineDescription.LineWS8_BJA)
                model = "BR10 BJA";
            else if (line == LineDescription.LineWS8_GPF)
                model = "BR10 GPF";

            var partNumber = Production.GetPartNumber(model);


            for (int i = 0; i < 3; i++)
            {
                foreach (var pn in partNumber)
                {
                    var result = context.VFinalGaugeBr10L2Monitorings
                   .Where(x => x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo && x.NrGrawerka.Contains(pn) && x.WynikOperacji == ResultOk)
                   .Count();

                    if (result > 10)
                    {
                        shifts++;
                    }
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

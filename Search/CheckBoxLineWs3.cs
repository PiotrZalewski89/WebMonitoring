using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WebMonitoring.DataBase;
using WebMonitoring.Models;

namespace WebMonitoring.Search
{
    public class CheckBoxLineWs3 : BaseSearchClass
    {
        private StorageStationDbContext context { get; set; }
        private Codes Codes { get; set; }

        public bool All { get; set; }
        public bool CeleSpawalnicza3 { get; set; }
        public bool PLT { get; set; }
        public bool Enkapsulacja { get; set; }
        public bool Wkretak { get; set; }
        public bool Homologacja { get; set; }
        public bool FLT { get; set; }
        public bool FG { get; set; }
        public bool Odkurzacz { get; set; }
        public bool PetlaKJ { get; set; }
        public bool Stf { get; set; }
        public new string HtmlTable { get; set; }
        public IList<BasicColumn> DaneCelaSprawalnicza3 { get; set; }
        public IList<ColumnLT> DanePLT { get; set; }
        public IList<BasicColumn> DaneEnkapsulacja { get; set; }
        public IList<ColumnTorque> DaneWkretak { get; set; }
        public IList<BasicColumn> DaneHomologacja { get; set; }
        public IList<ColumnFLT> DaneFLT { get; set; }
        public IList<BasicColumn> DaneFG { get; set; }
        public IList<BasicColumn> DaneOdkurzacz { get; set; }
        public IList<ColumnCL> DanePetlaKJ { get; set; }
        public CheckBoxLineWs3()
        {
            context = new StorageStationDbContext();
            FindData = new List<string>();
        }

        private Codes FindCode(string code)
        {
            var result = context.PreleakTesterL1s
                .Where(x => x.NrGrawerka == code)
                .Select(x => new Codes
                {
                    CodeBasic = x.NrShella,
                    CodeCatalyst = x.NrGrawerka
                }).ToArray();


            if (result.Length == 0)
            {
                result = context.PreleakTesterL1s
                       .Where(x => x.NrGrawerka.Contains(code))
                       .Select(x => new Codes
                       {
                           CodeBasic = x.NrShella,
                           CodeCatalyst = x.NrGrawerka
                       }).ToArray();

                if (result.Length == 0)
                {
                    result = context.PreleakTesterL1s
                    .Where(x => x.NrShella.Contains(code))
                    .Select(x => new Codes
                    {
                        CodeBasic = x.NrShella,
                        CodeCatalyst = x.NrGrawerka
                    }).ToArray();

                    if (result.Length == 0)
                        result = context.PreleakTesterL1s
                        .Where(x => x.NrGrawerka2.Contains(code))
                        .Select(x => new Codes
                        {
                            CodeBasic = x.NrShella,
                            CodeCatalyst = x.NrGrawerka
                        }).ToArray();
                }
            }

            Codes resultCode = new Codes();

            if (result.Length > 0)
            {
                resultCode.CodeBasic = result[0]?.CodeBasic;
                resultCode.CodeCatalyst = result[0]?.CodeCatalyst;
            }
            else
            {
                resultCode.CodeBasic = Brak;
                resultCode.CodeCatalyst = Brak;
            }

            return resultCode;
        }

        private IList<string> FindCodeByPzzw(string find)
        {
            Codes resultCode = new Codes();

            var codeFromPzzw = context.PetlaKontrolnaHr10L1s
                .Where(x => x.NrPaleta == find)
                .Select(x => x.NrGrawerka)
                .ToArray();

            return codeFromPzzw;
        }

        private IList<BasicColumn> GetDataFromWeldingCell3(string code)
        {
            var result = context.Cela8AbbL1s
                          .Where(x => x.NrShella == code)
                          .Select(x => new BasicColumn
                          {
                              Nr_Shell = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              Nr_linii = x.NrLinii,
                              Frame_time = x.FrameTime,
                              Frame_time2 = x.FrameTime2,
                              Frame_time3 = x.FrameTime3
                          }).ToArray();

            //var result = get.ToList();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, r.Frame_time2, r.Frame_time3, null);
                }
            }

            return result;
        }

        private IList<ColumnLT> GetDataFromPLT(string code)
        {
            var result = context.PreleakTesterL1s
                         .Where(x => x.NrGrawerka == code)
                          .Select(x => new ColumnLT
                          {
                              Nr_Shell = x.NrShella,
                              Nr_Grawerka = x.NrGrawerka,
                              Nr_Grawerka2 = x.NrGrawerka2,
                              Wynik_operacji = x.WynikTestu,
                              Wyciek = x.Wyciek,
                              Wyciek_jedn = x.WyciekJedn,
                              Cisnienie = x.Cisnienie,
                              Cisnienie_jedn = x.CisnienieJedn,
                              Nr_linii = x.NrLinii,
                              Frame_time = x.FrameTime,
                              Frame_time2 = x.FrameTime2,
                              Frame_time3 = x.FrameTime3
                          }).ToArray();

            //var result = get?.ToList();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, r.Frame_time2, r.Frame_time3, null);
                }
            }
            else
            {
                result = context.PreleakTesterL1s
                         .Where(x => x.NrShella == code)
                          .Select(x => new ColumnLT
                          {
                              Nr_Shell = x.NrShella,
                              Nr_Grawerka = x.NrGrawerka,
                              Nr_Grawerka2 = x.NrGrawerka2,
                              Wynik_operacji = x.WynikTestu,
                              Wyciek = x.Wyciek,
                              Wyciek_jedn = x.WyciekJedn,
                              Cisnienie = x.Cisnienie,
                              Cisnienie_jedn = x.CisnienieJedn,
                              Nr_linii = x.NrLinii,
                              Frame_time = x.FrameTime,
                              Frame_time2 = x.FrameTime2,
                              Frame_time3 = x.FrameTime3
                          }).ToArray();

                if (result.Length > 0)
                {
                    foreach (var r in result)
                    {
                        r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, r.Frame_time2, r.Frame_time3, null);
                    }
                }
            }

            return result;
        }

        private IList<BasicColumn> GetDataFromInletPress(string code)
        {
            var result = context.InletPressL1s
                    .Where(x => x.NrGrawerka == code)
                     .Select(x => new BasicColumn
                     {
                         Nr_Shell = x.NrShella,
                         Nr_Grawerka = x.NrGrawerka,
                         Wynik_operacji = x.WynikOperacji,
                         Nr_linii = x.NrLinii,
                         Frame_time = x.FrameTime,
                         Frame_time2 = x.FrameTime2,
                         Frame_time3 = x.FrameTime3
                     }).ToArray();

            //var result = get?.ToList();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, r.Frame_time2, r.Frame_time3, null);
                }
            }

            return result;
        }

        private IList<ColumnTorque> GetDataFromTorque(string code)
        {
            var result = context.TorqueScrewdriverL1s
                    .Where(x => x.NrGrawerka == code)
                      .Select(x => new ColumnTorque
                      {
                          Nr_Shell = x.NrShella,
                          Nr_Grawerka = x.NrGrawerka,
                          Wynik_operacji = x.WynikOperacji,
                          Kat_nakretka1 = x.AngleNakretka1,
                          Moment_nakretka1 = x.TorqueNakretka1,
                          Kat_nakretka2 = x.AngleNakretka2,
                          Moment_nakretka2 = x.TorqueNakretka2,
                          Nr_linii = x.NrLinii,
                          Frame_time = x.FrameTime,
                          Frame_time2 = x.FrameTime2,
                          Frame_time3 = x.FrameTime3
                      }).ToArray();

            //var result = get?.ToList();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, r.Frame_time2, r.Frame_time3, null);
                }
            }

            return result;
        }

        private IList<BasicColumn> GetDataFromHomologation(string code)
        {
            var result = context.HomologationL1s
                      .Where(x => x.NrGrawerka == code)
                      .Select(x => new BasicColumn
                      {
                          Nr_Shell = x.NrShella,
                          Nr_Grawerka = x.NrGrawerka,
                          Wynik_operacji = x.WynikOperacji,
                          Nr_linii = x.NrLinii,
                          Frame_time = x.FrameTime,
                          Frame_time2 = x.FrameTime2,
                          Frame_time3 = x.FrameTime3
                      }).ToArray();

            //var result = get?.ToList();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, r.Frame_time2, r.Frame_time3, null);
                }
            }

            return result;
        }

        private IList<ColumnFLT> GetDataFromFLT(string code)
        {
            var result = context.FinalleakTesterL1s
                    .Where(x => x.NrGrawerka == code)
                    .Select(x => new ColumnFLT
                    {
                        Nr_Shell = x.NrShella,
                        Nr_Grawerka = x.NrGrawerka,
                        Wynik_operacji = x.WynikTestu,
                        Wyciek = x.Wyciek,
                        Wyciek_jedn = x.WyciekJedn,
                        Cisnienie = x.Cisnienie,
                        Cisnienie_jedn = x.CisnienieJedn,
                        Wartosc_Przeplywu_Rurki_1 = x.WartoscPrzeplywuRurki1,
                        Wartosc_Przeplywu_Rurki_2 = x.WartoscPrzeplywuRurki2,
                        Nr_linii = x.NrLinii,
                        Frame_time = x.FrameTime,
                        Frame_time2 = x.FrameTime2,
                        Frame_time3 = x.FrameTime3
                    }).ToArray();

            //var result = get?.ToList();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, r.Frame_time2, r.Frame_time3, null);
                }
            }

            return result;
        }

        private IList<BasicColumn> GetDataFromFinalGauge(string code)
        {
            var result = context.CheckFixtureL1s
                    .Where(x => x.NrGrawerka == code)
                    .Select(x => new BasicColumn
                    {
                        Nr_Shell = x.NrShella,
                        Nr_Grawerka = x.NrGrawerka,
                        Wynik_operacji = x.WynikOperacji,
                        Nr_linii = x.NrLinii,
                        Frame_time = x.FrameTime,
                        Frame_time2 = x.FrameTime2,
                        Frame_time3 = x.FrameTime3
                    }).ToArray();

            //var result = get?.ToList();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, r.Frame_time2, r.Frame_time3, null);
                }
            }

            return result;
        }

        private IList<BasicColumn> GetDataFromVaccumCleaner(string code)
        {
            var result = context.OdkurzaczHr10L1s
                    .Where(x => x.NrGrawerka == code)
                    .OrderByDescending(x => x.Id)
                    .Select(x => new BasicColumn
                    {
                        Nr_Shell = x.NrShella,
                        Nr_Grawerka = x.NrGrawerka,
                        Wynik_operacji = x.WynikOperacji,
                        Nr_linii = x.NrLinii,
                        Frame_time = x.FrameTime,
                        Frame_time2 = x.FrameTime2,
                        Frame_time3 = x.FrameTime3
                    }).ToArray();

            //var result = get?.ToList();

            if (result.Length > 0)
            {
                foreach(var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, r.Frame_time2, r.Frame_time3, null, true);
                }
            }

            return result;
        }

        private IList<ColumnCL> GetDataFromControlLoop(string code)
        {
           var result = context.PetlaKontrolnaHr10L1s
                    .Where(x => x.NrGrawerka == code)
                    .OrderByDescending(x => x.Id)
                    .Select(x => new ColumnCL
                    {
                        Nr_Grawerka = x.NrGrawerka,
                        PZZW = x.NrPaleta,
                        Wynik_operacji = x.WynikOperacji,
                        Uwagi = x.Quality,
                        Nr_linii = x.NrLinii,
                        OperatorID = x.NrOperatora,
                        Frame_time = x.FrameTime,
                        Frame_time2 = x.FrameTime2,
                        Frame_time3 = x.FrameTime3
                    }).ToArray();

            

            //var result = get?.ToList();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, r.Frame_time2, r.Frame_time3, null, true);
                }
            }

            return result;
        }

        private IList<BasicColumn> GetDataFromWeldingCell3ByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Cela8AbbL1s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                          || (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo)
                          || (x.FrameTime3 >= frameTimeFrom && x.FrameTime3 < frameTimeTo))
                          .Select(x => new BasicColumn
                          {
                              Nr_Shell = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              Nr_linii = x.NrLinii,
                              Frame_time = x.FrameTime,
                              Frame_time2 = x.FrameTime2,
                              Frame_time3 = x.FrameTime3
                          })
                          .ToArray();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, r.Frame_time2, r.Frame_time3, null);
                }
            }

            return result;
        }

        private IList<ColumnLT> GetDataFromPLTByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.PreleakTesterL1s
                        .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                          || (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo)
                          || (x.FrameTime3 >= frameTimeFrom && x.FrameTime3 < frameTimeTo))
                          .Select(x => new ColumnLT
                          {
                              Nr_Shell = x.NrShella,
                              Nr_Grawerka = x.NrGrawerka,
                              Nr_Grawerka2 = x.NrGrawerka2,
                              Wynik_operacji = x.WynikTestu,
                              Wyciek = x.Wyciek,
                              Wyciek_jedn = x.WyciekJedn,
                              Cisnienie = x.Cisnienie,
                              Cisnienie_jedn = x.CisnienieJedn,
                              Nr_linii = x.NrLinii,
                              Frame_time = x.FrameTime,
                              Frame_time2 = x.FrameTime2,
                              Frame_time3 = x.FrameTime3
                          })
                     .ToArray();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, r.Frame_time2, r.Frame_time3, null);
                }
            }
            else
            {
                result = context.PreleakTesterL1s
                         .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                          || (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo)
                          || (x.FrameTime3 >= frameTimeFrom && x.FrameTime3 < frameTimeTo))
                          .Select(x => new ColumnLT
                          {
                              Nr_Shell = x.NrShella,
                              Nr_Grawerka = x.NrGrawerka,
                              Nr_Grawerka2 = x.NrGrawerka2,
                              Wynik_operacji = x.WynikTestu,
                              Wyciek = x.Wyciek,
                              Wyciek_jedn = x.WyciekJedn,
                              Cisnienie = x.Cisnienie,
                              Cisnienie_jedn = x.CisnienieJedn,
                              Nr_linii = x.NrLinii,
                              Frame_time = x.FrameTime,
                              Frame_time2 = x.FrameTime2,
                              Frame_time3 = x.FrameTime3
                          })
                     .ToArray();

                if (result.Length > 0)
                {
                    foreach (var r in result)
                    {
                        r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, r.Frame_time2, r.Frame_time3, null);
                    }
                }
            }

            return result;
        }

        private IList<BasicColumn> GetDataFromInletPressByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.InletPressL1s
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                          || (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo)
                          || (x.FrameTime3 >= frameTimeFrom && x.FrameTime3 < frameTimeTo))
                     .Select(x => new BasicColumn
                     {
                         Nr_Shell = x.NrShella,
                         Nr_Grawerka = x.NrGrawerka,
                         Wynik_operacji = x.WynikOperacji,
                         Nr_linii = x.NrLinii,
                         Frame_time = x.FrameTime,
                         Frame_time2 = x.FrameTime2,
                         Frame_time3 = x.FrameTime3
                     })
                     .ToArray();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, r.Frame_time2, r.Frame_time3, null);
                }
            }

            return result;
        }

        private IList<ColumnTorque> GetDataFromTorqueByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.TorqueScrewdriverL1s
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                          || (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo)
                          || (x.FrameTime3 >= frameTimeFrom && x.FrameTime3 < frameTimeTo))
                      .Select(x => new ColumnTorque
                      {
                          Nr_Shell = x.NrShella,
                          Nr_Grawerka = x.NrGrawerka,
                          Wynik_operacji = x.WynikOperacji,
                          Kat_nakretka1 = x.AngleNakretka1,
                          Moment_nakretka1 = x.TorqueNakretka1,
                          Kat_nakretka2 = x.AngleNakretka2,
                          Moment_nakretka2 = x.TorqueNakretka2,
                          Nr_linii = x.NrLinii,
                          Frame_time = x.FrameTime,
                          Frame_time2 = x.FrameTime2,
                          Frame_time3 = x.FrameTime3
                      })
                     .ToArray();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, r.Frame_time2, r.Frame_time3, null);
                }
            }

            return result;
        }

        private IList<BasicColumn> GetDataFromHomologationByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.HomologationL1s
                      .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                          || (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo)
                          || (x.FrameTime3 >= frameTimeFrom && x.FrameTime3 < frameTimeTo))
                      .Select(x => new BasicColumn
                      {
                          Nr_Shell = x.NrShella,
                          Nr_Grawerka = x.NrGrawerka,
                          Wynik_operacji = x.WynikOperacji,
                          Nr_linii = x.NrLinii,
                          Frame_time = x.FrameTime,
                          Frame_time2 = x.FrameTime2,
                          Frame_time3 = x.FrameTime3
                      })
                      .ToArray();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, r.Frame_time2, r.Frame_time3, null);
                }
            }

            return result;
        }

        private IList<ColumnFLT> GetDataFromFLTByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.FinalleakTesterL1s
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                          || (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo)
                          || (x.FrameTime3 >= frameTimeFrom && x.FrameTime3 < frameTimeTo))
                    .Select(x => new ColumnFLT
                    {
                        Nr_Shell = x.NrShella,
                        Nr_Grawerka = x.NrGrawerka,
                        Wynik_operacji = x.WynikTestu,
                        Wyciek = x.Wyciek,
                        Wyciek_jedn = x.WyciekJedn,
                        Cisnienie = x.Cisnienie,
                        Cisnienie_jedn = x.CisnienieJedn,
                        Wartosc_Przeplywu_Rurki_1 = x.WartoscPrzeplywuRurki1,
                        Wartosc_Przeplywu_Rurki_2 = x.WartoscPrzeplywuRurki2,
                        Nr_linii = x.NrLinii,
                        Frame_time = x.FrameTime,
                        Frame_time2 = x.FrameTime2,
                        Frame_time3 = x.FrameTime3
                    })
                     .ToArray();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, r.Frame_time2, r.Frame_time3, null);
                }
            }

            return result;
        }

        private IList<BasicColumn> GetDataFromFinalGaugeByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.CheckFixtureL1s
                    .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                          || (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo)
                          || (x.FrameTime3 >= frameTimeFrom && x.FrameTime3 < frameTimeTo))
                    .Select(x => new BasicColumn
                    {
                        Nr_Shell = x.NrShella,
                        Nr_Grawerka = x.NrGrawerka,
                        Wynik_operacji = x.WynikOperacji,
                        Nr_linii = x.NrLinii,
                        Frame_time = x.FrameTime,
                        Frame_time2 = x.FrameTime2,
                        Frame_time3 = x.FrameTime3
                    })
                      .ToArray();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, r.Frame_time2, r.Frame_time3, null);
                }
            }

            return result;
        }

        private IList<BasicColumn> GetDataFromVaccumCleanerByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTime();
            var frameTimeTo = to.ConvertDateTimeToFrameTime();

            var result = context.OdkurzaczHr10L1s
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                          || (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo)
                          || (x.FrameTime3 >= frameTimeFrom && x.FrameTime3 < frameTimeTo))
                    .OrderByDescending(x => x.Id)
                    .Select(x => new BasicColumn
                    {
                        Nr_Shell = x.NrShella,
                        Nr_Grawerka = x.NrGrawerka,
                        Wynik_operacji = x.WynikOperacji,
                        Nr_linii = x.NrLinii,
                        Frame_time = x.FrameTime,
                        Frame_time2 = x.FrameTime2,
                        Frame_time3 = x.FrameTime3
                    })
                      .ToArray();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, r.Frame_time2, r.Frame_time3, null, true);
                }
            }

            return result;
        }

        private IList<ColumnCL> GetDataFromControlLoopByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTime();
            var frameTimeTo = to.ConvertDateTimeToFrameTime();

            var result = context.PetlaKontrolnaHr10L1s
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                          || (x.FrameTime2 >= frameTimeFrom && x.FrameTime2 < frameTimeTo)
                          || (x.FrameTime3 >= frameTimeFrom && x.FrameTime3 < frameTimeTo))
                    .OrderByDescending(x => x.Id)
                    .Select(x => new ColumnCL
                    {
                        Nr_Grawerka = x.NrGrawerka,
                        PZZW = x.NrPaleta,
                        Wynik_operacji = x.WynikOperacji,
                        Uwagi = x.Quality,
                        Nr_linii = x.NrLinii,
                        OperatorID = x.NrOperatora,
                        Frame_time = x.FrameTime,
                        Frame_time2 = x.FrameTime2,
                        Frame_time3 = x.FrameTime3
                    })
                    .ToArray();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, r.Frame_time2, r.Frame_time3, null, true);
                }
            }

            return result;
        }

        public void GetDataCode(bool download = false)
        {
            DaneCelaSprawalnicza3 = new List<BasicColumn>();
            DanePLT = new List<ColumnLT>();
            DaneEnkapsulacja = new List<BasicColumn>();
            DaneWkretak = new List<ColumnTorque>();
            DaneHomologacja = new List<BasicColumn>();
            DaneFLT = new List<ColumnFLT>();
            DaneFG = new List<BasicColumn>();
            DaneOdkurzacz = new List<BasicColumn>();
            DanePetlaKJ = new List<ColumnCL>();
            HtmlTable = string.Empty;

            if (SelectCode)
            {
                FindDataCode(FindData);
            }
            else if (SelectPzzw)
            {
                foreach (var pzzw in FindData)
                {
                    var codes = FindCodeByPzzw(pzzw);

                    if (codes?.Count > 0)
                    {
                        FindDataCode(codes);
                    }
                }
            }
            else if (SelectDate)
            {
                DateTime from = (DateTime)DateTime;
                DateTime to = (DateTime)DateTime.Value.AddDays(1);

                if (CeleSpawalnicza3)
                {
                    var result = GetDataFromWeldingCell3ByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneCelaSprawalnicza3.Add(r);
                    }
                }

                if (PLT)
                {
                    var result = GetDataFromPLTByDate(from, to);

                    foreach (var r in result)
                    {
                        DanePLT.Add(r);
                    }
                }

                if (Enkapsulacja)
                {
                    var result = GetDataFromInletPressByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneEnkapsulacja.Add(r);
                    }
                }

                if (Wkretak)
                {
                    var result = GetDataFromTorqueByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneWkretak.Add(r);
                    }
                }

                if (Homologacja)
                {
                    var result = GetDataFromHomologationByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneHomologacja.Add(r);
                    }
                }

                if (FLT)
                {
                    var result = GetDataFromFLTByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneFLT.Add(r);
                    }
                }

                if (FG)
                {
                    var result = GetDataFromFinalGaugeByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneFG.Add(r);
                    }
                }

                if (Odkurzacz)
                {
                    var result = GetDataFromVaccumCleanerByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneOdkurzacz.Add(r);
                    }
                }

                if (PetlaKJ)
                {
                    var result = GetDataFromControlLoopByDate(from, to);

                    foreach (var r in result)
                    {
                        DanePetlaKJ.Add(r);
                    }
                }
            }

            if (download)
                WriteData();
        }

        private void FindDataCode(IList<string> codes)
        {
            foreach (var code in codes)
            {
                Codes = FindCode(code);

                if(Stf && Codes.CodeBasic != Brak)
                {
                    Stf_3_6 stf = new Stf_3_6();
                    stf.GetDataFromSql(Codes.CodeBasic);
                    if (!string.IsNullOrEmpty(stf.HtmlTable))
                        HtmlTable = stf.HtmlTable;
                }

                if (CeleSpawalnicza3 && Codes.CodeBasic != Brak)
                {
                    var result = GetDataFromWeldingCell3(Codes.CodeBasic);

                    foreach (var r in result)
                    {
                        DaneCelaSprawalnicza3.Add(r);
                    }
                }

                if (PLT && Codes.CodeBasic != Brak)
                {
                    var result = GetDataFromPLT(Codes.CodeBasic);

                    foreach (var r in result)
                    {
                        DanePLT.Add(r);
                    }
                }

                if (Enkapsulacja && Codes.CodeCatalyst != Brak)
                {
                    var result = GetDataFromInletPress(Codes.CodeCatalyst);

                    foreach (var r in result)
                    {
                        DaneEnkapsulacja.Add(r);
                    }
                }

                if (Wkretak && Codes.CodeCatalyst != Brak)
                {
                    var result = GetDataFromTorque(Codes.CodeCatalyst);

                    foreach (var r in result)
                    {
                        DaneWkretak.Add(r);
                    }
                }

                if (Homologacja && Codes.CodeCatalyst != Brak)
                {
                    var result = GetDataFromHomologation(Codes.CodeCatalyst);

                    foreach (var r in result)
                    {
                        DaneHomologacja.Add(r);
                    }
                }

                if (FLT && Codes.CodeCatalyst != Brak)
                {
                    var result = GetDataFromFLT(Codes.CodeCatalyst);

                    foreach (var r in result)
                    {
                        DaneFLT.Add(r);
                    }
                }

                if (FG && Codes.CodeCatalyst != Brak)
                {
                    var result = GetDataFromFinalGauge(Codes.CodeCatalyst);

                    foreach (var r in result)
                    {
                        DaneFG.Add(r);
                    }
                }

                if (Odkurzacz && Codes.CodeCatalyst != Brak)
                {
                    var result = GetDataFromVaccumCleaner(Codes.CodeCatalyst);

                    foreach (var r in result)
                    {
                        DaneOdkurzacz.Add(r);
                    }
                }

                if (PetlaKJ && Codes.CodeCatalyst != Brak)
                {
                    var result = GetDataFromControlLoop(Codes.CodeCatalyst);

                    foreach (var r in result)
                    {
                        DanePetlaKJ.Add(r);
                    }
                }
            }
        }

        private void WriteData()
        {
            DataTable dataTable = new DataTable();

            Table = new List<string>();
            FileName = new List<string>();

            if (DaneCelaSprawalnicza3?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneCelaSprawalnicza3.ToArray()));
                FileName.Add("CelaSpawalnicza3");
            }

            if (DanePLT?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DanePLT.ToArray()));
                FileName.Add("PreLeaktester");
            }

            if (DaneEnkapsulacja?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneEnkapsulacja.ToArray()));
                FileName.Add("Enkapsulacja");
            }

            if (DaneWkretak?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneWkretak.ToArray()));
                FileName.Add("WkrętakRurek");
            }

            if (DaneHomologacja?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneHomologacja.ToArray()));
                FileName.Add("Homologacja");
            }

            if (DaneFLT?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneFLT.ToArray()));
                FileName.Add("FinalLeaktester");
            }

            if (DaneFG?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneFG.ToArray()));
                FileName.Add("SprawdzianGeometrii");
            }

            if (DaneOdkurzacz?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneOdkurzacz.ToArray()));
                FileName.Add("Odkurzacz");
            }

            if (DanePetlaKJ?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DanePetlaKJ.ToArray()));
                FileName.Add("PetlaKJ");
            }
        }
    }



}

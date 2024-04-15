using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WebMonitoring.DataBase;
using WebMonitoring.Models;

namespace WebMonitoring.Search
{
    public class CheckBoxLineWs4 : BaseSearchClass
    {
        private StorageStationDbContext context { get; set; }
        private Codes Codes { get; set; }

        public bool All { get; set; }
        public bool Wiremash { get; set; }
        public bool SizerBja { get; set; }
        public bool CeleSpawalnicza5 { get; set; }
        public bool LT { get; set; }
        public bool Enkapsulacja { get; set; }
        public bool Wkretak { get; set; }
        public bool FG { get; set; }
        public bool Odkurzacz { get; set; }
        public bool PetlaKJ { get; set; }
        public bool Stf { get; set; }
        public IList<BasicColumn> DaneWiremash { get; set; }
        public IList<BasicColumn> DaneSizerBja { get; set; }
        public IList<BasicColumn> DaneCelaSprawalnicza5 { get; set; }
        public IList<ColumnLT> DaneLT { get; set; }
        public IList<BasicColumn> DaneEnkapsulacja { get; set; }
        public IList<BasicColumn> DaneWkretak { get; set; }
        public IList<BasicColumn> DaneFG { get; set; }
        public IList<BasicColumn> DaneOdkurzacz { get; set; }
        public IList<ColumnCL> DanePetlaKJ { get; set; }

        public new string HtmlTable { get; set; }

        public CheckBoxLineWs4()
        {
            context = new StorageStationDbContext();
            FindData = new List<string>();
        }

        private Codes FindCode(string code)
        {
            var result = context.LeakTesterBr10L2s
                .Where(x => x.NrGrawerka == code)
                .Select(x => new Codes
                {
                    CodeBasic = x.NrShella,
                    CodeCatalyst = x.NrGrawerka
                }).ToArray();


            if (result.Length == 0)
            {
                result = context.LeakTesterBr10L2s
                       .Where(x => x.NrGrawerka.Contains(code))
                       .Select(x => new Codes
                       {
                           CodeBasic = x.NrShella,
                           CodeCatalyst = x.NrGrawerka
                       }).ToArray();

                if (result.Length == 0)
                {
                    result = context.LeakTesterBr10L2s
                    .Where(x => x.NrShella.Contains(code))
                    .Select(x => new Codes
                    {
                        CodeBasic = x.NrShella,
                        CodeCatalyst = x.NrGrawerka
                    }).ToArray();

                    if (result.Length == 0)
                        result = context.LeakTesterBr10L2s
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

            var codeFromPzzw = context.PetlaKontrolnaBr10L2s
                .Where(x => x.NrPaleta == find)
                .Select(x => x.NrGrawerka)
                .ToArray();

            return codeFromPzzw;
        }

        private IList<BasicColumn> GetDataFromWiremash(string code)
        {
            var result = context.WiremeshBr10L2s
                          .Where(x => x.NrShella == code)
                          .Select(x => new BasicColumn
                          {
                              Nr_Shell = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime
                          }).ToArray();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, null, null, null);
                }
            }

            return result;
        }

        private IList<BasicColumn> GetDataFromSizerBja(string code)
        {
            var result = context.GbdIoCalibrationBr10L2s
                          .Where(x => x.NrShella == code)
                          .Select(x => new BasicColumn
                          {
                              Nr_Shell = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime
                          }).ToArray();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, null, null, null);
                }
            }

            return result;
        }

        private IList<BasicColumn> GetDataFromWeldingCell5(string code)
        {
            var result = context.Cela5AbbBr10L2s
                          .Where(x => x.NrShella == code)
                          .Select(x => new BasicColumn
                          {
                              Nr_Shell = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime
                          }).ToArray();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, null, null, null);
                }
            }

            return result;
        }

        private IList<ColumnLT> GetDataFromLT(string code)
        {
            var result = context.LeakTesterBr10L2s
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
                              Frame_time = x.FrameTime
                          }).ToArray();


            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, null, null, null);
                }
            }
            else
            {
                result = context.LeakTesterBr10L2s
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
                              Frame_time = x.FrameTime
                          }).ToArray();

                if (result.Length > 0)
                {
                    foreach (var r in result)
                    {
                        r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, null, null, null);
                    }
                }
            }

            return result;
        }

        private IList<BasicColumn> GetDataFromPress(string code)
        {
            var result = context.EnkapsulacjaBr10L2s
                    .Where(x => x.NrGrawerka == code)
                     .Select(x => new BasicColumn
                     {
                         Nr_Shell = x.NrShella,
                         Nr_Grawerka = x.NrGrawerka,
                         Wynik_operacji = x.WynikOperacji,
                         Frame_time = x.FrameTime
                     }).ToArray();

            //var result = get?.ToList();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, null, null, null);
                }
            }

            return result;
        }

        private IList<BasicColumn> GetDataFromTorque(string code)
        {
            var result = context.WkretakBr10L2s
                    .Where(x => x.NrGrawerka == code)
                      .Select(x => new BasicColumn
                      {
                          Nr_Shell = x.NrShella,
                          Nr_Grawerka = x.NrGrawerka,
                          Wynik_operacji = x.WynikOperacji,
                          Frame_time = x.FrameTime
                      }).ToArray();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, null, null, null);
                }
            }

            return result;
        }
                    
        private IList<BasicColumn> GetDataFromFinalGauge(string code)
        {
            var result = context.FinalGaugeBr10L2s
                    .Where(x => x.NrGrawerka == code)
                    .Select(x => new BasicColumn
                    {
                        Nr_Shell = x.NrShella,
                        Nr_Grawerka = x.NrGrawerka,
                        Wynik_operacji = x.WynikOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();

            //var result = get?.ToList();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, null, null, null);
                }
            }

            return result;
        }

        private IList<BasicColumn> GetDataFromVaccumCleaner(string code)
        {
            var result = context.OdkurzaczBr10L2s
                    .Where(x => x.NrGrawerka == code)
                    .OrderByDescending(x => x.Id)
                    .Select(x => new BasicColumn
                    {
                        Nr_Shell = x.NrShella,
                        Nr_Grawerka = x.NrGrawerka,
                        Wynik_operacji = x.WynikOperacji,
                        Frame_time = x.FrameTime,
                        DateTime = (DateTime)x.DtOperacji
                    }).ToArray();

            return result;
        }

        private IList<ColumnCL> GetDataFromControlLoop(string code)
        {
            var result = context.PetlaKontrolnaBr10L2s
                     .Where(x => x.NrGrawerka == code)
                     .OrderByDescending(x => x.Id)
                     .Select(x => new ColumnCL
                     {
                         Nr_Grawerka = x.NrGrawerka,
                         PZZW = x.NrPaleta,
                         Wynik_operacji = x.WynikOperacji,
                         Uwagi = x.Quality,
                         OperatorID = x.NrOperatora,
                         Frame_time = x.FrameTime
                     }).ToArray();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, null, null, null, true);
                }
            }

            return result;
        }

        private IList<BasicColumn> GetDataFromWiremashByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.WiremeshBr10L2s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new BasicColumn
                          {
                              Nr_Shell = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime
                          })
                          .ToArray();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, null, null, null);
                }
            }

            return result;
        }

        private IList<BasicColumn> GetDataFromSizerbjaByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.GbdIoCalibrationBr10L2s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new BasicColumn
                          {
                              Nr_Shell = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime
                          })
                          .ToArray();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, null, null, null);
                }
            }

            return result;
        }

        private IList<BasicColumn> GetDataFromWeldingCell5ByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Cela5AbbBr10L2s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new BasicColumn
                          {
                              Nr_Shell = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime
                          })
                          .ToArray();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, null, null, null);
                }
            }

            return result;
        }

        private IList<ColumnLT> GetDataFromLTByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.LeakTesterBr10L2s
                        .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
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
                              Frame_time = x.FrameTime
                          })
                     .ToArray();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, null, null, null);
                }
            }

            return result;
        }

        private IList<BasicColumn> GetDataFromPressByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.EnkapsulacjaBr10L2s
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                     .Select(x => new BasicColumn
                     {
                         Nr_Shell = x.NrShella,
                         Nr_Grawerka = x.NrGrawerka,
                         Wynik_operacji = x.WynikOperacji,
                         Frame_time = x.FrameTime
                     })
                     .ToArray();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, null, null, null);
                }
            }

            return result;
        }

        private IList<BasicColumn> GetDataFromTorqueByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.WkretakBr10L2s
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                      .Select(x => new BasicColumn
                      {
                          Nr_Shell = x.NrShella,
                          Nr_Grawerka = x.NrGrawerka,
                          Wynik_operacji = x.WynikOperacji,
                          Frame_time = x.FrameTime
                      })
                     .ToArray();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, null, null, null);
                }
            }

            return result;
        }

        private IList<BasicColumn> GetDataFromFinalGaugeByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.FinalGaugeBr10L2s
                    .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .Select(x => new BasicColumn
                    {
                        Nr_Shell = x.NrShella,
                        Nr_Grawerka = x.NrGrawerka,
                        Wynik_operacji = x.WynikOperacji,
                        Frame_time = x.FrameTime
                    })
                      .ToArray();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, null, null, null);
                }
            }

            return result;
        }

        private IList<BasicColumn> GetDataFromVaccumCleanerByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTime();
            var frameTimeTo = to.ConvertDateTimeToFrameTime();

            var result = context.OdkurzaczBr10L2s
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .OrderByDescending(x => x.Id)
                    .Select(x => new BasicColumn
                    {
                        Nr_Shell = x.NrShella,
                        Nr_Grawerka = x.NrGrawerka,
                        Wynik_operacji = x.WynikOperacji,
                        Frame_time = x.FrameTime
                    })
                      .ToArray();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, null, null, null, true);
                }
            }

            return result;
        }

        private IList<ColumnCL> GetDataFromControlLoopByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTime();
            var frameTimeTo = to.ConvertDateTimeToFrameTime();

            var result = context.PetlaKontrolnaBr10L2s
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .OrderByDescending(x => x.Id)
                    .Select(x => new ColumnCL
                    {
                        Nr_Grawerka = x.NrGrawerka,
                        PZZW = x.NrPaleta,
                        Wynik_operacji = x.WynikOperacji,
                        Uwagi = x.Quality,
                        OperatorID = x.NrOperatora,
                        Frame_time = x.FrameTime
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
            DaneWiremash = new List<BasicColumn>();
            DaneSizerBja = new List<BasicColumn>();
            DaneCelaSprawalnicza5 = new List<BasicColumn>();
            DaneLT = new List<ColumnLT>();
            DaneEnkapsulacja = new List<BasicColumn>();
            DaneWkretak = new List<BasicColumn>();
            DaneFG = new List<BasicColumn>();
            DaneOdkurzacz = new List<BasicColumn>();
            DanePetlaKJ = new List<ColumnCL>();

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

                if (Wiremash)
                {
                    var result = GetDataFromWiremashByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneWiremash.Add(r);
                    }
                }

                if (SizerBja)
                {
                    var result = GetDataFromSizerbjaByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneSizerBja.Add(r);
                    }
                }

                if (CeleSpawalnicza5)
                {
                    var result = GetDataFromWeldingCell5ByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneCelaSprawalnicza5.Add(r);
                    }
                }

                if (LT)
                {
                    var result = GetDataFromLTByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneLT.Add(r);
                    }
                }

                if (Enkapsulacja)
                {
                    var result = GetDataFromPressByDate(from, to);

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

                if (Stf && Codes.CodeBasic != Brak)
                {
                    Stf_3_6 stf = new Stf_3_6();
                    stf.GetDataFromSql(Codes.CodeBasic);
                    if (!string.IsNullOrEmpty(stf.HtmlTable))
                        HtmlTable = stf.HtmlTable;
                }

                if (Wiremash && Codes.CodeBasic != Brak)
                {
                    var result = GetDataFromWiremash(Codes.CodeBasic);

                    foreach (var r in result)
                    {
                        DaneWiremash.Add(r);
                    }
                }

                if (SizerBja && Codes.CodeBasic != Brak)
                {
                    var result = GetDataFromSizerBja(Codes.CodeBasic);

                    foreach (var r in result)
                    {
                        DaneSizerBja.Add(r);
                    }
                }

                if (CeleSpawalnicza5 && Codes.CodeBasic != Brak)
                {
                    var result = GetDataFromWeldingCell5(Codes.CodeBasic);

                    foreach (var r in result)
                    {
                        DaneCelaSprawalnicza5.Add(r);
                    }
                }

                if (LT && Codes.CodeBasic != Brak)
                {
                    var result = GetDataFromLT(Codes.CodeBasic);

                    foreach (var r in result)
                    {
                        DaneLT.Add(r);
                    }
                }

                if (Enkapsulacja && Codes.CodeCatalyst != Brak)
                {
                    var result = GetDataFromPress(Codes.CodeCatalyst);

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

            if (DaneCelaSprawalnicza5?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneCelaSprawalnicza5.ToArray()));
                FileName.Add("CelaSpawalnicza5");
            }

            if (DaneLT?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneLT.ToArray()));
                FileName.Add("leak tester");
            }

            if (DaneEnkapsulacja?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneEnkapsulacja.ToArray()));
                FileName.Add("Enkapsulacja");
            }

            if (DaneWkretak?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneWkretak.ToArray()));
                FileName.Add("Wkretak");
            }

            if (DaneSizerBja?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneSizerBja.ToArray()));
                FileName.Add("Sizer GBD IO");
            }

            if (DaneWiremash?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneWiremash.ToArray()));
                FileName.Add("Wiremash");
            }

            if (DaneFG?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneFG.ToArray()));
                FileName.Add("Sprawdzian geometrii");
            }

            if (DaneOdkurzacz?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneOdkurzacz.ToArray()));
                FileName.Add("Odkurzacz");
            }

            if (DanePetlaKJ?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DanePetlaKJ.ToArray()));
                FileName.Add("Petla KJ");
            }
        }
    }



}

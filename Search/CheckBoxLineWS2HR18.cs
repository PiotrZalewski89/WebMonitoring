using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WebMonitoring.DataBase;
using WebMonitoring.Models;

namespace WebMonitoring.Search
{
    public class CheckBoxLineWS2HR18 : BaseSearchClass
    {
        private StorageStationDbContext context { get; set; }
        private Codes Codes { get; set; }

        public bool All { get; set; }
        public bool Cela_spawalnicza { get; set; }
        public bool Tester_szczelności { get; set; }
        public bool Sprawdzian_geometrii { get; set; }
        public bool Odkurzacz { get; set; }
        public bool ControlLoop_KJ { get; set; }
        public bool Stf { get; set; }
        public new string HtmlTable { get; set; }

        public IList<BasicColumn> DaneCelaSpawalnicza { get; set; }
        public IList<ColumnLT> DaneLT { get; set; }
        public IList<BasicColumn> DaneFG { get; set; }
        public IList<BasicColumn> DaneVacuum { get; set; }
        public IList<ColumnCL> DaneCL { get; set; }


        public CheckBoxLineWS2HR18()
        {
            context = new StorageStationDbContext();
            FindData = new List<string>();
        }

        private Codes FindCode(string code)
        {
            var result = context.Hr18LeaktesterL5s
                .Where(x => x.NrGrawerka == code)
                .Select(x => new Codes
                {
                    CodeBasic = x.NrShella,
                    CodeCatalyst = x.NrGrawerka
                }).ToArray();


            if (result.Length == 0)
            {
                result = context.Hr18LeaktesterL5s
                       .Where(x => x.NrGrawerka.Contains(code))
                       .Select(x => new Codes
                       {
                           CodeBasic = x.NrShella,
                           CodeCatalyst = x.NrGrawerka
                       }).ToArray();

                if (result.Length == 0)
                {
                    result = context.Hr18LeaktesterL5s
                    .Where(x => x.NrShella.Contains(code))
                    .Select(x => new Codes
                    {
                        CodeBasic = x.NrShella,
                        CodeCatalyst = x.NrGrawerka
                    }).ToArray();

                    if (result.Length == 0)
                        result = context.Hr18LeaktesterL5s
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

            var codeFromPzzw = context.Hr18ControlLoopL5s
                .Where(x => x.NrPzzw == find)
                .Select(x => x.NrKatalizatora)
                .ToArray();

            return codeFromPzzw;
        }

        private IList<BasicColumn> GetDataFromWeldingCell(string code)
        {
            var result = context.Hr18WeldingCellL5s
                          .Where(x => x.NrBasic == code)
                          .Select(x => new BasicColumn
                          {
                              Nr_Shell = x.NrBasic,
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



        private IList<ColumnLT> GetDataFromLT(string code)
        {
            var result = context.Hr18LeaktesterL5s
                    .Where(x => x.NrGrawerka == code)
                    .Select(x => new ColumnLT
                    {
                        Nr_Shell = x.NrShella,
                        Nr_Grawerka = x.NrGrawerka,
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

            return result;
        }

        private IList<BasicColumn> GetDataFromFinalGauge(string code)
        {
            var result = context.Hr18FinalGaugeL5s
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
            var result = context.Hr18VacuumL5s
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
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, null, null, null, true);
                }
            }

            return result;
        }

        private IList<ColumnCL> GetDataFromControlLoop(string code)
        {
            var result = context.Hr18ControlLoopL5s
                     .Where(x => x.NrKatalizatora == code)
                     .Select(x => new ColumnCL
                     {
                         Nr_Grawerka = x.NrKatalizatora,
                         PZZW = x.NrPzzw,
                         Wynik_operacji = x.WynikOperacji,
                         Uwagi = x.Quality,
                         OperatorID = x.NrOperatora,
                         Frame_time = x.FrameTime
                     }).ToArray();



            //var result = get?.ToList();

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, null, null, null, true);
                }
            }

            return result;
        }

        private IList<BasicColumn> GetDataFromWeldingCell_ByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Hr18WeldingCellL5s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                          )
                          .Select(x => new BasicColumn
                          {
                              Nr_Shell = x.NrBasic,
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

        private IList<ColumnLT> GetDataFromPLTByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Hr18LeaktesterL5s
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
                result = context.Hr18LeaktesterL5s
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


        private IList<BasicColumn> GetDataFromFinalGaugeByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Hr18FinalGaugeL5s
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

            var result = context.Hr18VacuumL5s
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                          )
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
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, r.Frame_time2, r.Frame_time3, null, true);
                }
            }

            return result;
        }

        private IList<ColumnCL> GetDataFromControlLoopByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTime();
            var frameTimeTo = to.ConvertDateTimeToFrameTime();

            var result = context.Hr18ControlLoopL5s
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo)
                          )                 
                    .Select(x => new ColumnCL
                    {
                        Nr_Grawerka = x.NrKatalizatora,
                        PZZW = x.NrPzzw,
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
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, null, null, null, true);
                }
            }

            return result;
        }

        public void GetDataCode(bool download = false)
        {
            DaneCelaSpawalnicza = new List<BasicColumn>();
            DaneLT = new List<ColumnLT>();
            DaneFG = new List<BasicColumn>();
            DaneVacuum = new List<BasicColumn>();
            DaneCL = new List<ColumnCL>();

            if (SelectCode)
            {
                foreach (var code in FindData)
                {
                    Codes = FindCode(code);

                    if (Stf && Codes.CodeBasic != Brak)
                    {
                        Stf_3_6 stf = new Stf_3_6();
                        stf.GetDataFromSql(Codes.CodeBasic);
                        if (!string.IsNullOrEmpty(stf.HtmlTable))
                            HtmlTable = stf.HtmlTable;
                    }

                    if (Cela_spawalnicza && Codes.CodeBasic != Brak)
                    {
                        var result = GetDataFromWeldingCell(Codes.CodeBasic);

                        foreach (var r in result)
                        {
                            DaneCelaSpawalnicza.Add(r);
                        }
                    }

                    if (Tester_szczelności && Codes.CodeBasic != Brak)
                    {
                        var result = GetDataFromLT(Codes.CodeBasic);

                        foreach (var r in result)
                        {
                            DaneLT.Add(r);
                        }
                    }

                    if (Sprawdzian_geometrii && Codes.CodeCatalyst != Brak)
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
                            DaneVacuum.Add(r);
                        }
                    }

                    if (ControlLoop_KJ && Codes.CodeCatalyst != Brak)
                    {
                        var result = GetDataFromControlLoop(Codes.CodeCatalyst);

                        foreach (var r in result)
                        {
                            DaneCL.Add(r);
                        }
                    }
                }
            }
            else if (SelectPzzw)
            {
                foreach (var pzzw in FindData)
                {
                    var codes = FindCodeByPzzw(pzzw);

                    if (codes?.Count > 0)
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

                            if (Cela_spawalnicza && Codes.CodeBasic != Brak)
                            {
                                var result = GetDataFromWeldingCell(Codes.CodeBasic);

                                foreach (var r in result)
                                {
                                    DaneCelaSpawalnicza.Add(r);
                                }
                            }

                            if (Tester_szczelności && Codes.CodeBasic != Brak)
                            {
                                var result = GetDataFromLT(Codes.CodeBasic);

                                foreach (var r in result)
                                {
                                    DaneLT.Add(r);
                                }
                            }

                            if (Sprawdzian_geometrii && Codes.CodeCatalyst != Brak)
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
                                    DaneVacuum.Add(r);
                                }
                            }

                            if (ControlLoop_KJ && Codes.CodeCatalyst != Brak)
                            {
                                var result = GetDataFromControlLoop(Codes.CodeCatalyst);

                                foreach (var r in result)
                                {
                                    DaneCL.Add(r);
                                }
                            }
                        }
                    }
                }
            }
            else if (SelectDate)
            {
                DateTime from = (DateTime)DateTime;
                DateTime to = (DateTime)DateTime.Value.AddDays(1);

                if (Cela_spawalnicza)
                {
                    var result = GetDataFromWeldingCell_ByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneCelaSpawalnicza.Add(r);
                    }
                }

                if (Tester_szczelności)
                {
                    var result = GetDataFromPLTByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneLT.Add(r);
                    }
                }

                if (Sprawdzian_geometrii)
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
                        DaneVacuum.Add(r);
                    }
                }

                if (ControlLoop_KJ)
                {
                    var result = GetDataFromControlLoopByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneCL.Add(r);
                    }
                }
            }


            if (download)
                WriteData();
        }

        private void WriteData()
        {
            DataTable dataTable = new DataTable();

            Table = new List<string>();
            FileName = new List<string>();

            if (DaneCelaSpawalnicza?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneCelaSpawalnicza.ToArray()));
                FileName.Add("CelaSpawalnicza");
            }

            if (DaneLT?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneLT.ToArray()));
                FileName.Add("Leak tester");
            }

            if (DaneFG?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneFG.ToArray()));
                FileName.Add("Sprawdzian geometrii");
            }

            if (DaneVacuum?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneVacuum.ToArray()));
                FileName.Add("Odkurzacz");
            }

            if (DaneCL?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneCL.ToArray()));
                FileName.Add("Petla KJ");
            }
        }
    }



}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WebMonitoring.DataBase;
using WebMonitoring.Models;

namespace WebMonitoring.Search
{
    public class CheckBoxLineWs1Cnh : BaseSearchClass
    {
        private CnhDbContext context { get; set; }
        private Codes Codes { get; set; }

        public bool All { get; set; }
        public bool FLT { get; set; }
        public bool VisualStation { get; set; }
        public bool Czyszczenie { get; set; }
        public bool PetlaKJ { get; set; }
        public bool Stf { get; set; }

        public IList<IQueryable<Table.CNH.CnhWs2Shell>> DaneStf2 { get; set; }
        public IList<ColumnLT> DaneFLT { get; set; }
        public IList<ColumnCL> DaneCzyszczenie{ get; set; }
        public IList<ColumnCL> DanePetlaKJ { get; set; }
        public IList<ColumnCL> DaneVisualStation{ get; set; }

        public CheckBoxLineWs1Cnh()
        {
            context = new CnhDbContext();
            FindData = new List<string>();
        }

        private Codes FindCode(string code)
        {
            var result = context.Ws1CnhFinalLeaktesterL3s
                .Where(x => x.NrWygenerowany == code)
                .Select(x => new Codes
                {
                    CodeBasic = x.NrShella,
                    CodeCatalyst = x.NrWygenerowany
                }).ToArray();


            if (result.Length == 0)
            {
                result = context.Ws1CnhFinalLeaktesterL3s
                       .Where(x => x.NrWygenerowany.Contains(code))
                       .Select(x => new Codes
                       {
                           CodeBasic = x.NrShella,
                           CodeCatalyst = x.NrWygenerowany
                       }).ToArray();

                if (result.Length == 0)
                {
                    result = context.Ws1CnhFinalLeaktesterL3s
                    .Where(x => x.NrShella.Contains(code))
                    .Select(x => new Codes
                    {
                        CodeBasic = x.NrShella,
                        CodeCatalyst = x.NrWygenerowany
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

            var codeFromPzzw = context.Ws1CnhPetlaKontrolnaL3s
                .Where(x => x.NrPaleta == find)
                .Select(x => x.NrKatalizatora)
                .ToArray();

            return codeFromPzzw;
        }

        private IList<ColumnLT> GetDataFromFLT(string code)
        {
            var result = context.Ws1CnhFinalLeaktesterL3s
                    .Where(x => x.NrWygenerowany == code)
                    .Select(x => new ColumnLT
                    {
                        Nr_Shell = x.NrShella,
                        Nr_Grawerka = x.NrWygenerowany,
                        Wynik_operacji = x.WynikOperacji,
                        Wyciek = x.Wyciek,
                        Wyciek_jedn = x.WyciekJedn,
                        Cisnienie = x.Cisnienie,
                        Cisnienie_jedn = x.CisnienieJedn,
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

        private IList<ColumnCL> GetDataFromCleaning(string code)
        {
            var result = context.Ws1CnhCleaningL3s
                    .Where(x => x.NrKatalizatora == code)
                    .OrderByDescending(x => x.Id)
                    .Select(x => new ColumnCL
                    {
                        Nr_Grawerka = x.NrKatalizatora,
                        Wynik_operacji = x.WynikOperacji,
                        PZZW = x.NrPaleta,
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
        private IList<ColumnCL> GetDataFromVisualStation(string code)
        {
            var result = context.Ws1CnhVisualStationL3s
                    .Where(x => x.NrKatalizatora == code)
                    .OrderByDescending(x => x.Id)
                    .Select(x => new ColumnCL
                    {
                        Nr_Grawerka = x.NrKatalizatora,
                        Wynik_operacji = x.WynikOperacji,
                        Uwagi = x.Uwagi,
                        DateTime = (DateTime)x.DtOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();

            return result;
        }


        private IList<ColumnCL> GetDataFromControlLoop(string code)
        {
            var result = context.Ws1CnhPetlaKontrolnaL3s
                     .Where(x => x.NrKatalizatora == code)
                     .OrderByDescending(x => x.Id)
                     .Select(x => new ColumnCL
                     {
                         Nr_Grawerka = x.NrKatalizatora,
                         PZZW = x.NrPaleta,
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

        private IList<ColumnLT> GetDataFromFLTByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTime();
            var frameTimeTo = to.ConvertDateTimeToFrameTime();

            var result = context.Ws1CnhFinalLeaktesterL3s
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .Select(x => new ColumnLT
                    {
                        Nr_Shell = x.NrShella,
                        Nr_Grawerka = x.NrWygenerowany,
                        Wynik_operacji = x.WynikOperacji,
                        Wyciek = x.Wyciek,
                        Wyciek_jedn = x.WyciekJedn,
                        Cisnienie = x.Cisnienie,
                        Cisnienie_jedn = x.CisnienieJedn,
                        Frame_time = x.FrameTime,
                        DateTime = (DateTime)x.DtOperacji
                    })
                     .ToArray();

            return result;
        }

        private IList<ColumnCL> GetDataFromCleaningByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTime();
            var frameTimeTo = to.ConvertDateTimeToFrameTime();

            var result = context.Ws1CnhCleaningL3s
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .OrderByDescending(x => x.Id)
                    .Select(x => new ColumnCL
                    {
                        Nr_Grawerka = x.NrKatalizatora,
                        Wynik_operacji = x.WynikOperacji,
                        PZZW = x.NrPaleta,
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

        private IList<ColumnCL> GetDataFromVisualStationByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTime();
            var frameTimeTo = to.ConvertDateTimeToFrameTime();

            var result = context.Ws1CnhVisualStationL3s
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .OrderByDescending(x => x.Id)
                    .Select(x => new ColumnCL
                    {
                        Nr_Grawerka = x.NrKatalizatora,
                        Wynik_operacji = x.WynikOperacji,
                        Uwagi = x.Uwagi,
                        DateTime = (DateTime)x.DtOperacji,
                        Frame_time = x.FrameTime
                    })
                      .ToArray();

            return result;
        }

        private IList<ColumnCL> GetDataFromControlLoopByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTime();
            var frameTimeTo = to.ConvertDateTimeToFrameTime();

            var result = context.Ws1CnhPetlaKontrolnaL3s
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .OrderByDescending(x => x.Id)
                    .Select(x => new ColumnCL
                    {
                        Nr_Grawerka = x.NrKatalizatora,
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
            DaneFLT = new List<ColumnLT>();
            DaneCzyszczenie = new List<ColumnCL>();
            DanePetlaKJ = new List<ColumnCL>();
            DaneVisualStation = new List<ColumnCL>();
            HtmlTable = new List<string>();
            DaneStf2 = new List<IQueryable<Table.CNH.CnhWs2Shell>>();

            if (SelectCode)
            {
                foreach (var code in FindData)
                {
                    Codes = FindCode(code);

                    if (Stf && Codes.CodeBasic != Brak)
                    {
                        var result = GetDataFromSqlStf2(Codes.CodeBasic);

                        if (result != null)
                        {
                            DaneStf2.Add(result);

                            if (!download)
                            {
                                DataTable dataTable = new DataTable();

                                HtmlTable.Add(dataTable.WriteToTable(result.ToArray()));
                            }
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

                    if (Czyszczenie && Codes.CodeCatalyst != Brak)
                    {
                        var result = GetDataFromCleaning(Codes.CodeCatalyst);

                        foreach (var r in result)
                        {
                            DaneCzyszczenie.Add(r);
                        }
                    }

                    if (VisualStation && Codes.CodeCatalyst != Brak)
                    {
                        var result = GetDataFromVisualStation(Codes.CodeCatalyst);

                        foreach (var r in result)
                        {
                            DaneVisualStation.Add(r);
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
                                var result = GetDataFromSqlStf2(Codes.CodeBasic);

                                if (result != null)
                                {
                                    DaneStf2.Add(result);

                                    if (!download)
                                    {
                                        DataTable dataTable = new DataTable();

                                        HtmlTable.Add(dataTable.WriteToTable(result.ToArray()));
                                    }
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

                            if (Czyszczenie && Codes.CodeCatalyst != Brak)
                            {
                                var result = GetDataFromCleaning(Codes.CodeCatalyst);

                                foreach (var r in result)
                                {
                                    DaneCzyszczenie.Add(r);
                                }
                            }

                            if (VisualStation && Codes.CodeCatalyst != Brak)
                            {
                                var result = GetDataFromVisualStation(Codes.CodeCatalyst);

                                foreach (var r in result)
                                {
                                    DaneVisualStation.Add(r);
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
                }
            }
            else if (SelectDate)
            {
                DateTime from = (DateTime)DateTime;
                DateTime to = (DateTime)DateTime.Value.AddDays(1);

                if (FLT)
                {
                    var result = GetDataFromFLTByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneFLT.Add(r);
                    }
                }

                if (Czyszczenie)
                {
                    var result = GetDataFromCleaningByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneCzyszczenie.Add(r);
                    }
                }
                if (VisualStation)
                {
                    var result = GetDataFromVisualStationByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneVisualStation.Add(r);
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

        public IQueryable<Table.CNH.CnhWs2Shell> GetDataFromSqlStf2(string nr)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(nr))
                {
                    return context.CnhWs2Shells
                            .Where(x => x.ShellSerialNum == nr);
                }
            }
            catch { }

            return null;
        }

        private void WriteData()
        {
            DataTable dataTable = new DataTable();

            Table = new List<string>();
            FileName = new List<string>();

            if (DaneStf2?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneStf2.ToArray()));
                FileName.Add("Stf2");
            }

            if (DaneFLT?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneFLT.ToArray()));
                FileName.Add("Final leaktester");
            }

            if (DaneCzyszczenie?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneCzyszczenie.ToArray()));
                FileName.Add("Czyszczenie");
            }

            if (DaneVisualStation?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneVisualStation.ToArray()));
                FileName.Add("Kontrola wizyjna");
            }

            if (DanePetlaKJ?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DanePetlaKJ.ToArray()));
                FileName.Add("Petla KJ");
            }
        }
    }
}

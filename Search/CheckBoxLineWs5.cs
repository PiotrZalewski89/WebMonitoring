using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WebMonitoring.DataBase;
using WebMonitoring.Models;

namespace WebMonitoring.Search
{
    public class CheckBoxLineWs5 : BaseSearchClass
    {
        private CnhDbContext context { get; set; }
        private CodesWs5 Codes { get; set; }

        public bool All { get; set; }
        public bool Etap1 { get; set; }
        public bool Etap2 { get; set; }
        public bool Etap3 { get; set; }
        public bool PLT { get; set; }
        public bool FLT { get; set; }
        public bool Etap4 { get; set; }
        public bool FG { get; set; }
        public bool PetlaKJ { get; set; }

        public IList<IQueryable<Table.CNH.CnhWs1MeasuredAssembly>> DaneStf1 { get; set; }
        public IList<IQueryable<Table.CNH.CnhWs2Shell>> DaneStf2 { get; set; }
        public IList<BasicColumnWs5> DaneEtap1 { get; set; }
        public IList<BasicColumnWs5> DaneEtap2 { get; set; }
        public IList<BasicColumnWs5> DaneEtap3 { get; set; }
        public IList<ColumnLTWs5> DanePLT { get; set; }
        public IList<ColumnLTWs5> DaneFLT { get; set; }
        public IList<BasicColumnWs5> DaneEtap4 { get; set; }
        public IList<BasicColumnWs5> DaneFG { get; set; }
        public IList<ColumnCL> DanePetlaKJ { get; set; }
        public bool Stf2 { get; set; }
        public bool Stf1 { get; set; }
        public bool Stf { get; set; }

        public CheckBoxLineWs5()
        {
            context = new CnhDbContext();
            FindData = new List<string>();
        }

        private CodesWs5 FindCode(string code)
        {
            var result = context.CnhFinalleakTesters
                .Where(x => x.NrOslony == code)
                .Select(x => new CodesWs5
                {
                    CodeBasicDoc = x.NrShellaDoc,
                    CodeBasicScrof = x.NrShellaScrof,
                    CodeBasicScrcuc = x.NrShellaScrcuc,
                    CodeMixer = x.NrMixer,
                    CodeCatalyst = x.NrOslony
                }).ToArray();


            if (result.Length == 0)
            {
                result = context.CnhFinalleakTesters
                       .Where(x => x.NrOslony.Contains(code) || x.NrShellaDoc.Contains(code) || x.NrShellaScrcuc.Contains(code) || x.NrShellaScrof.Contains(code))
                      .Select(x => new CodesWs5
                      {
                          CodeBasicDoc = x.NrShellaDoc,
                          CodeBasicScrof = x.NrShellaScrof,
                          CodeBasicScrcuc = x.NrShellaScrcuc,
                          CodeMixer = x.NrMixer,
                          CodeCatalyst = x.NrOslony
                      }).ToArray();               
            }

            CodesWs5 resultCode = new CodesWs5();

            if (result.Length > 0)
            {
                resultCode.CodeBasicDoc = result[0]?.CodeBasicDoc;
                resultCode.CodeBasicScrof = result[0]?.CodeBasicScrof;
                resultCode.CodeBasicScrcuc = result[0]?.CodeBasicScrcuc;
                resultCode.CodeMixer = result[0].CodeMixer;
                resultCode.CodeCatalyst = result[0]?.CodeCatalyst;
            }
            else
            {
                resultCode.CodeBasicDoc = Brak;
                resultCode.CodeBasicScrof = Brak;
                resultCode.CodeBasicScrcuc = Brak;
                resultCode.CodeMixer = Brak;
                resultCode.CodeCatalyst = Brak;
            }

            return resultCode;
        }

        private IList<string> FindCodeByPzzw(string find)
        {
            CodesWs5 resultCode = new CodesWs5();

            var codeFromPzzw = context.Ws5CnhPetlaKontrolnaL1s
                .Where(x => x.NrPaleta == find)
                .Select(x => x.NrKatalizatora)
                .ToArray();

            return codeFromPzzw;
        }

        private IList<BasicColumnWs5> GetDataFromEtap1(string code)
        {
            var result = context.CnhEtap1s
                          .Where(x => x.NrShellaDoc == code)
                          .Select(x => new BasicColumnWs5
                          {
                              NrShellDoc = x.NrShellaDoc,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();


            return result;
        }

        private IList<BasicColumnWs5> GetDataFromEtap2(string code)
        {
            var result = context.CnhEtap2s
                          .Where(x => x.NrShellaScrof == code)
                          .Select(x => new BasicColumnWs5
                          {
                              NrShellScrof = x.NrShellaScrof,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();


            return result;
        }

        private IList<BasicColumnWs5> GetDataFromEtap3(string code)
        {
            var result = context.CnhEtap3s
                          .Where(x => x.NrShellaScrcuc == code)
                          .Select(x => new BasicColumnWs5
                          {
                              NrShellScrucu = x.NrShellaScrcuc,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();


            return result;
        }

        private IList<ColumnLTWs5> GetDataFromPLT(string code)
        {
            var result = context.CnhPreleakTesters
                         .Where(x => x.NrMixer == code)
                          .Select(x => new ColumnLTWs5
                          {
                              NrMixer = x.NrMixer,
                              Wynik_operacji = x.WynikOperacji,
                              Wyciek = x.Wyciek,
                              Wyciek_jedn = x.WyciekJedn,
                              Cisnienie = x.Cisnienie,
                              Cisnienie_jedn = x.CisnienieJedn,
                              DateTime = (DateTime)x.DtOperacji,
                              Frame_time = x.FrameTime
                          }).ToArray();
                        
            return result;
        }

        private IList<ColumnLTWs5> GetDataFromFLT(string code)
        {
            var result = context.CnhFinalleakTesters
                    .Where(x => x.NrOslony == code)
                    .Select(x => new ColumnLTWs5
                    {
                        NrShellDoc = x.NrShellaDoc,
                        NrShellScrof = x.NrShellaScrof,
                        NrShellScrucu = x.NrShellaScrcuc,
                        NrMixer = x.NrMixer,
                        Nr_Oslona = x.NrOslony,
                        Wynik_operacji = x.WynikOperacji,
                        Wyciek = x.Wyciek,
                        Wyciek_jedn = x.WyciekJedn,
                        Cisnienie = x.Cisnienie,
                        Cisnienie_jedn = x.CisnienieJedn,
                        DateTime = (DateTime)x.DtOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();

            return result;
        }

        private IList<BasicColumnWs5> GetDataFromEtap4(string code)
        {
            var result = context.CnhEtap4s
                          .Where(x => x.NrOslony == code)
                          .Select(x => new BasicColumnWs5
                          {
                              NrShellDoc = x.NrShellaDoc,
                              NrShellScrof = x.NrShellaScrof,
                              NrShellScrucu = x.NrShellaScrcuc,
                              NrMixer = x.NrMixer,
                              Nr_Oslona = x.NrOslony,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<BasicColumnWs5> GetDataFromFinalGauge(string code)
        {
            var result = context.CnhChecks
                    .Where(x => x.NrOslony == code)
                    .Select(x => new BasicColumnWs5
                    {
                        Nr_Oslona = x.NrOslony,
                        Wynik_operacji = x.WynikOperacji,
                        DateTime = (DateTime)x.DtOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();

            return result;
        }
        
        private IList<ColumnCL> GetDataFromControlLoop(string code)
        {
            var result = context.Ws5CnhPetlaKontrolnaL1s
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

            if (result.Length > 0)
            {
                foreach (var r in result)
                {
                    r.DateTime = FrameTime.SelectedFrameTime(r.Frame_time, null, null, null, true);
                }
            }

            return result;
        }

        private IList<BasicColumnWs5> GetDataFromEtap1ByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.CnhEtap1s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new BasicColumnWs5
                          {
                              NrShellDoc = x.NrShellaDoc,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<BasicColumnWs5> GetDataFromEtap2ByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.CnhEtap2s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new BasicColumnWs5
                          {
                              NrShellScrof = x.NrShellaScrof,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<BasicColumnWs5> GetDataFromEtap3ByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.CnhEtap3s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new BasicColumnWs5
                          {
                              NrShellScrucu = x.NrShellaScrcuc,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<ColumnLTWs5> GetDataFromPLTByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.CnhPreleakTesters
                        .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new ColumnLTWs5
                          {
                              NrMixer = x.NrMixer,
                              Wynik_operacji = x.WynikOperacji,
                              Wyciek = x.Wyciek,
                              Wyciek_jedn = x.WyciekJedn,
                              Cisnienie = x.Cisnienie,
                              Cisnienie_jedn = x.CisnienieJedn,
                              DateTime = (DateTime)x.DtOperacji,
                              Frame_time = x.FrameTime
                          }).ToArray();

           return result;
        }
       
        private IList<ColumnLTWs5> GetDataFromFLTByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.CnhFinalleakTesters
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .Select(x => new ColumnLTWs5
                    {
                        NrShellDoc = x.NrShellaDoc,
                        NrShellScrof = x.NrShellaScrof,
                        NrShellScrucu = x.NrShellaScrcuc,
                        NrMixer = x.NrMixer,
                        Nr_Oslona = x.NrOslony,
                        Wynik_operacji = x.WynikOperacji,
                        Wyciek = x.Wyciek,
                        Wyciek_jedn = x.WyciekJedn,
                        Cisnienie = x.Cisnienie,
                        Cisnienie_jedn = x.CisnienieJedn,
                        DateTime = (DateTime)x.DtOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();

            return result;
        }

        private IList<BasicColumnWs5> GetDataFromEtap4ByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.CnhEtap4s
                         .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new BasicColumnWs5
                          {
                              NrShellDoc = x.NrShellaDoc,
                              NrShellScrof = x.NrShellaScrof,
                              NrShellScrucu = x.NrShellaScrcuc,
                              NrMixer = x.NrMixer,
                              Nr_Oslona = x.NrOslony,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<BasicColumnWs5> GetDataFromFinalGaugeByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.CnhChecks
                    .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .Select(x => new BasicColumnWs5
                    {
                        Nr_Oslona = x.NrOslony,
                        Wynik_operacji = x.WynikOperacji,
                        DateTime = (DateTime)x.DtOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();

            return result;
        }

        private IList<ColumnCL> GetDataFromControlLoopByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTime();
            var frameTimeTo = to.ConvertDateTimeToFrameTime();

            var result = context.Ws5CnhPetlaKontrolnaL1s
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

        public void GetDataCode(bool download = false)
        {
            DaneStf1 = new List<IQueryable<Table.CNH.CnhWs1MeasuredAssembly>>();
            DaneStf2 = new List<IQueryable<Table.CNH.CnhWs2Shell>>();

            DaneEtap1 = new List<BasicColumnWs5>();
            DaneEtap2 = new List<BasicColumnWs5>();
            DaneEtap3 = new List<BasicColumnWs5>();
            DaneEtap4 = new List<BasicColumnWs5>();
            DanePLT = new List<ColumnLTWs5>();
            DaneFLT = new List<ColumnLTWs5>();
            DaneFG = new List<BasicColumnWs5>();
            DanePetlaKJ = new List<ColumnCL>();
            HtmlTable = new List<string>();

            Stf1 = Stf2 = Stf;

            if (SelectCode)
            {
                FindDataCode(FindData, download);
            }
            else if (SelectPzzw)
            {
                foreach (var pzzw in FindData)
                {
                    var codes = FindCodeByPzzw(pzzw);

                    if (codes?.Count > 0)
                    {
                        FindDataCode(codes, download);
                    }
                }
            }
            else if (SelectDate)
            {
                DateTime from = (DateTime)DateTime;
                DateTime to = (DateTime)DateTime.Value.AddDays(1);

                if (Etap1)
                {
                    var result = GetDataFromEtap1ByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneEtap1.Add(r);
                    }
                }

                if (Etap2)
                {
                    var result = GetDataFromEtap2ByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneEtap2.Add(r);
                    }
                }

                if (Etap3)
                {
                    var result = GetDataFromEtap3ByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneEtap3.Add(r);
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

                if (FLT)
                {
                    var result = GetDataFromFLTByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneFLT.Add(r);
                    }
                }

                if (Etap4)
                {
                    var result = GetDataFromEtap4ByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneEtap4.Add(r);
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


        private void FindDataCode(IList<string> codes, bool download = false)
        {
            foreach (var code in codes)
            {
                Codes = FindCode(code);

                if (Stf1 && Codes.CodeBasicDoc != Brak)
                {
                    var result = GetDataFromSqlStf1(Codes.CodeBasicDoc);

                    if(result != null)
                    {
                        DaneStf1.Add(result);

                        if(!download)
                        {
                            DataTable dataTable = new DataTable();

                            HtmlTable.Add(dataTable.WriteToTable(result.ToArray()));
                        }
                    }
                }

                if (Stf2 && Codes.CodeBasicScrcuc != Brak)
                {
                    var result = GetDataFromSqlStf2(Codes.CodeBasicScrcuc);

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

                if (Stf2 && Codes.CodeBasicScrof != Brak)
                {
                    var result = GetDataFromSqlStf2(Codes.CodeBasicScrof);

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

                if (Etap1 && Codes.CodeBasicDoc != Brak)
                {
                    var result = GetDataFromEtap1(Codes.CodeBasicDoc);

                    foreach (var r in result)
                    {
                        DaneEtap1.Add(r);
                    }
                }

                if (Etap2 && Codes.CodeBasicScrof != Brak)
                {
                    var result = GetDataFromEtap2(Codes.CodeBasicScrof);

                    foreach (var r in result)
                    {
                        DaneEtap2.Add(r);
                    }
                }

                if (Etap3 && Codes.CodeBasicScrcuc != Brak)
                {
                    var result = GetDataFromEtap3(Codes.CodeBasicScrcuc);

                    foreach (var r in result)
                    {
                        DaneEtap3.Add(r);
                    }
                }

                if (PLT && Codes.CodeMixer != Brak)
                {
                    var result = GetDataFromPLT(Codes.CodeMixer);

                    foreach (var r in result)
                    {
                        DanePLT.Add(r);
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

                if (Etap4 && Codes.CodeCatalyst != Brak)
                {
                    var result = GetDataFromEtap4(Codes.CodeCatalyst);

                    foreach (var r in result)
                    {
                        DaneEtap4.Add(r);
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

        public IQueryable<Table.CNH.CnhWs1MeasuredAssembly> GetDataFromSqlStf1(string nr)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(nr))
                {
                    return context.CnhWs1MeasuredAssemblies
                            .Where(x => x.ShellSerialNum == nr);
                }
            }
            catch { }

            return null;
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

            if (DaneStf1?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneStf1.ToArray()));
                FileName.Add("Stf1");
            }

            if (DaneStf2?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneStf2.ToArray()));
                FileName.Add("Stf2");
            }

            if (DaneEtap1?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneEtap1.ToArray()));
                FileName.Add("Etap1");
            }

            if (DaneEtap2?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneEtap2.ToArray()));
                FileName.Add("Etap2");
            }

            if (DaneEtap3?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneEtap3.ToArray()));
                FileName.Add("Etap3");
            }

            if (DaneEtap4?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneEtap4.ToArray()));
                FileName.Add("Etap4");
            }

            if (DanePLT?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DanePLT.ToArray()));
                FileName.Add("Preleaktester");
            }

            if (DaneFLT?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneFLT.ToArray()));
                FileName.Add("Final leak tetser");
            }

            if (DaneFG?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneFG.ToArray()));
                FileName.Add("Sprawdzian geometrii");
            }

            if (DanePetlaKJ?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DanePetlaKJ.ToArray()));
                FileName.Add("Petla KJ");
            }
        }
    }



}

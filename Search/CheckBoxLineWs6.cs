using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WebMonitoring.DataBase;
using WebMonitoring.Models;

namespace WebMonitoring.Search
{
    public class CheckBoxLineWs6 : BaseSearchClass
    {
        private CnhDbContext context { get; set; }
        private CodesWs6 Codes { get; set; }

        public bool All { get; set; }
        public bool Etap1 { get; set; }
        public bool Etap2 { get; set; }
        public bool Etap3 { get; set; }
        public bool PLTA { get; set; }
        public bool PLTB { get; set; }
        public bool FLT { get; set; }
        public bool Etap4 { get; set; }
        public bool FG { get; set; }
        public bool PetlaKJ { get; set; }

        public IList<IQueryable<Table.CNH.CnhWs1MeasuredAssembly>> DaneStf1 { get; set; }
        public IList<IQueryable<Table.CNH.CnhWs2Shell>> DaneStf2 { get; set; }
        public IList<BasicColumnWs6> DaneEtap1 { get; set; }
        public IList<BasicColumnWs6> DaneEtap2 { get; set; }
        public IList<BasicColumnWs6> DaneEtap3 { get; set; }
        public IList<ColumnLTWs6> DanePLTA { get; set; }
        public IList<ColumnLTWs6> DanePLTB { get; set; }
        public IList<ColumnLTWs6> DaneFLT { get; set; }
        public IList<BasicColumnWs6> DaneEtap4 { get; set; }
        public IList<BasicColumnWs6> DaneFG { get; set; }
        public IList<ColumnCL> DanePetlaKJ { get; set; }
        public bool Stf2 { get; set; }
        public bool Stf1 { get; set; }
        public bool Stf { get; set; }


        public CheckBoxLineWs6()
        {
            context = new CnhDbContext();
            FindData = new List<string>();
        }

        private CodesWs6 FindCode(string code)
        {
            var result = context.Cnh529FinalleakTesters
                .Where(x => x.NrOslony == code)
                .Select(x => new CodesWs6
                {
                    CodeBasicStf1 = x.NrShellaDocDpf,
                    CodeBasicStf2 = x.NrShellaScrScrcuc,
                    CodeCatalyst = x.NrOslony
                }).ToArray();


            if (result.Length == 0)
            {
                result = context.Cnh529FinalleakTesters
                       .Where(x => x.NrOslony.Contains(code) || x.NrShellaDocDpf.Contains(code) || x.NrShellaScrScrcuc.Contains(code))
                      .Select(x => new CodesWs6
                      {
                          CodeBasicStf1 = x.NrShellaDocDpf,
                          CodeBasicStf2 = x.NrShellaScrScrcuc,
                          CodeCatalyst = x.NrOslony
                      }).ToArray();
            }

            CodesWs6 resultCode = new CodesWs6();

            if (result.Length > 0)
            {
                resultCode.CodeBasicStf1 = result[0]?.CodeBasicStf1;
                resultCode.CodeBasicStf2 = result[0]?.CodeBasicStf2;
                resultCode.CodeCatalyst = result[0]?.CodeCatalyst;
            }
            else
            {
                resultCode.CodeBasicStf1 = Brak;
                resultCode.CodeBasicStf2 = Brak;
                resultCode.CodeCatalyst = Brak;
            }

            return resultCode;
        }

        private IList<string> FindCodeByPzzw(string find)
        {
            CodesWs6 resultCode = new CodesWs6();

            var codeFromPzzw = context.Ws6CnhPetlaKontrolnaL2s
                .Where(x => x.NrPaleta == find)
                .Select(x => x.NrKatalizatora)
                .ToArray();

            return codeFromPzzw;
        }

        private IList<BasicColumnWs6> GetDataFromEtap1(string code)
        {
            var result = context.Cnh529Etap1s
                          .Where(x => x.NrShella == code)
                          .Select(x => new BasicColumnWs6
                          {
                              NrShellStf1 = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();


            return result;
        }

        private IList<BasicColumnWs6> GetDataFromEtap2(string code)
        {
            var result = context.Cnh529Etap2s
                          .Where(x => x.NrShella == code)
                          .Select(x => new BasicColumnWs6
                          {
                              NrShellStf2 = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();


            return result;
        }

        private IList<ColumnLTWs6> GetDataFromPLTA(string code)
        {
            var result = context.Cnh529PreleakTesterSekcjaAs
                         .Where(x => x.NrShellaScrScrcuc == code)
                          .Select(x => new ColumnLTWs6
                          {
                              NrShellStf2 = x.NrShellaScrScrcuc,
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

        private IList<ColumnLTWs6> GetDataFromPLTB(string code)
        {
            var result = context.Cnh529PreleakTesterSekcjaBs
                         .Where(x => x.NrShellaDocDpf == code)
                          .Select(x => new ColumnLTWs6
                          {
                              NrShellStf1 = x.NrShellaDocDpf,
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

        private IList<ColumnLTWs6> GetDataFromFLT(string code)
        {
            var result = context.Cnh529FinalleakTesters
                    .Where(x => x.NrOslony == code)
                    .Select(x => new ColumnLTWs6
                    {
                        NrShellStf1 = x.NrShellaDocDpf,
                        NrShellStf2 = x.NrShellaScrScrcuc,
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

        private IList<BasicColumnWs6> GetDataFromEtap3(string code)
        {
            var result = context.Cnh529Etap3s
                          .Where(x => x.NrShella == code)
                          .Select(x => new BasicColumnWs6
                          {
                              NrShellStf2 = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<BasicColumnWs6> GetDataFromEtap4(string code)
        {
            var result = context.Cnh529Etap4s
                          .Where(x => x.NrShella == code)
                          .Select(x => new BasicColumnWs6
                          {
                              NrShellStf1 = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<BasicColumnWs6> GetDataFromFinalGauge(string code)
        {
            var result = context.Cnh529Checks
                    .Where(x => x.NrOslony == code)
                    .Select(x => new BasicColumnWs6
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
            var result = context.Ws6CnhPetlaKontrolnaL2s
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

        private IList<BasicColumnWs6> GetDataFromEtap1ByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Cnh529Etap1s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new BasicColumnWs6
                          {
                              NrShellStf1 = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<BasicColumnWs6> GetDataFromEtap2ByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Cnh529Etap2s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new BasicColumnWs6
                          {
                              NrShellStf2 = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<BasicColumnWs6> GetDataFromEtap3ByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Cnh529Etap3s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new BasicColumnWs6
                          {
                              NrShellStf1 = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<ColumnLTWs6> GetDataFromPLTAByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Cnh529PreleakTesterSekcjaAs
                        .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new ColumnLTWs6
                          {
                              NrShellStf2 = x.NrShellaScrScrcuc,
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

        private IList<ColumnLTWs6> GetDataFromPLTBByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Cnh529PreleakTesterSekcjaBs
                        .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new ColumnLTWs6
                          {
                              NrShellStf1 = x.NrShellaDocDpf,
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

        private IList<ColumnLTWs6> GetDataFromFLTByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Cnh529FinalleakTesters
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .Select(x => new ColumnLTWs6
                    {
                        NrShellStf1 = x.NrShellaDocDpf,
                        NrShellStf2 = x.NrShellaScrScrcuc,
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

        private IList<BasicColumnWs6> GetDataFromEtap4ByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Cnh529Etap4s
                         .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new BasicColumnWs6
                          {
                              NrShellStf2 = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<BasicColumnWs6> GetDataFromFinalGaugeByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Cnh529Checks
                    .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .Select(x => new BasicColumnWs6
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

            var result = context.Ws6CnhPetlaKontrolnaL2s
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
            DaneEtap1 = new List<BasicColumnWs6>();
            DaneEtap2 = new List<BasicColumnWs6>();
            DaneEtap3 = new List<BasicColumnWs6>();
            DaneEtap4 = new List<BasicColumnWs6>();
            DanePLTA = new List<ColumnLTWs6>();
            DanePLTB = new List<ColumnLTWs6>();
            DaneFLT = new List<ColumnLTWs6>();
            DaneFG = new List<BasicColumnWs6>();
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

                if (PLTA)
                {
                    var result = GetDataFromPLTAByDate(from, to);

                    foreach (var r in result)
                    {
                        DanePLTA.Add(r);
                    }
                }

                if (PLTB)
                {
                    var result = GetDataFromPLTBByDate(from, to);

                    foreach (var r in result)
                    {
                        DanePLTB.Add(r);
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


                if (Stf1 && Codes.CodeBasicStf1 != Brak)
                {
                    var result = GetDataFromSqlStf1(Codes.CodeBasicStf1);

                    if (result != null)
                    {
                        DaneStf1.Add(result);

                        if (!download)
                        {
                            DataTable dataTable = new DataTable();

                            HtmlTable.Add(dataTable.WriteToTable(result.ToArray()));
                        }
                    }
                }

                if (Stf2 && Codes.CodeBasicStf2 != Brak)
                {
                    var result = GetDataFromSqlStf2(Codes.CodeBasicStf2);

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

                if (Etap1 && Codes.CodeBasicStf1 != Brak)
                {
                    var result = GetDataFromEtap1(Codes.CodeBasicStf1);

                    foreach (var r in result)
                    {
                        DaneEtap1.Add(r);
                    }
                }

                if (Etap2 && Codes.CodeBasicStf2 != Brak)
                {
                    var result = GetDataFromEtap2(Codes.CodeBasicStf2);

                    foreach (var r in result)
                    {
                        DaneEtap2.Add(r);
                    }
                }

                if (Etap3 && Codes.CodeBasicStf2 != Brak)
                {
                    var result = GetDataFromEtap3(Codes.CodeBasicStf2);

                    foreach (var r in result)
                    {
                        DaneEtap3.Add(r);
                    }
                }

                if (PLTA && Codes.CodeBasicStf2 != Brak)
                {
                    var result = GetDataFromPLTA(Codes.CodeBasicStf2);

                    foreach (var r in result)
                    {
                        DanePLTA.Add(r);
                    }
                }

                if (PLTB && Codes.CodeBasicStf1 != Brak)
                {
                    var result = GetDataFromPLTB(Codes.CodeBasicStf1);

                    foreach (var r in result)
                    {
                        DanePLTB.Add(r);
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

                if (Etap4 && Codes.CodeBasicStf1 != Brak)
                {
                    var result = GetDataFromEtap4(Codes.CodeBasicStf1);

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

            if (DanePLTA?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DanePLTA.ToArray()));
                FileName.Add("Preleaktester sekcja A");
            }

            if (DanePLTB?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DanePLTB.ToArray()));
                FileName.Add("Preleaktester sekcja B");
            }

            if (DaneFLT?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneFLT.ToArray()));
                FileName.Add("Final leaktester");
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



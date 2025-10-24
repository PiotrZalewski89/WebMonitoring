using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WebMonitoring.DataBase;
using WebMonitoring.Models;

namespace WebMonitoring.Search
{
    public class CheckBoxLineWs4M260 : BaseSearchClass
    {
        private StorageStationDbContext context { get; set; }
        private Codes Codes { get; set; }

        public bool All { get; set; }
        public bool PLT { get; set; }
        public bool SizerGBDio { get; set; }
        public bool WeldingCell1 { get; set; }
        public bool LT { get; set; }
        public bool Enkapsulacja1 { get; set; }
        public bool Enkapsulacja2 { get; set; }
        public bool CelaRezystancyjna8 { get; set; }
        public bool SpawaniePinu { get; set; }
        public bool FG { get; set; }
        public bool Odkurzacz { get; set; }
        public bool StacjaMontazowa { get; set; }
        public bool PetlaKJ { get; set; }
        public bool Stf { get; set; }
        public IList<ColumnLTM260> DanePLT { get; set; }
        public IList<BasicColumnM260> DaneSizerGBDio { get; set; }
        public IList<BasicColumnM260> DaneWeldingCell1 { get; set; }
        public IList<ColumnLTM260> DaneLT { get; set; }
        public IList<BasicColumnM260> DaneEnkapsulacja1 { get; set; }
        public IList<BasicColumnM260> DaneEnkapsulacja2 { get; set; }
        public IList<BasicColumnM260> DaneCelaRezystancyjna8 { get; set; }
        public IList<BasicColumnM260> DaneSpawaniePinu { get; set; }
        public IList<BasicColumnM260> DaneFG { get; set; }
        public IList<ColumnaVCM260> DaneOdkurzacz { get; set; }
        public IList<BasicColumnM260> DaneStacjaMontazowa { get; set; }
        public IList<ColumnCLM260> DanePetlaKJ { get; set; }

        public new string HtmlTable { get; set; }

        public CheckBoxLineWs4M260()
        {
            context = new StorageStationDbContext();
            FindData = new List<string>();
        }

        private Codes FindCode(string code)
        {
            var result = context.M260VacuumL4s
                .Where(x => x.NrShella == code)
                .Select(x => new Codes
                {
                    CodeBasic = x.NrShella,
                    CodeCatalyst = x.NrEtykiety
                }).ToArray();


            if (result.Length == 0)
            {
                result = context.M260VacuumL4s
                       .Where(x => x.NrShella.Contains(code))
                       .Select(x => new Codes
                       {
                           CodeBasic = x.NrShella,
                           CodeCatalyst = x.NrEtykiety
                       }).ToArray();

                if (result.Length == 0)
                {
                    result = context.M260VacuumL4s
                    .Where(x => x.NrEtykiety.Contains(code))
                    .Select(x => new Codes
                    {
                        CodeBasic = x.NrShella,
                        CodeCatalyst = x.NrEtykiety
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

            var codeFromPzzw = context.M260ControlLoopL4s
                .Where(x => x.NrPzzw == find)
                .Select(x => x.NrShella)
                .ToArray();

            return codeFromPzzw;
        }

        private IList<ColumnLTM260> GetDataFromPLT(string code)
        {
            return context.M260PreleakTesterL4s
                          .Where(x => x.NrShella == code)
                          .Select(x => new ColumnLTM260
                          {
                              Nr_Shell = x.NrShella,
                              Wynik_operacji = x.WynikTestu,
                              DateTime = x.DtOperacji,
                              Cisnienie = x.Cisnienie,
                              Cisnienie_jedn = x.CisnienieJedn,
                              Wyciek = x.Wyciek,
                              Wyciek_jedn = x.WyciekJedn
                          }).ToArray();
        }

        private IList<BasicColumnM260> GetDataFromSizerGBDio(string code)
        {
            return context.M260GbdIoCalibrationL4s
                          .Where(x => x.NrShella == code)
                          .Select(x => new BasicColumnM260
                          {
                              Nr_Shell = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              DateTime = x.DtOperacji
                          }).ToArray();
        }

        private IList<BasicColumnM260> GetDataFromWeldingCell1(string code)
        {
            return context.M260WeldingCell1L4s
                          .Where(x => x.NrShella == code)
                          .Select(x => new BasicColumnM260
                          {
                              Nr_Shell = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              DateTime = x.DtOperacji
                          }).ToArray();
        }

        private IList<ColumnLTM260> GetDataFromLT(string code)
        {
            var result = context.M260LeakTesterAndMarkingL4s
                         .Where(x => x.NrShella == code)
                          .Select(x => new ColumnLTM260
                          {
                              Nr_Shell = x.NrShella,
                              Wynik_operacji = x.WynikTestu,
                              Wyciek = x.Wyciek,
                              Wyciek_jedn = x.WyciekJedn,
                              Cisnienie = x.Cisnienie,
                              Cisnienie_jedn = x.CisnienieJedn,
                              DateTime = x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<BasicColumnM260> GetDataFromEnkapsulacja1(string code)
        {
            return context.M260EncapsulationBodyL4s
                     .Where(x => x.NrShella == code)
                      .Select(x => new BasicColumnM260
                      {
                          Nr_Shell = x.NrShella,
                          Wynik_operacji = x.WynikOperacji,
                          Frame_time = x.FrameTime,
                          DateTime = x.DtOperacji
                      }).ToArray();
        }

        private IList<BasicColumnM260> GetDataFromEnkapsulacja2(string code)
        {
            return context.M260EncapsulationPipeL4s
                    .Where(x => x.NrShella == code)
                      .Select(x => new BasicColumnM260
                      {
                          Nr_Shell = x.NrShella,
                          Wynik_operacji = x.WynikOperacji,
                          DateTime = x.DtOperacji
                      }).ToArray();
        }

        private IList<BasicColumnM260> GetDataFromCela8(string code)
        {
            return context.M260ResistanceWeldingL4s
                    .Where(x => x.NrShella == code)
                      .Select(x => new BasicColumnM260
                      {
                          Nr_Shell = x.NrShella,
                          Wynik_operacji = x.WynikOperacji,
                          DateTime = x.DtOperacji
                      }).ToArray();
        }

        private IList<BasicColumnM260> GetDataFromFinalGauge(string code)
        {
            return context.M260GeometryGaugeL4s
                    .Where(x => x.NrShella == code)
                    .Select(x => new BasicColumnM260
                    {
                        Nr_Shell = x.NrShella,
                        Wynik_operacji = x.WynikOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();
        }

        private IList<BasicColumnM260> GetDataFromSpawaniePinu(string code)
        {
            return context.M260PressStationL4s
                    .Where(x => x.NrShella == code)
                    .Select(x => new BasicColumnM260
                    {
                        Nr_Shell = x.NrShella,
                        Wynik_operacji = x.WynikOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();
        }

        private IList<ColumnaVCM260> GetDataFromVaccumCleaner(string code)
        {
            return context.M260VacuumL4s
                    .Where(x => x.NrShella == code)
                    .Select(x => new ColumnaVCM260
                    {
                        Nr_Shell = x.NrShella,
                        NrEtykiety = x.NrEtykiety,
                        Wynik_operacji = x.WynikOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();
        }

        private IList<ColumnCLM260> GetDataFromControlLoop(string code)
        {
           return context.M260ControlLoopL4s
                     .Where(x => x.NrShella == code)
                     .Select(x => new ColumnCLM260
                     {
                         Nr_Shell = x.NrShella,
                         NrEtykiety = x.NrEtykiety,
                         PZZW = x.NrPzzw,
                         Wynik_operacji = x.WynikOperacji,
                         Uwagi = x.Quality,
                         OperatorID = x.NrOperatora,
                         DateTime = x.DtOperacji
                     }).ToArray();
        }

        private IList<ColumnLTM260> GetDataFromPLTByDate(DateTime from, DateTime to)
        {
            var result = context.M260PreleakTesterL4s
                          .Where(x => (x.DtOperacji >= from && x.DtOperacji < to))
                          .Select(x => new ColumnLTM260
                          {
                              Nr_Shell = x.NrShella,
                              Wynik_operacji = x.WynikTestu,
                              Cisnienie = x.Cisnienie,
                              Cisnienie_jedn = x.CisnienieJedn,
                              Wyciek = x.Wyciek,
                              Wyciek_jedn = x.WyciekJedn,
                              DateTime = x.DtOperacji
                          })
                          .ToArray();

            return result;
        }

        private IList<BasicColumnM260> GetDataFromSizerByDate(DateTime from, DateTime to)
        {
            var result = context.M260GbdIoCalibrationL4s
                          .Where(x => (x.DtOperacji >= from && x.DtOperacji < to))
                          .Select(x => new BasicColumnM260
                          {
                              Nr_Shell = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              DateTime = x.DtOperacji
                          })
                          .ToArray();

            return result;
        }

        private IList<BasicColumnM260> GetDataFromWeldingCell1ByDate(DateTime from, DateTime to)
        {
            var result = context.M260WeldingCell1L4s
                          .Where(x => (x.DtOperacji >= from && x.DtOperacji < to))
                          .Select(x => new BasicColumnM260
                          {
                              Nr_Shell = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              DateTime = x.DtOperacji
                          })
                          .ToArray();

            return result;
        }

        private IList<ColumnLTM260> GetDataFromLTByDate(DateTime from, DateTime to)
        {
            var result = context.M260LeakTesterAndMarkingL4s
                          .Where(x => (x.DtOperacji >= from && x.DtOperacji < to))
                          .Select(x => new ColumnLTM260
                          {
                              Nr_Shell = x.NrShella,
                              Wynik_operacji = x.WynikTestu,
                              Wyciek = x.Wyciek,
                              Wyciek_jedn = x.WyciekJedn,
                              Cisnienie = x.Cisnienie,
                              Cisnienie_jedn = x.CisnienieJedn,
                              DateTime = x.DtOperacji
                          })
                     .ToArray();

            return result;
        }

        private IList<BasicColumnM260> GetDataFromPress1ByDate(DateTime from, DateTime to)
        {
            var result = context.M260EncapsulationBodyL4s
                          .Where(x => (x.DtOperacji >= from && x.DtOperacji < to))
                     .Select(x => new BasicColumnM260
                     {
                         Nr_Shell = x.NrShella,
                         Wynik_operacji = x.WynikOperacji,
                         DateTime = x.DtOperacji
                     })
                     .ToArray();

            return result;
        }

        private IList<BasicColumnM260> GetDataFromPress2ByDate(DateTime from, DateTime to)
        {
            var result = context.M260EncapsulationPipeL4s
                          .Where(x => (x.DtOperacji >= from && x.DtOperacji < to))
                     .Select(x => new BasicColumnM260
                     {
                         Nr_Shell = x.NrShella,
                         Wynik_operacji = x.WynikOperacji,
                         DateTime = x.DtOperacji
                     })
                     .ToArray();

            return result;
        }

        private IList<BasicColumnM260> GetDataFromResistanceCellByDate(DateTime from, DateTime to)
        {
            var result = context.M260ResistanceWeldingL4s
                          .Where(x => (x.DtOperacji >= from && x.DtOperacji < to))
                      .Select(x => new BasicColumnM260
                      {
                          Nr_Shell = x.NrShella,
                          Wynik_operacji = x.WynikOperacji,
                          DateTime = x.DtOperacji
                      })
                     .ToArray();

            return result;
        }

        private IList<BasicColumnM260> GetDataFromPinWeldingByDate(DateTime from, DateTime to)
        {
            var result = context.VM260PressStationL4Alls
                          .Where(x => (x.DtOperacji >= from && x.DtOperacji < to))
                      .Select(x => new BasicColumnM260
                      {
                          Nr_Shell = x.NrShella,
                          Wynik_operacji = x.WynikOperacji,
                          DateTime = x.DtOperacji
                      })
                     .ToArray();

            return result;
        }

        private IList<BasicColumnM260> GetDataFromFinalGaugeByDate(DateTime from, DateTime to)
        {
            var result = context.M260GeometryGaugeL4s
                    .Where(x => (x.DtOperacji >= from && x.DtOperacji < to))
                    .Select(x => new BasicColumnM260
                    {
                        Nr_Shell = x.NrShella,
                        Wynik_operacji = x.WynikOperacji,
                        DateTime = x.DtOperacji
                    })
                      .ToArray();

            return result;
        }

        private IList<ColumnaVCM260> GetDataFromVaccumCleanerByDate(DateTime from, DateTime to)
        {
            var result = context.M260VacuumL4s
                     .Where(x => (x.DtOperacji >= from && x.DtOperacji < to))
                    .Select(x => new ColumnaVCM260
                    {
                        Nr_Shell = x.NrShella,
                        NrEtykiety = x.NrEtykiety,
                        Wynik_operacji = x.WynikOperacji,
                        DateTime = x.DtOperacji
                    })
                      .ToArray();

            return result;
        }

        private IList<ColumnCLM260> GetDataFromControlLoopByDate(DateTime from, DateTime to)
        {
            var result = context.M260ControlLoopL4s
                     .Where(x => (x.DtOperacji >= from && x.DtOperacji < to))
                    .Select(x => new ColumnCLM260
                    {
                        Nr_Shell = x.NrShella,
                        NrEtykiety = x.NrEtykiety,
                        PZZW = x.NrPzzw,
                        Wynik_operacji = x.WynikOperacji,
                        Uwagi = x.Quality,
                        OperatorID = x.NrOperatora,
                        DateTime = x.DtOperacji
                    })
                    .ToArray();

            return result;
        }

        public void GetDataCode(bool download = false)
        {
            DanePLT = new List<ColumnLTM260>();
            DaneSizerGBDio = new List<BasicColumnM260>();
            DaneWeldingCell1 = new List<BasicColumnM260>();
            DaneLT = new List<ColumnLTM260>();
            DaneEnkapsulacja1 = new List<BasicColumnM260>();
            DaneEnkapsulacja2 = new List<BasicColumnM260>();
            DaneCelaRezystancyjna8 = new List<BasicColumnM260>();
            DaneSpawaniePinu = new List<BasicColumnM260>();
            DaneFG = new List<BasicColumnM260>();
            DaneOdkurzacz = new List<ColumnaVCM260>();
            DanePetlaKJ = new List<ColumnCLM260>();

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

                if (PLT)
                {
                    var result = GetDataFromPLTByDate(from, to);

                    foreach (var r in result)
                    {
                        DanePLT.Add(r);
                    }
                }

                if (SizerGBDio)
                {
                    var result = GetDataFromSizerByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneSizerGBDio.Add(r);
                    }
                }

                if (WeldingCell1)
                {
                    var result = GetDataFromWeldingCell1ByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneWeldingCell1.Add(r);
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

                if (Enkapsulacja1)
                {
                    var result = GetDataFromPress1ByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneEnkapsulacja1.Add(r);
                    }
                }

                if (Enkapsulacja2)
                {
                    var result = GetDataFromPress2ByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneEnkapsulacja2.Add(r);
                    }
                }

                if (CelaRezystancyjna8)
                {
                    var result = GetDataFromResistanceCellByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneCelaRezystancyjna8.Add(r);
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
                        HtmlTable += stf.HtmlTable;
                }

                if (PLT && Codes.CodeBasic != Brak)
                {
                    var result = GetDataFromPLT(Codes.CodeBasic);

                    foreach (var r in result)
                    {
                        DanePLT.Add(r);
                    }
                }

                if (SizerGBDio && Codes.CodeBasic != Brak)
                {
                    var result = GetDataFromSizerGBDio(Codes.CodeBasic);

                    foreach (var r in result)
                    {
                        DaneSizerGBDio.Add(r);
                    }
                }

                if (WeldingCell1 && Codes.CodeBasic != Brak)
                {
                    var result = GetDataFromWeldingCell1(Codes.CodeBasic);

                    foreach (var r in result)
                    {
                        DaneWeldingCell1.Add(r);
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

                if (Enkapsulacja1 && Codes.CodeBasic != Brak)
                {
                    var result = GetDataFromEnkapsulacja1(Codes.CodeBasic);

                    foreach (var r in result)
                    {
                        DaneEnkapsulacja1.Add(r);
                    }
                }

                if (Enkapsulacja2 && Codes.CodeBasic != Brak)
                {
                    var result = GetDataFromEnkapsulacja1(Codes.CodeBasic);

                    foreach (var r in result)
                    {
                        DaneEnkapsulacja2.Add(r);
                    }
                }

                if (CelaRezystancyjna8 && Codes.CodeBasic != Brak)
                {
                    var result = GetDataFromCela8(Codes.CodeBasic);

                    foreach (var r in result)
                    {
                        DaneCelaRezystancyjna8.Add(r);
                    }
                }

                if (SpawaniePinu && Codes.CodeBasic != Brak)
                {
                    var result = GetDataFromSpawaniePinu(Codes.CodeBasic);

                    foreach (var r in result)
                    {
                        DaneSpawaniePinu.Add(r);
                    }
                }

                if (FG && Codes.CodeBasic != Brak)
                {
                    var result = GetDataFromFinalGauge(Codes.CodeBasic);

                    foreach (var r in result)
                    {
                        DaneFG.Add(r);
                    }
                }

                if (Odkurzacz && Codes.CodeBasic != Brak)
                {
                    var result = GetDataFromVaccumCleaner(Codes.CodeBasic);

                    foreach (var r in result)
                    {
                        DaneOdkurzacz.Add(r);
                    }
                }

                if (PetlaKJ && Codes.CodeBasic != Brak)
                {
                    var result = GetDataFromControlLoop(Codes.CodeBasic);

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

            if (DanePLT?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DanePLT.ToArray()));
                FileName.Add("PreLeak tester");
            }

            if (DaneSizerGBDio?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneSizerGBDio.ToArray()));
                FileName.Add("Sizer GBD IO");
            }

            if (DaneWeldingCell1?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneWeldingCell1.ToArray()));
                FileName.Add("Cela spawalnicza nr 1");
            }

            if (DaneLT?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneLT.ToArray()));
                FileName.Add("Leat tester");
            }

            if (DaneEnkapsulacja1?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneEnkapsulacja1.ToArray()));
                FileName.Add("Enkapsulacja nr 1");
            }

            if (DaneEnkapsulacja2?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneEnkapsulacja2.ToArray()));
                FileName.Add("Enkapsulacja nr 2");
            }

            if (DaneCelaRezystancyjna8?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneCelaRezystancyjna8.ToArray()));
                FileName.Add("Cela rezystancyjna");
            }

            if (DaneSpawaniePinu?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneSpawaniePinu.ToArray()));
                FileName.Add("Spawanie pinu");
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

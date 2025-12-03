using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WebMonitoring.DataBase;
using WebMonitoring.Models;

namespace WebMonitoring.Search
{
    public class CheckBoxLineWs3HR12CC : BaseSearchClass
    {
        private StorageStationDbContext context { get; set; }
        private CodesHr12cc Codes { get; set; }

        public bool All { get; set; }
        public bool CelaSpawalniczaBasicWlot { get; set; }
        public bool CelaSpawalniczaMidclamshell { get; set; }
        public bool SizerInlet { get; set; }
        public bool CelaSpawalniczaBasicWlotMidclamshell { get; set; }
        public bool CelaSpawalniczaBasicWylot { get; set; }
        public bool SizerOutlet { get; set; }
        public bool CelaSpawalniczaBasicWlotWylotMidclamshell { get; set; }
        public bool PLT { get; set; }
        public bool Enkapsulacja { get; set; }
        public bool Wkretak { get; set; }
        public bool Homologacja { get; set; }
        public bool FLT { get; set; }
        public bool Deflector { get; set; }
        public bool DeflectorGauge { get; set; }
        public bool FG { get; set; }
        public bool Odkurzacz { get; set; }
        public bool PetlaKJ { get; set; }
        public bool Stf { get; set; }
        public new string HtmlTableInlet { get; set; }
        public new string HtmlTableOutlet { get; set; }
        public List<BasicColumnHr12cc> DaneCelaSprawalniczaWlot { get; set; }
        public List<BasicColumnHr12cc> DaneCelaSprawalniczaMidclamshell { get; set; }
        public List<BasicColumnHr12cc> DaneSizerInlet { get; set; }
        public List<BasicColumnHr12cc> DaneCelaSprawalniczaWlotMidclamshell { get; set; }
        public List<BasicColumnHr12cc> DaneCelaSprawalniczaWylot { get; set; }
        public List<BasicColumnHr12cc> DaneSizerOutlet { get; set; }
        public List<BasicColumnHr12cc> DaneCelaSprawalniczaWlotWylotMidclamshell { get; set; }
        public List<ColumnLT_Hr12cc> DanePLT { get; set; }
        public List<BasicColumnHr12cc> DaneEnkapsulacja { get; set; }
        public List<ColumnTorqueHr12cc> DaneWkretak { get; set; }
        public List<BasicColumnHr12cc> DaneHomologacja { get; set; }
        public List<ColumnTorqueHr12cc> DaneDeflector { get; set; }
        public List<BasicColumnHr12cc> DaneDeflectorGauge { get; set; }
        public List<ColumnFLT_Hr12cc> DaneFLT { get; set; }
        public List<BasicColumnHr12cc> DaneFG { get; set; }
        public List<BasicColumnHr12cc> DaneOdkurzacz { get; set; }
        public List<ColumnCL_Hr12cc> DanePetlaKJ { get; set; }
        public CheckBoxLineWs3HR12CC()
        {
            context = new StorageStationDbContext();
            FindData = new List<string>();
        }

        private CodesHr12cc FindCode(string code)
        {
            var result = context.Hr12ccPreleakTesterL7s
                .Where(x => x.NrGrawerka == code)
                .Select(x => new CodesHr12cc
                {
                    CodeBasicOutlet = x.NrShella,
                    CodeCatalyst = x.NrGrawerka
                }).ToArray();


            if (result?.Length == 0)
            {
                result = context.Hr12ccPreleakTesterL7s
                       .Where(x => x.NrGrawerka.Contains(code))
                       .Select(x => new CodesHr12cc
                       {
                           CodeBasicOutlet = x.NrShella,
                           CodeCatalyst = x.NrGrawerka
                       }).ToArray();

                if (result?.Length == 0)
                {
                    result = context.Hr12ccPreleakTesterL7s
                    .Where(x => x.NrShella.Contains(code))
                    .Select(x => new CodesHr12cc
                    {
                        CodeBasicOutlet = x.NrShella,
                        CodeCatalyst = x.NrGrawerka
                    }).ToArray();
                }
            }

            CodesHr12cc resultCode = new CodesHr12cc();

            if (result?.Length > 0)
            {
                var resultBasicInlet = context.Hr12ccWeldingCellInletOutletBasicMidclamshellL7s
                    .Where(x => x.NrShellaOutlet == result[0].CodeBasicOutlet)
                    .Take(1)
                    .Select(x => x.NrShellaInlet);

                resultCode.CodeBasicInlet = resultBasicInlet.Single();
                resultCode.CodeBasicOutlet = result[0]?.CodeBasicOutlet;
                resultCode.CodeCatalyst = result[0]?.CodeCatalyst;
            }
            else
            {
                resultCode.CodeBasicOutlet = Brak;
                resultCode.CodeBasicInlet = Brak;
                resultCode.CodeCatalyst = Brak;
            }

            return resultCode;
        }

        private IList<string> FindCodeByPzzw(string find)
        {
            Codes resultCode = new Codes();

            var codeFromPzzw = context.Hr12ccControlLoopL7s
                .Where(x => x.NrPzzw == find)
                .Select(x => x.NrKatalizatora)
                .ToArray();

            return codeFromPzzw;
        }

        private IList<BasicColumnHr12cc> GetDataFromSizerInlet(string code)
        {
            var result = context.Hr12ccSizerGbdInletL7s
                          .Where(x => x.NrShella == code)
                          .Select(x => new BasicColumnHr12cc
                          {
                              Nr_Shell_Inlet = x.NrShella,
                              Nr_Midclamshell = x.NrClamshell,
                              Wynik_operacji = x.WynikOperacji,
                              Nr_linii = x.NrLinii,
                              DateTime = x.DtOperacji
                          }).ToArray();

            return result;
        }



        private IList<BasicColumnHr12cc> GetDataFromSizerOutlet(string code)
        {
            var result = context.Hr12ccSizerGbdOutletL7s
                          .Where(x => x.NrShella == code)
                          .Select(x => new BasicColumnHr12cc
                          {
                              Nr_Shell_Outlet = x.NrShella,
                              Nr_Midclamshell = x.NrClamshell,
                              Wynik_operacji = x.WynikOperacji,
                              Nr_linii = x.NrLinii,
                              DateTime = x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<BasicColumnHr12cc> GetDataFromWeldingCellBasicInlet(string code)
        {
            var result = context.Hr12ccWeldingCellInletBasicClamshellOp3L7s
                          .Where(x => x.NrShella == code)
                          .Select(x => new BasicColumnHr12cc
                          {
                              Nr_Shell_Inlet = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              Nr_linii = x.NrLinii,
                              DateTime = x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<BasicColumnHr12cc> GetDataFromWeldingCellMidclamshell(string code)
        {
            var result = context.Hr12ccWeldingCellMidclamshellOp7L7s
                          .Where(x => x.NrMidclamshell == code)
                          .Select(x => new BasicColumnHr12cc
                          {
                              Nr_Midclamshell = x.NrMidclamshell,
                              Wynik_operacji = x.WynikOperacji,
                              Nr_linii = x.NrLinii,
                              DateTime = x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<BasicColumnHr12cc> GetDataFromWeldingCellBasicInletMidclamshell(string code)
        {
            var result = context.Hr12ccWeldingCellIntletBasicMidclamshellOp8L7s
                          .Where(x => x.NrShella == code)
                          .Select(x => new BasicColumnHr12cc
                          {
                              Nr_Shell_Inlet = x.NrShella,
                              Nr_Midclamshell = x.NrMidclamshell,
                              Wynik_operacji = x.WynikOperacji,
                              Nr_linii = x.NrLinii,
                              DateTime = x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<BasicColumnHr12cc> GetDataFromWeldingCellBasicOutlet(string code)
        {
            var result = context.Hr12ccWeldingCellOutletBasicClamshellOp6L7s
                          .Where(x => x.NrShella == code)
                          .Select(x => new BasicColumnHr12cc
                          {
                              Nr_Shell_Outlet = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              Nr_linii = x.NrLinii,
                              DateTime = x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<BasicColumnHr12cc> GetDataFromWeldingCellBasicInletOutletMidclamshell(string code)
        {
            var result = context.VHr12ccWeldingCellInletOutletBasicMidclamshellL7Alls
                          .Where(x => x.NrShellaOutlet == code || x.NrShellaInlet == code)
                          .Select(x => new BasicColumnHr12cc
                          {
                              Nr_Shell_Outlet = x.NrShellaOutlet,
                              Nr_Shell_Inlet = x.NrShellaInlet,
                              Nr_Midclamshell = x.NrMidclamshell,
                              Wynik_operacji = x.WynikOperacji,
                              Nr_linii = x.NrLinii,
                              DateTime = x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<ColumnLT_Hr12cc> GetDataFromPLT(string code)
        {
            var result = context.Hr12ccPreleakTesterL7s
                         .Where(x => x.NrGrawerka == code)
                          .Select(x => new ColumnLT_Hr12cc
                          {
                              Nr_Shell_Outlet = x.NrShella,
                              Nr_Grawerka = x.NrGrawerka,
                              Wynik_operacji = x.WynikTestu,
                              Wyciek = x.Wyciek,
                              Wyciek_jedn = x.WyciekJedn,
                              Cisnienie = x.Cisnienie,
                              Cisnienie_jedn = x.CisnienieJedn,
                              Nr_linii = x.NrLinii,
                              DateTime = x.DtOperacji
                          }).ToArray();

            //var result = get?.ToList();

            if (result.Length <= 0)
            {
                result = context.Hr12ccPreleakTesterL7s
                           .Where(x => x.NrShella == code)
                            .Select(x => new ColumnLT_Hr12cc
                            {
                                Nr_Shell_Outlet = x.NrShella,
                                Nr_Grawerka = x.NrGrawerka,
                                Wynik_operacji = x.WynikTestu,
                                Wyciek = x.Wyciek,
                                Wyciek_jedn = x.WyciekJedn,
                                Cisnienie = x.Cisnienie,
                                Cisnienie_jedn = x.CisnienieJedn,
                                Nr_linii = x.NrLinii,
                                DateTime = x.DtOperacji
                            }).ToArray();
            }

            return result;
        }

        private IList<BasicColumnHr12cc> GetDataFromPress(string code)
        {
            var result = context.Hr12ccOutletPressL7s
                    .Where(x => x.NrGrawerka == code)
                     .Select(x => new BasicColumnHr12cc
                     {
                         Nr_Shell_Outlet = x.NrShella,
                         Nr_Grawerka = x.NrGrawerka,
                         Wynik_operacji = x.WynikOperacji,
                         Nr_linii = x.NrLinii,
                         DateTime = x.DtOperacji
                     }).ToArray();

            return result;
        }

        private IList<ColumnTorqueHr12cc> GetDataFromTorque(string code)
        {
            var result = context.Hr12ccTorqueScrewdriverL7s
                    .Where(x => x.NrGrawerka == code)
                      .Select(x => new ColumnTorqueHr12cc
                      {
                          Nr_Grawerka = x.NrGrawerka,
                          Wynik_operacji = x.WynikOperacji,
                          Kat_Nr1 = x.AngleNakretka1,
                          Moment_Nr1 = x.TorqueNakretka1,
                          Kat_Nr2 = x.AngleNakretka2,
                          Moment_Nr2 = x.TorqueNakretka2,
                          Nr_linii = x.NrLinii,
                          DateTime = x.DtOperacji
                      }).ToArray();

            return result;
        }

        private IList<BasicColumnHr12cc> GetDataFromHomologation(string code)
        {
            var result = context.Hr12ccHomologationL7s
                      .Where(x => x.NrGrawerka == code)
                      .Select(x => new BasicColumnHr12cc
                      {
                          Nr_Grawerka = x.NrGrawerka,
                          Wynik_operacji = x.WynikOperacji,
                          Nr_linii = x.NrLinii,
                          DateTime = x.DtOperacji
                      }).ToArray();

            return result;
        }

        private IList<ColumnFLT_Hr12cc> GetDataFromFLT(string code)
        {
            var result = context.Hr12ccFinalleakTesterL7s
                    .Where(x => x.NrGrawerka == code)
                    .Select(x => new ColumnFLT_Hr12cc
                    {
                        Nr_Grawerka = x.NrGrawerka,
                        Wynik_operacji = x.WynikTestu,
                        Wyciek = x.Wyciek,
                        Wyciek_jedn = x.WyciekJedn,
                        Cisnienie = x.Cisnienie,
                        Cisnienie_jedn = x.CisnienieJedn,
                        Wartosc_Przeplywu_Rurki_1 = x.WartoscPrzeplywuRurki1,
                        Wartosc_Przeplywu_Rurki_2 = x.WartoscPrzeplywuRurki2,
                        Nr_linii = x.NrLinii,
                        DateTime = x.DtOperacji
                    }).ToArray();

            return result;
        }

        private IList<ColumnTorqueHr12cc> GetDataFromDeflector(string code)
        {
            var result = context.Hr12ccDeflectorL7s
                      .Where(x => x.NrGrawerka == code)
                      .Select(x => new ColumnTorqueHr12cc
                      {
                          Nr_Grawerka = x.NrGrawerka,
                          Wynik_operacji = x.WynikOperacji,
                          Moment_Nr1 = x.TorqueNakretka1.ToString(),
                          Moment_Nr2 = x.TorqueNakretka2.ToString(),
                          Moment_Nr3 = x.TorqueNakretka3.ToString(),
                          Kat_Nr1 = x.AngleNakretka1.ToString(),
                          Kat_Nr2 = x.AngleNakretka2.ToString(),
                          Kat_Nr3 = x.AngleNakretka3.ToString(),
                          Nr_linii = x.NrLinii,
                          DateTime = x.DtOperacji
                      }).ToArray();

            return result;
        }

        private IList<BasicColumnHr12cc> GetDataFromDeflectorGauge(string code)
        {
            var result = context.Hr12ccDeflectorGaugeL7s
                    .Where(x => x.NrGrawerka == code)
                    .Select(x => new BasicColumnHr12cc
                    {
                        Nr_Grawerka = x.NrGrawerka,
                        Wynik_operacji = x.WynikOperacji,
                        Nr_linii = x.NrLinii,
                        DateTime = x.DtOperacji
                    }).ToArray();

            return result;
        }

        private IList<BasicColumnHr12cc> GetDataFromFinalGauge(string code)
        {
            var result = context.Hr12ccCheckFixtureL7s
                    .Where(x => x.NrGrawerka == code)
                    .Select(x => new BasicColumnHr12cc
                    {
                        Nr_Grawerka = x.NrGrawerka,
                        Wynik_operacji = x.WynikOperacji,
                        Nr_linii = x.NrLinii,
                        DateTime = x.DtOperacji
                    }).ToArray();

            return result;
        }

        private IList<BasicColumnHr12cc> GetDataFromVaccumCleaner(string code)
        {
            var result = context.Hr12ccVacuumCleanerL7s
                    .Where(x => x.NrGrawerka == code)
                    .Select(x => new BasicColumnHr12cc
                    {
                        Nr_Grawerka = x.NrGrawerka,
                        Wynik_operacji = x.WynikOperacji,
                        Nr_linii = x.NrLinii,
                        DateTime = x.DtOperacji
                    }).ToArray();

            return result;
        }

        private IList<ColumnCL_Hr12cc> GetDataFromControlLoop(string code)
        {
           var result = context.Hr12ccControlLoopL7s
                    .Where(x => x.NrKatalizatora == code)
                    .Select(x => new ColumnCL_Hr12cc
                    {
                        Nr_Grawerka = x.NrKatalizatora,
                        PZZW = x.NrPzzw,
                        Wynik_operacji = x.WynikOperacji,
                        Uwagi = x.Quality,
                        Nr_linii = x.NrLinii,
                        OperatorID = x.NrOperatora,
                        DateTime = x.DtOperacji
                    }).ToArray();

            return result;
        }

        private IList<BasicColumnHr12cc> GetDataFromSiezerInletByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Hr12ccSizerGbdInletL7s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new BasicColumnHr12cc
                          {
                              Nr_Shell_Inlet = x.NrShella,
                              Nr_Midclamshell = x.NrClamshell,
                              Wynik_operacji = x.WynikOperacji,
                              Nr_linii = x.NrLinii,
                              DateTime = x.DtOperacji
                          })
                          .ToArray();

            return result;
        }

        private IList<BasicColumnHr12cc> GetDataFromSiezerOutletByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Hr12ccSizerGbdOutletL7s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new BasicColumnHr12cc
                          {
                              Nr_Shell_Outlet = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              Nr_linii = x.NrLinii,
                              DateTime = x.DtOperacji
                          })
                          .ToArray();

            return result;
        }

        private IList<BasicColumnHr12cc> GetDataFromWeldingCellBasicInletByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Hr12ccWeldingCellInletBasicClamshellOp3L7s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new BasicColumnHr12cc
                          {
                              Nr_Shell_Inlet = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              Nr_linii = x.NrLinii,
                              DateTime = x.DtOperacji
                          })
                          .ToArray();

            return result;
        }

        private IList<BasicColumnHr12cc> GetDataFromWeldingCellMidclamshellByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Hr12ccWeldingCellMidclamshellOp7L7s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new BasicColumnHr12cc
                          {
                              Nr_Midclamshell = x.NrMidclamshell,
                              Wynik_operacji = x.WynikOperacji,
                              Nr_linii = x.NrLinii,
                              DateTime = x.DtOperacji
                          })
                          .ToArray();

            return result;
        }

        private IList<BasicColumnHr12cc> GetDataFromWeldingCellBasicInletMidclamshellByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Hr12ccWeldingCellIntletBasicMidclamshellOp8L7s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new BasicColumnHr12cc
                          {
                              Nr_Shell_Inlet =x.NrShella,
                              Nr_Midclamshell = x.NrMidclamshell,
                              Wynik_operacji = x.WynikOperacji,
                              Nr_linii = x.NrLinii,
                              DateTime = x.DtOperacji
                          })
                          .ToArray();

            return result;
        }

        private IList<BasicColumnHr12cc> GetDataFromWeldingCellBasicOutletByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Hr12ccWeldingCellOutletBasicClamshellOp6L7s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new BasicColumnHr12cc
                          {
                              Nr_Shell_Outlet = x.NrShella,
                              Wynik_operacji = x.WynikOperacji,
                              Nr_linii = x.NrLinii,
                              DateTime = x.DtOperacji
                          })
                          .ToArray();

            return result;
        }

        private IList<BasicColumnHr12cc> GetDataFromWeldingCellBasicInletOutletMidclamshellByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.VHr12ccWeldingCellInletOutletBasicMidclamshellL7Alls
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new BasicColumnHr12cc
                          {
                              Nr_Shell_Inlet = x.NrShellaInlet,
                              Nr_Shell_Outlet = x.NrShellaOutlet,
                              Nr_Midclamshell =x.NrMidclamshell,
                              Wynik_operacji = x.WynikOperacji,
                              Nr_linii = x.NrLinii,
                              DateTime = x.DtOperacji
                          })
                          .ToArray();

            return result;
        }

        private IList<ColumnLT_Hr12cc> GetDataFromPLTByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Hr12ccPreleakTesterL7s
                        .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new ColumnLT_Hr12cc
                          {
                              Nr_Shell_Outlet = x.NrShella,
                              Nr_Grawerka = x.NrGrawerka,
                              Wynik_operacji = x.WynikTestu,
                              Wyciek = x.Wyciek,
                              Wyciek_jedn = x.WyciekJedn,
                              Cisnienie = x.Cisnienie,
                              Cisnienie_jedn = x.CisnienieJedn,
                              Nr_linii = x.NrLinii,
                              DateTime = x.DtOperacji
                          })
                     .ToArray();          

            return result;
        }

        private IList<BasicColumnHr12cc> GetDataFromPressByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Hr12ccOutletPressL7s
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                     .Select(x => new BasicColumnHr12cc
                     {
                         Nr_Shell_Outlet = x.NrShella,
                         Nr_Grawerka = x.NrGrawerka,
                         Wynik_operacji = x.WynikOperacji,
                         Nr_linii = x.NrLinii,
                         DateTime = x.DtOperacji
                     })
                     .ToArray();

            return result;
        }

        private IList<ColumnTorqueHr12cc> GetDataFromTorqueByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Hr12ccTorqueScrewdriverL7s
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                      .Select(x => new ColumnTorqueHr12cc
                      {
                          Nr_Grawerka = x.NrGrawerka,
                          Wynik_operacji = x.WynikOperacji,
                          Kat_Nr1 = x.AngleNakretka1,
                          Moment_Nr1 = x.TorqueNakretka1,
                          Kat_Nr2 = x.AngleNakretka2,
                          Moment_Nr2 = x.TorqueNakretka2,
                          Nr_linii = x.NrLinii,
                          DateTime = x.DtOperacji
                      })
                     .ToArray();

            return result;
        }

        private IList<BasicColumnHr12cc> GetDataFromHomologationByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Hr12ccHomologationL7s
                      .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                      .Select(x => new BasicColumnHr12cc
                      {
                          Nr_Grawerka = x.NrGrawerka,
                          Wynik_operacji = x.WynikOperacji,
                          Nr_linii = x.NrLinii,
                          DateTime = x.DtOperacji
                      })
                      .ToArray();

            return result;
        }

        private IList<ColumnFLT_Hr12cc> GetDataFromFLTByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Hr12ccFinalleakTesterL7s
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .Select(x => new ColumnFLT_Hr12cc
                    {
                        Nr_Grawerka = x.NrGrawerka,
                        Wynik_operacji = x.WynikTestu,
                        Wyciek = x.Wyciek,
                        Wyciek_jedn = x.WyciekJedn,
                        Cisnienie = x.Cisnienie,
                        Cisnienie_jedn = x.CisnienieJedn,
                        Wartosc_Przeplywu_Rurki_1 = x.WartoscPrzeplywuRurki1,
                        Wartosc_Przeplywu_Rurki_2 = x.WartoscPrzeplywuRurki2,
                        Nr_linii = x.NrLinii,
                        DateTime = x.DtOperacji
                    })
                     .ToArray();

            return result;
        }

        private IList<ColumnTorqueHr12cc> GetDataFromDeflectorByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Hr12ccDeflectorL7s
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                      .Select(x => new ColumnTorqueHr12cc
                      {
                          Nr_Grawerka = x.NrGrawerka,
                          Wynik_operacji = x.WynikOperacji,
                          Kat_Nr1 = x.AngleNakretka1.ToString(),
                          Moment_Nr1 = x.TorqueNakretka1.ToString(),
                          Kat_Nr2 = x.AngleNakretka2.ToString(),
                          Moment_Nr2 = x.TorqueNakretka2.ToString(),
                          Kat_Nr3 = x.AngleNakretka3.ToString(),
                          Moment_Nr3 = x.TorqueNakretka3.ToString(),
                          Nr_linii = x.NrLinii,
                          DateTime = x.DtOperacji
                      })
                     .ToArray();

            return result;
        }

        private IList<BasicColumnHr12cc> GetDataFromDeflectorGaugeByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Hr12ccDeflectorGaugeL7s
                    .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .Select(x => new BasicColumnHr12cc
                    {
                        Nr_Grawerka = x.NrGrawerka,
                        Wynik_operacji = x.WynikOperacji,
                        Nr_linii = x.NrLinii,
                        DateTime = x.DtOperacji
                    })
                      .ToArray();

            return result;
        }

        private IList<BasicColumnHr12cc> GetDataFromFinalGaugeByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Hr12ccCheckFixtureL7s
                    .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .Select(x => new BasicColumnHr12cc
                    {
                        Nr_Grawerka = x.NrGrawerka,
                        Wynik_operacji = x.WynikOperacji,
                        Nr_linii = x.NrLinii,
                        DateTime = x.DtOperacji
                    })
                      .ToArray();

            return result;
        }

        private IList<BasicColumnHr12cc> GetDataFromVaccumCleanerByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTime();
            var frameTimeTo = to.ConvertDateTimeToFrameTime();

            var result = context.Hr12ccVacuumCleanerL7s
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .Select(x => new BasicColumnHr12cc
                    {
                        Nr_Grawerka = x.NrGrawerka,
                        Wynik_operacji = x.WynikOperacji,
                        Nr_linii = x.NrLinii,
                        DateTime = x.DtOperacji
                    })
                      .ToArray();

            return result;
        }

        private IList<ColumnCL_Hr12cc> GetDataFromControlLoopByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTime();
            var frameTimeTo = to.ConvertDateTimeToFrameTime();

            var result = context.Hr12ccControlLoopL7s
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .Select(x => new ColumnCL_Hr12cc
                    {
                        Nr_Grawerka = x.NrKatalizatora,
                        PZZW = x.NrPzzw,
                        Wynik_operacji = x.WynikOperacji,
                        Uwagi = x.Quality,
                        Nr_linii = x.NrLinii,
                        OperatorID = x.NrOperatora,
                        DateTime = x.DtOperacji
                    })
                    .ToArray();

            return result;
        }

        public void GetDataCode(bool download = false)
        {
            DaneSizerInlet = new(); 
            DaneSizerOutlet = new();
            DaneCelaSprawalniczaWlot = new();
            DaneCelaSprawalniczaWylot = new();
            DaneCelaSprawalniczaMidclamshell = new();
            DaneCelaSprawalniczaWlotMidclamshell = new();
            DaneCelaSprawalniczaWlotWylotMidclamshell = new();
            DaneDeflectorGauge = new();
            DanePLT = new();
            DaneEnkapsulacja = new();
            DaneWkretak = new();
            DaneHomologacja = new();
            DaneFLT = new();
            DaneDeflector = new();
            DaneFG = new();
            DaneOdkurzacz = new();
            DanePetlaKJ = new();
            HtmlTableInlet = string.Empty;
            HtmlTableOutlet = string.Empty;

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

                if (CelaSpawalniczaBasicWlot)
                {
                    var result = GetDataFromWeldingCellBasicInletByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneCelaSprawalniczaWlot.Add(r);
                    }
                }

                if (SizerInlet)
                {
                    var result = GetDataFromSiezerInletByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneSizerInlet.Add(r);
                    }
                }

                if (SizerOutlet)
                {
                    var result = GetDataFromSiezerOutletByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneSizerOutlet.Add(r);
                    }
                }

                if (CelaSpawalniczaBasicWlot)
                {
                    var result = GetDataFromWeldingCellBasicInletByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneCelaSprawalniczaWlot.Add(r);
                    }
                }

                if (CelaSpawalniczaBasicWlotMidclamshell)
                {
                    var result = GetDataFromWeldingCellMidclamshellByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneCelaSprawalniczaMidclamshell.Add(r);
                    }
                }

                if (CelaSpawalniczaBasicWlotWylotMidclamshell)
                {
                    var result = GetDataFromWeldingCellBasicInletMidclamshellByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneCelaSprawalniczaWlotMidclamshell.Add(r);
                    }
                }

                if (CelaSpawalniczaBasicWylot)
                {
                    var result = GetDataFromWeldingCellBasicOutletByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneCelaSprawalniczaWylot.Add(r);
                    }
                }

                if (CelaSpawalniczaBasicWlotWylotMidclamshell)
                {
                    var result = GetDataFromWeldingCellBasicInletOutletMidclamshellByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneCelaSprawalniczaWlotWylotMidclamshell.Add(r);
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

                if (Deflector)
                {
                    var result = GetDataFromDeflectorByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneDeflector.Add(r);
                    }
                }

                if (DeflectorGauge)
                {
                    var result = GetDataFromDeflectorGaugeByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneDeflectorGauge.Add(r);
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

                if(Stf && Codes.CodeBasicOutlet != Brak)
                {
                    Stf_3_6 stf = new Stf_3_6();
                    stf.GetDataFromSql(Codes.CodeBasicOutlet);
                    if (!string.IsNullOrEmpty(stf.HtmlTable))
                        HtmlTableOutlet += stf.HtmlTable;
                }

                if (Stf && Codes.CodeBasicInlet != Brak)
                {
                    Stf_3_6 stf = new Stf_3_6();
                    stf.GetDataFromSql(Codes.CodeBasicInlet);
                    if (!string.IsNullOrEmpty(stf.HtmlTable))
                        HtmlTableInlet += stf.HtmlTable;
                }

                if (SizerInlet && Codes.CodeBasicInlet != Brak)
                {
                    var result = GetDataFromSizerInlet(Codes.CodeBasicInlet);

                    foreach (var r in result)
                    {
                        DaneSizerInlet.Add(r);
                    }
                }

                if (SizerOutlet && Codes.CodeBasicOutlet != Brak)
                {
                    var result = GetDataFromSizerOutlet(Codes.CodeBasicOutlet);

                    foreach (var r in result)
                    {
                        DaneSizerOutlet.Add(r);
                    }
                }

                if (CelaSpawalniczaBasicWlotMidclamshell && Codes.CodeBasicInlet != Brak)
                {
                    var result = GetDataFromWeldingCellBasicInletMidclamshell(Codes.CodeBasicInlet);

                    foreach (var r in result)
                    {
                        DaneCelaSprawalniczaWlotMidclamshell.Add(r);

                        Codes.CodeMidclamshell = r.Nr_Midclamshell;

                        if (CelaSpawalniczaMidclamshell && Codes.CodeMidclamshell != Brak)
                        {
                            var resultMid = GetDataFromWeldingCellMidclamshell(Codes.CodeMidclamshell);

                            foreach (var rM in resultMid)
                            {
                                DaneCelaSprawalniczaMidclamshell.Add(rM);
                            }
                        }
                    }
                }

                if (CelaSpawalniczaBasicWlot && Codes.CodeBasicInlet != Brak)
                {
                    var result = GetDataFromWeldingCellBasicInlet(Codes.CodeBasicInlet);

                    foreach (var r in result)
                    {
                        DaneCelaSprawalniczaWlot.Add(r);
                    }
                }

                if (CelaSpawalniczaBasicWylot && Codes.CodeBasicOutlet != Brak)
                {
                    var result = GetDataFromWeldingCellBasicOutlet(Codes.CodeBasicOutlet);

                    foreach (var r in result)
                    {
                        DaneCelaSprawalniczaWylot.Add(r);
                    }
                }

                if (CelaSpawalniczaBasicWlotWylotMidclamshell && Codes.CodeBasicOutlet != Brak)
                {
                    var result = GetDataFromWeldingCellBasicInletOutletMidclamshell(Codes.CodeBasicOutlet);

                    foreach (var r in result)
                    {
                        DaneCelaSprawalniczaWlotWylotMidclamshell.Add(r);
                    }
                }

                if (PLT && Codes.CodeBasicOutlet != Brak)
                {
                    var result = GetDataFromPLT(Codes.CodeBasicOutlet);

                    foreach (var r in result)
                    {
                        DanePLT.Add(r);
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

                if (Deflector && Codes.CodeCatalyst != Brak)
                {
                    var result = GetDataFromDeflector(Codes.CodeCatalyst);

                    foreach (var r in result)
                    {
                        DaneDeflector.Add(r);
                    }
                }

                if (DeflectorGauge && Codes.CodeCatalyst != Brak)
                {
                    var result = GetDataFromDeflectorGauge(Codes.CodeCatalyst);

                    foreach (var r in result)
                    {
                        DaneDeflectorGauge.Add(r);
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

            if (DaneSizerInlet?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneSizerInlet.ToArray()));
                FileName.Add("Sizer_GBD_wlot");
            }

            if (DaneSizerOutlet?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneSizerOutlet.ToArray()));
                FileName.Add("Sizer_GBD_wylot");
            }

            if (DaneCelaSprawalniczaWlot?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneCelaSprawalniczaWlot.ToArray()));
                FileName.Add("Cela_spawalnicza_wlot");
            }

            if (DaneCelaSprawalniczaMidclamshell?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneCelaSprawalniczaMidclamshell.ToArray()));
                FileName.Add("Cela_spawalnicza_midclamshell");
            }

            if (DaneCelaSprawalniczaWlotMidclamshell?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneCelaSprawalniczaWlotMidclamshell.ToArray()));
                FileName.Add("Cela_spawalnicza_wlot_midclamshell");
            }

            if (DaneCelaSprawalniczaWylot?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneCelaSprawalniczaWylot.ToArray()));
                FileName.Add("Cela_spawalnicza_wylot");
            }

            if (DaneCelaSprawalniczaWlotWylotMidclamshell?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneCelaSprawalniczaWlotWylotMidclamshell.ToArray()));
                FileName.Add("Cela_spawalnicza_wlot_wylot_midclamshell");
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
                FileName.Add("Wkrętak_rurek");
            }

            if (DaneHomologacja?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneHomologacja.ToArray()));
                FileName.Add("Homologacja");
            }

            if (DaneFLT?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneFLT.ToArray()));
                FileName.Add("Final_leaktester");
            }

            if (DaneDeflector?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneDeflector.ToArray()));
                FileName.Add("Deflector");
            }

            if (DaneDeflectorGauge?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneDeflectorGauge.ToArray()));
                FileName.Add("Deflector_gauge");
            }

            if (DaneFG?.Count > 0)
            {
                Table.Add(dataTable.WriteTextToFile(DaneFG.ToArray()));
                FileName.Add("Sprawdzian_geometrii");
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

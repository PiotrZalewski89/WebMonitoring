﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WebMonitoring.DataBase;
using WebMonitoring.Models;

namespace WebMonitoring.Search
{
    public class CheckBoxLineWs7 : BaseSearchClass
    {
        private CnhDbContext context { get; set; }
        private CodesWs7 Codes { get; set; }

        public bool All { get; set; }
        public bool WS7_TT_PRELEAK_TESTER { get; set; }
        public bool WS7_TT_WELDING_CELL_2_OP290_STN1 { get; set; }
        public bool WS7_TT_WELDING_CELL_2_OP300_STN1 { get; set; }
        public bool WS7_TT_WELDING_CELL_2_OP310_STN2 { get; set; }
        public bool WS7_TT_WELDING_CELL_3_OP320_STN1 { get; set; }
        public bool WS7_TT_WELDING_CELL_3_OP325_STN1 { get; set; }
        public bool WS7_TT_WELDING_CELL_3_OP330_STN2 { get; set; }
        public bool WS7_TT_MANUAL_WELDING_OP360 { get; set; }
        public bool WS7_TT_FINAL_GAUGE { get; set; }
        public bool WS7_TT_FINAL_LEAK_TESTER { get; set; }
        public bool WS7_TT_MARKING { get; set; }
        public bool WS7_TT_OP380 { get; set; }
        public bool WS7_TT_WELDING_CELL_3_OP390_STN2 { get; set; }
        public bool WS7_TT_PETLA_KONTROLNA_L4 { get; set; }

        public IList<IQueryable<Table.CNH.CnhWs1MeasuredAssembly>> DaneStf1 { get; set; }
        public IList<IQueryable<Table.CNH.CnhWs2Shell>> DaneStf2 { get; set; }
        public IList<ColumnPLTWs7> DaneMixer { get; set; }
        public IList<ColumnOP290Ws7> DaneOP290 { get; set; }
        public IList<ColumnOP300Ws7> DaneOP300 { get; set; }
        public IList<ColumnOP310Ws7> DaneOP310 { get; set; }
        public IList<ColumnOP320Ws7> DaneOP320 { get; set; }
        public IList<ColumnOP320Ws7> DaneOP325 { get; set; }
        public IList<ColumnOP320Ws7> DaneOP330 { get; set; }
        public IList<ColumnOP320Ws7> DaneOP360 { get; set; }
        public IList<ColumnOP320Ws7> DaneFLT { get; set; }
        public IList<ColumnOP380Ws7> DaneMarker { get; set; }
        public IList<ColumnOP380Ws7> DaneOP380 { get; set; }
        public IList<ColumnOP380Ws7> DaneOP390 { get; set; }
        public IList<ColumnFGWs7> DaneFG { get; set; }
        public IList<ColumnCLWs7> DaneCL { get; set; }

        public bool Stf2 { get; set; }
        public bool Stf1 { get; set; }
        public bool Stf { get; set; }

        public CheckBoxLineWs7()
        {
            context = new CnhDbContext();
            FindData = new List<string>();
        }

        private CodesWs7 FindCode(string code)
        {
            var result = context.Ws7TtFinalLeakTesters
                .Where(x => x.NrOslony == code)
                .Select(x => new CodesWs7
                {
                    CodeBasicDoc = x.NrShellaDoc,
                    CodeBasicScrof = x.NrShellaScrof,
                    CodeBasicScrcuc = x.NrShellaScrcuc,
                    CodeMixer = x.NrMixer,
                    CodeCatalyst = x.NrOslony
                }).ToArray();


            if (result.Length == 0)
            {
                result = context.Ws7TtFinalLeakTesters
                       .Where(x => x.NrOslony.Contains(code) || x.NrShellaDoc.Contains(code) || x.NrShellaScrcuc.Contains(code) || x.NrShellaScrof.Contains(code))
                      .Select(x => new CodesWs7
                      {
                          CodeBasicDoc = x.NrShellaDoc,
                          CodeBasicScrof = x.NrShellaScrof,
                          CodeBasicScrcuc = x.NrShellaScrcuc,
                          CodeMixer = x.NrMixer,
                          CodeCatalyst = x.NrOslony
                      }).ToArray();
            }

            CodesWs7 resultCode = new CodesWs7();

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
            CodesWs7 resultCode = new CodesWs7();

            var codeFromPzzw = context.Ws7TtPetlaKontrolnaL4s
                .Where(x => x.NrPaleta == find)
                .Select(x => x.NrKatalizatora)
                .ToArray();

            return codeFromPzzw;
        }

        #region Get data from Machines
        private IList<ColumnPLTWs7> GetDataFromMixer(string codeMixer)
        {
            var result = context.Ws7TtPreleakTesters
                          .Where(x => x.NrMixer == codeMixer)
                          .Select(x => new ColumnPLTWs7
                          {
                              NrMixer = x.NrMixer,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<ColumnOP290Ws7> GetDataFromOP290(string codeDOC)
        {
            var result = context.Ws7TtWeldingCell2Op290Stn1s
                          .Where(x => x.NrShellaDoc == codeDOC)
                          .Select(x => new ColumnOP290Ws7
                          {
                              NrShellDoc = x.NrShellaDoc,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();


            return result;
        }

        private IList<ColumnOP300Ws7> GetDataFromOP300(string codeDOC)
        {
            var result = context.Ws7TtWeldingCell2Op300Stn1s
                          .Where(x => x.NrShellaDoc == codeDOC)
                          .Select(x => new ColumnOP300Ws7
                          {
                              NrShellDoc = x.NrShellaDoc,
                              NrShellScrof = x.NrShellaScrof,
                              NrMixer = x.NrMixer,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<ColumnOP310Ws7> GetDataFromOP310(string codeSCRCUC)
        {
            var result = context.Ws7TtWeldingCell2Op310Stn2s
                          .Where(x => x.NrShellaScrcuc == codeSCRCUC)
                          .Select(x => new ColumnOP310Ws7
                          {
                              NrShellScrucu = x.NrShellaScrcuc,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<ColumnOP320Ws7> GetDataFromOP320(string codeDOC)
        {
            var result = context.Ws7TtWeldingCell3Op320Stn1s
                    .Where(x => x.NrShellaDoc == codeDOC)
                    .Select(x => new ColumnOP320Ws7
                    {
                        NrShellDoc = x.NrShellaDoc,
                        NrShellScrof = x.NrShellaScrof,
                        NrShellScrucu = x.NrShellaScrcuc,
                        NrMixer = x.NrMixer,
                        Wynik_operacji = x.WynikOperacji,
                        DateTime = (DateTime)x.DtOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();

            return result;
        }

        private IList<ColumnOP320Ws7> GetDataFromOP325(string codeDOC)
        {
            var result = context.Ws7TtWeldingCell3Op325Stn1s
                    .Where(x => x.NrShellaDoc == codeDOC)
                    .Select(x => new ColumnOP320Ws7
                    {
                        NrShellDoc = x.NrShellaDoc,
                        NrShellScrof = x.NrShellaScrof,
                        NrShellScrucu = x.NrShellaScrcuc,
                        NrMixer = x.NrMixer,
                        Wynik_operacji = x.WynikOperacji,
                        DateTime = (DateTime)x.DtOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();

            return result;
        }

        private IList<ColumnOP320Ws7> GetDataFromOP330(string codeDOC)
        {
            var result = context.Ws7TtWeldingCell3Op330Stn2s
                          .Where(x => x.NrShellaDoc == codeDOC)
                          .Select(x => new ColumnOP320Ws7
                          {
                              NrShellDoc = x.NrShellaDoc,
                              NrShellScrof = x.NrShellaScrof,
                              NrShellScrucu = x.NrShellaScrcuc,
                              NrMixer = x.NrMixer,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<ColumnOP320Ws7> GetDataFromOP360(string codeDOC)
        {
            var result = context.Ws7TtManualWeldingOp360s
                    .Where(x => x.NrShellaDoc == codeDOC)
                    .Select(x => new ColumnOP320Ws7
                    {
                        NrShellDoc = x.NrShellaDoc,
                        NrShellScrof = x.NrShellaScrof,
                        NrShellScrucu = x.NrShellaScrcuc,
                        NrMixer = x.NrMixer,
                        Wynik_operacji = x.WynikOperacji,
                        DateTime = (DateTime)x.DtOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();

            return result;
        }

        private IList<ColumnOP320Ws7> GetDataFromFLT(string codeDOC)
        {
            var result = context.Ws7TtFinalLeakTesters
                    .Where(x => x.NrShellaDoc == codeDOC)
                    .Select(x => new ColumnOP320Ws7
                    {
                        NrShellDoc = x.NrShellaDoc,
                        NrShellScrof = x.NrShellaScrof,
                        NrShellScrucu = x.NrShellaScrcuc,
                        NrMixer = x.NrMixer,
                        Wynik_operacji = x.WynikOperacji,
                        DateTime = (DateTime)x.DtOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();

            return result;
        }

        private IList<ColumnOP380Ws7> GetDataFromMarking(string codeDOC)
        {
            var result = context.Ws7TtMarkings
                    .Where(x => x.NrShellaDoc == codeDOC)
                    .Select(x => new ColumnOP380Ws7
                    {
                        NrShellDoc = x.NrShellaDoc,
                        NrShellScrof = x.NrShellaScrof,
                        NrShellScrucu = x.NrShellaScrcuc,
                        NrMixer = x.NrMixer,
                        Nr_Oslona = x.NrOslony,
                        Wynik_operacji = x.WynikOperacji,
                        DateTime = (DateTime)x.DtOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();

            return result;
        }

        private IList<ColumnOP380Ws7> GetDataFromOP380(string codeCover)
        {
            var result = context.Ws7TtOp380s
                    .Where(x => x.NrOslony == codeCover)
                    .Select(x => new ColumnOP380Ws7
                    {
                        NrShellDoc = x.NrShellaDoc,
                        NrShellScrof = x.NrShellaScrof,
                        NrShellScrucu = x.NrShellaScrcuc,
                        NrMixer = x.NrMixer,
                        Nr_Oslona = x.NrOslony,
                        Wynik_operacji = x.WynikOperacji,
                        DateTime = (DateTime)x.DtOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();

            return result;
        }

        private IList<ColumnOP380Ws7> GetDataFromOP390(string codeCover)
        {
            var result = context.Ws7TtWeldingCell3Op390Stn2s
                    .Where(x => x.NrOslona == codeCover)
                    .Select(x => new ColumnOP380Ws7
                    {
                        NrShellDoc = x.NrShellaDoc,
                        NrShellScrof = x.NrShellaScrof,
                        NrShellScrucu = x.NrShellaScrcuc,
                        NrMixer = x.NrMixer,
                        Nr_Oslona = x.NrOslona,
                        Wynik_operacji = x.WynikOperacji,
                        DateTime = (DateTime)x.DtOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();

            return result;
        }
        private IList<ColumnFGWs7> GetDataFromFG(string codeCover)
        {
            var result = context.Ws7TtOp380s
                    .Where(x => x.NrOslony == codeCover)
                    .Select(x => new ColumnFGWs7
                    {
                        Nr_Oslona = x.NrOslony,
                        Wynik_operacji = x.WynikOperacji,
                        DateTime = (DateTime)x.DtOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();

            return result;
        }

        private IList<ColumnCLWs7> GetDataFromControlLoop(string codeCover)
        {
            var result = context.Ws7TtPetlaKontrolnaL4s
                     .Where(x => x.NrKatalizatora == codeCover)
                     .OrderByDescending(x => x.Id)
                     .Select(x => new ColumnCLWs7
                     {
                         NrKatalizatora = x.NrKatalizatora,
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

        #endregion


        #region get data from machines by date

        private IList<ColumnPLTWs7> GetDataFromMixerByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Ws7TtPreleakTesters
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new ColumnPLTWs7
                          {
                              NrMixer = x.NrMixer,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<ColumnOP290Ws7> GetDataFromOP290ByDate(DateTime from, DateTime to)
        {

            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Ws7TtWeldingCell2Op290Stn1s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new ColumnOP290Ws7
                          {
                              NrShellDoc = x.NrShellaDoc,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();


            return result;
        }

        private IList<ColumnOP300Ws7> GetDataFromOP300ByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Ws7TtWeldingCell2Op300Stn1s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new ColumnOP300Ws7
                          {
                              NrShellDoc = x.NrShellaDoc,
                              NrShellScrof = x.NrShellaScrof,
                              NrMixer = x.NrMixer,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<ColumnOP310Ws7> GetDataFromOP310ByDate(DateTime from, DateTime to)
        {

            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Ws7TtWeldingCell2Op310Stn2s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new ColumnOP310Ws7
                          {
                              NrShellScrucu = x.NrShellaScrcuc,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();

            return result;
        }


        private IList<ColumnOP320Ws7> GetDataFromOP320ByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Ws7TtWeldingCell3Op320Stn1s
                    .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .Select(x => new ColumnOP320Ws7
                    {
                        NrShellDoc = x.NrShellaDoc,
                        NrShellScrof = x.NrShellaScrof,
                        NrShellScrucu = x.NrShellaScrcuc,
                        NrMixer = x.NrMixer,
                        Wynik_operacji = x.WynikOperacji,
                        DateTime = (DateTime)x.DtOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();

            return result;
        }

        private IList<ColumnOP320Ws7> GetDataFromOP325ByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Ws7TtWeldingCell3Op325Stn1s
                    .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .Select(x => new ColumnOP320Ws7
                    {
                        NrShellDoc = x.NrShellaDoc,
                        NrShellScrof = x.NrShellaScrof,
                        NrShellScrucu = x.NrShellaScrcuc,
                        NrMixer = x.NrMixer,
                        Wynik_operacji = x.WynikOperacji,
                        DateTime = (DateTime)x.DtOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();

            return result;
        }

        private IList<ColumnOP320Ws7> GetDataFromOP330ByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Ws7TtWeldingCell3Op330Stn2s
                          .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                          .Select(x => new ColumnOP320Ws7
                          {
                              NrShellDoc = x.NrShellaDoc,
                              NrShellScrof = x.NrShellaScrof,
                              NrShellScrucu = x.NrShellaScrcuc,
                              NrMixer = x.NrMixer,
                              Wynik_operacji = x.WynikOperacji,
                              Frame_time = x.FrameTime,
                              DateTime = (DateTime)x.DtOperacji
                          }).ToArray();

            return result;
        }

        private IList<ColumnOP320Ws7> GetDataFromOP360ByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Ws7TtManualWeldingOp360s
                    .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .Select(x => new ColumnOP320Ws7
                    {
                        NrShellDoc = x.NrShellaDoc,
                        NrShellScrof = x.NrShellaScrof,
                        NrShellScrucu = x.NrShellaScrcuc,
                        NrMixer = x.NrMixer,
                        Wynik_operacji = x.WynikOperacji,
                        DateTime = (DateTime)x.DtOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();

            return result;
        }

        private IList<ColumnOP320Ws7> GetDataFromFLTByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Ws7TtFinalLeakTesters
                    .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .Select(x => new ColumnOP320Ws7
                    {
                        NrShellDoc = x.NrShellaDoc,
                        NrShellScrof = x.NrShellaScrof,
                        NrShellScrucu = x.NrShellaScrcuc,
                        NrMixer = x.NrMixer,
                        Wynik_operacji = x.WynikOperacji,
                        DateTime = (DateTime)x.DtOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();

            return result;
        }

        private IList<ColumnOP380Ws7> GetDataFromMarkingByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Ws7TtMarkings
                    .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .Select(x => new ColumnOP380Ws7
                    {
                        NrShellDoc = x.NrShellaDoc,
                        NrShellScrof = x.NrShellaScrof,
                        NrShellScrucu = x.NrShellaScrcuc,
                        NrMixer = x.NrMixer,
                        Nr_Oslona = x.NrOslony,
                        Wynik_operacji = x.WynikOperacji,
                        DateTime = (DateTime)x.DtOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();

            return result;
        }

        private IList<ColumnOP380Ws7> GetDataFromOP380ByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Ws7TtOp380s
                    .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .Select(x => new ColumnOP380Ws7
                    {
                        NrShellDoc = x.NrShellaDoc,
                        NrShellScrof = x.NrShellaScrof,
                        NrShellScrucu = x.NrShellaScrcuc,
                        NrMixer = x.NrMixer,
                        Nr_Oslona = x.NrOslony,
                        Wynik_operacji = x.WynikOperacji,
                        DateTime = (DateTime)x.DtOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();

            return result;
        }
        private IList<ColumnOP380Ws7> GetDataFromOP390ByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Ws7TtWeldingCell3Op390Stn2s
                    .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .Select(x => new ColumnOP380Ws7
                    {
                        NrShellDoc = x.NrShellaDoc,
                        NrShellScrof = x.NrShellaScrof,
                        NrShellScrucu = x.NrShellaScrcuc,
                        NrMixer = x.NrMixer,
                        Nr_Oslona = x.NrOslona,
                        Wynik_operacji = x.WynikOperacji,
                        DateTime = (DateTime)x.DtOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();

            return result;
        }

        private IList<ColumnFGWs7> GetDataFromFGByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTimeUtc();
            var frameTimeTo = to.ConvertDateTimeToFrameTimeUtc();

            var result = context.Ws7TtOp380s
                    .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .Select(x => new ColumnFGWs7
                    {
                        Nr_Oslona = x.NrOslony,
                        Wynik_operacji = x.WynikOperacji,
                        DateTime = (DateTime)x.DtOperacji,
                        Frame_time = x.FrameTime
                    }).ToArray();

            return result;
        }

        private IList<ColumnCLWs7> GetDataFromControlLoopByDate(DateTime from, DateTime to)
        {
            var frameTimeFrom = from.ConvertDateTimeToFrameTime();
            var frameTimeTo = to.ConvertDateTimeToFrameTime();

            var result = context.Ws5CnhPetlaKontrolnaL1s
                     .Where(x => (x.FrameTime >= frameTimeFrom && x.FrameTime < frameTimeTo))
                    .OrderByDescending(x => x.Id)
                     .Select(x => new ColumnCLWs7
                     {
                         NrKatalizatora = x.NrKatalizatora,
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

        #endregion

        public void GetDataCode(bool download = false)
        {
            DaneStf1 = new List<IQueryable<Table.CNH.CnhWs1MeasuredAssembly>>();
            DaneStf2 = new List<IQueryable<Table.CNH.CnhWs2Shell>>();

            DaneMixer = new List<ColumnPLTWs7>();
            DaneOP290 = new List<ColumnOP290Ws7>();
            DaneOP300 = new List<ColumnOP300Ws7>();
            DaneOP310 = new List<ColumnOP310Ws7> ();
            DaneOP320 = new List<ColumnOP320Ws7>();
            DaneOP325 = new List<ColumnOP320Ws7>();
            DaneOP330 = new List<ColumnOP320Ws7>();
            DaneOP360 = new List<ColumnOP320Ws7>();
            DaneFLT = new List<ColumnOP320Ws7>();
            DaneMarker = new List<ColumnOP380Ws7>();
            DaneOP390 = new List<ColumnOP380Ws7>();
            DaneFG = new List<ColumnFGWs7>();
            DaneCL = new List<ColumnCLWs7>();
            
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

                if (WS7_TT_PRELEAK_TESTER)
                {
                    var result = GetDataFromMixerByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneMixer.Add(r);
                    }
                }

                if (WS7_TT_WELDING_CELL_2_OP290_STN1)
                {
                    var result = GetDataFromOP290ByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneOP290.Add(r);
                    }
                }

                if (WS7_TT_WELDING_CELL_2_OP300_STN1)
                {
                    var result = GetDataFromOP300ByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneOP300.Add(r);
                    }
                }

                if (WS7_TT_WELDING_CELL_2_OP310_STN2)
                {
                    var result = GetDataFromOP310ByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneOP310.Add(r);
                    }
                }
                if (WS7_TT_WELDING_CELL_3_OP320_STN1)
                {
                    var result = GetDataFromOP320ByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneOP320.Add(r);
                    }
                }

                if (WS7_TT_WELDING_CELL_3_OP325_STN1)
                {
                    var result = GetDataFromOP325ByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneOP325.Add(r);
                    }
                }



                if (WS7_TT_WELDING_CELL_3_OP330_STN2)
                {
                    var result = GetDataFromOP330ByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneOP330.Add(r);
                    }
                }

                if (WS7_TT_MANUAL_WELDING_OP360)
                {
                    var result = GetDataFromOP360ByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneOP360.Add(r);
                    }
                }

                if (WS7_TT_FINAL_LEAK_TESTER)
                {
                    var result = GetDataFromFLTByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneFLT.Add(r);
                    }
                }

                if (WS7_TT_MARKING)
                {
                    var result = GetDataFromMarkingByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneMarker.Add(r);
                    }
                }

                if (WS7_TT_WELDING_CELL_3_OP390_STN2)
                {
                    var result = GetDataFromOP390ByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneOP390.Add(r);
                    }
                }
                if (WS7_TT_FINAL_GAUGE)
                {
                    var result = GetDataFromFGByDate(from, to);

                    foreach (var r in result)
                    {
                        DaneFG.Add(r);
                    }
                }
                if (WS7_TT_PETLA_KONTROLNA_L4)
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


        private void FindDataCode(IList<string> codes, bool download = false)
        {
            foreach (var code in codes)
            {
                Codes = FindCode(code);

                if (Stf1 && Codes.CodeBasicDoc != Brak)
                {
                    var result = GetDataFromSqlStf1(Codes.CodeBasicDoc);

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

                if (WS7_TT_PRELEAK_TESTER && Codes.CodeMixer != Brak)
                {
                    var result = GetDataFromMixer(Codes.CodeMixer);

                    foreach (var r in result)
                    {
                        DaneMixer.Add(r);
                    }
                }

                if (WS7_TT_WELDING_CELL_2_OP290_STN1 && Codes.CodeBasicDoc != Brak)
                {
                    var result = GetDataFromOP290(Codes.CodeBasicDoc);

                    foreach (var r in result)
                    {
                        DaneOP290.Add(r);
                    }
                }

                if (WS7_TT_WELDING_CELL_2_OP300_STN1 && Codes.CodeBasicDoc != Brak)
                {
                    var result = GetDataFromOP300(Codes.CodeBasicDoc);

                    foreach (var r in result)
                    {
                        DaneOP300.Add(r);
                    }
                }

                if (WS7_TT_WELDING_CELL_2_OP310_STN2 && Codes.CodeBasicScrcuc != Brak)
                {
                    var result = GetDataFromOP310(Codes.CodeBasicScrcuc);

                    foreach (var r in result)
                    {
                        DaneOP310.Add(r);
                    }
                }

                if (WS7_TT_WELDING_CELL_3_OP320_STN1 && Codes.CodeBasicDoc != Brak)
                {
                    var result = GetDataFromOP320(Codes.CodeBasicDoc);

                    foreach (var r in result)
                    {
                        DaneOP320.Add(r);
                    }
                }

                if (WS7_TT_WELDING_CELL_3_OP325_STN1 && Codes.CodeBasicDoc != Brak)
                {
                    var result = GetDataFromOP325(Codes.CodeBasicDoc);

                    foreach (var r in result)
                    {
                        DaneOP325.Add(r);
                    }
                }

                if (WS7_TT_WELDING_CELL_3_OP330_STN2 && Codes.CodeBasicDoc != Brak)
                {
                    var result = GetDataFromOP330(Codes.CodeBasicDoc);

                    foreach (var r in result)
                    {
                        DaneOP330.Add(r);
                    }
                }

                if (WS7_TT_MANUAL_WELDING_OP360 && Codes.CodeBasicDoc != Brak)
                {
                    var result = GetDataFromOP360(Codes.CodeBasicDoc);

                    foreach (var r in result)
                    {
                        DaneOP360.Add(r);
                    }
                }

                if (WS7_TT_FINAL_LEAK_TESTER && Codes.CodeBasicDoc != Brak)
                {
                    var result = GetDataFromFLT(Codes.CodeBasicDoc);

                    foreach (var r in result)
                    {
                        DaneFLT.Add(r);
                    }
                }

                if (WS7_TT_MARKING && Codes.CodeBasicDoc != Brak)
                {
                    var result = GetDataFromMarking(Codes.CodeBasicDoc);

                    foreach (var r in result)
                    {
                        DaneMarker.Add(r);
                    }
                }

                if (WS7_TT_OP380 && Codes.CodeCatalyst != Brak)
                {
                    var result = GetDataFromOP380(Codes.CodeCatalyst);

                    foreach (var r in result)
                    {
                        DaneOP380.Add(r);
                    }
                }

                if (WS7_TT_WELDING_CELL_3_OP390_STN2 && Codes.CodeCatalyst != Brak)
                {
                    var result = GetDataFromOP390(Codes.CodeCatalyst);

                    foreach (var r in result)
                    {
                        DaneOP390.Add(r);
                    }
                }

                if (WS7_TT_FINAL_GAUGE && Codes.CodeCatalyst != Brak)
                {
                    var result = GetDataFromFG(Codes.CodeCatalyst);

                    foreach (var r in result)
                    {
                        DaneFG.Add(r);
                    }
                }

                if (WS7_TT_PETLA_KONTROLNA_L4 && Codes.CodeCatalyst != Brak)
                {
                    var result = GetDataFromControlLoop(Codes.CodeCatalyst);

                    foreach (var r in result)
                    {
                        DaneCL.Add(r);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMonitoring.Search
{
      public class BasicColumn
    {
        public string Nr_Shell { get; set; }
        public string Nr_Grawerka { get; set; }
        public string Nr_Grawerka2 { get; set; }
        public string Tryb_Pracy { get; set; }
        public string Wynik_operacji { get; set; }
        public string Uwagi { get; set; }
        public string Nr_linii { get; set; }
        public long? Frame_time { get; set; }
        public long? Frame_time2 { get; set; }
        public long? Frame_time3 { get; set; }
        public DateTime DateTime { get; set; }
    }

    public class ColumnLT : BasicColumn
    {
        public string Cisnienie { get; set; }
        public string Cisnienie_jedn { get; set; }
        public string Wyciek { get; set; }
        public string Wyciek_jedn { get; set; }
    }

    public class ColumnFLT : ColumnLT
    {
        public string Wartosc_Przeplywu_Rurki_1 { get; set; }
        public string Wartosc_Przeplywu_Rurki_2 { get; set; }
    }

    public class ColumnTorque : BasicColumn
    {
        public string Moment_nakretka1 { get; set; }
        public string Kat_nakretka1 { get; set; }
        public string Moment_nakretka2 { get; set; }
        public string Kat_nakretka2 { get; set; }
    }

    public class ColumnCL : BasicColumn
    {
        public string PZZW { get; set; }
        public string OperatorID { get; set; }
    }

    public class BasicColumnWs5
    {
        public string NrShellDoc { get; set; }
        public string NrShellScrof { get; set; }
        public string NrShellScrucu { get; set; }
        public string NrMixer { get; set; }
        public string Nr_Oslona { get; set; }
        public string Tryb_Pracy { get; set; }
        public string Wynik_operacji { get; set; }
        public long? Frame_time { get; set; }
        public DateTime DateTime { get; set; }
    }

    public class BasicColumnWs6
    {
        public string NrShellStf1 { get; set; }
        public string NrShellStf2 { get; set; }
        public string Nr_Oslona { get; set; }
        public string Tryb_Pracy { get; set; }
        public string Wynik_operacji { get; set; }
        public long? Frame_time { get; set; }
        public DateTime DateTime { get; set; }
    }

    public class BasicColumnWs7
    {
        //public string NrShellDoc { get; set; }
        //public string NrShellScrof { get; set; }
        //public string NrShellScrucu { get; set; }
        //public string NrMixer { get; set; }
        //public string Nr_Oslona { get; set; }
        public string Tryb_Pracy { get; set; }
        public string Wynik_operacji { get; set; }
        public long? Frame_time { get; set; }
        public DateTime DateTime { get; set; }
    }

    public class ColumnPLTWs7:BasicColumnWs7 
    {
        public string NrMixer { get; set; }
        public string Cisnienie { get; set; }
        public string Cisnienie_jedn { get; set; }
        public string Wyciek { get; set; }
        public string Wyciek_jedn { get; set; }
    }
    public class ColumnOP290Ws7:BasicColumnWs7
    {
        public string NrMixer { get; set; }
        public string NrShellDoc { get; set; }
    }

    public class ColumnOP300Ws7:BasicColumnWs7
    {
        public string NrMixer { get; set; }
        public string NrShellDoc { get; set; }
        public string NrShellScrof { get; set; }
    }

    public class ColumnOP310Ws7:BasicColumnWs7
    {
        public string NrShellScrucu { get; set; }
    }

    public class ColumnOP320Ws7:BasicColumnWs7
    {
        public string NrMixer { get; set; }
        public string NrShellDoc { get; set; }
        public string NrShellScrof { get; set; }
        public string NrShellScrucu { get; set; }
    }
    public class ColumnOP380Ws7:BasicColumnWs7
    {
        public string NrMixer { get; set; }
        public string NrShellDoc { get; set; }
        public string NrShellScrof { get; set; }
        public string NrShellScrucu { get; set; }
        public string Nr_Oslona { get; set; }
    }

    public class ColumnCLWs7 : BasicColumnWs7
    {
        public string PZZW { get; set; }
        public string NrKatalizatora { get; set; }
        public string OperatorID { get; set; }
        public string Uwagi { get; set; }
    }


    public class ColumnLTWs5 : BasicColumnWs5
    {
        public string Cisnienie { get; set; }
        public string Cisnienie_jedn { get; set; }
        public string Wyciek { get; set; }
        public string Wyciek_jedn { get; set; }
    }

    public class ColumnLTWs6 : BasicColumnWs6
    {
        public string Cisnienie { get; set; }
        public string Cisnienie_jedn { get; set; }
        public string Wyciek { get; set; }
        public string Wyciek_jedn { get; set; }
    }

    public class BasicColumnM260
    {
        public string Nr_Shell { get; set; }
        public string Tryb_Pracy { get; set; }
        public string Wynik_operacji { get; set; }
        public string Uwagi { get; set; }
        public long? Frame_time { get; set; }
        public DateTime? DateTime { get; set; }
    }

    public class ColumnLTM260 : BasicColumnM260
    {
        public float? Cisnienie { get; set; }
        public string Cisnienie_jedn { get; set; }
        public float? Wyciek { get; set; }
        public string Wyciek_jedn { get; set; }
    }

    public class ColumnCLM260 : BasicColumnM260
    {
        public string PZZW { get; set; }
        public string NrEtykiety { get; set; }
        public string OperatorID { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class VLeakTesterBr10L2All
    {
        public string NrShella { get; set; }
        public string Cisnienie { get; set; }
        public string CisnienieJedn { get; set; }
        public string Wyciek { get; set; }
        public string WyciekJedn { get; set; }
        public string NrGrawerka { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
        public long? GrawerkaTime { get; set; }
        public int? GrawerkaSeq { get; set; }
        public string WynikTestu { get; set; }
        public string NrGrawerka2 { get; set; }
        public int? IdHist { get; set; }
        public string Oper { get; set; }
        public DateTime? OpTime { get; set; }
    }
}

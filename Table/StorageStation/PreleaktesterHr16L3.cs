using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class PreleaktesterHr16L3
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
        public string NrLinii { get; set; }
        public long? FrameTime2 { get; set; }
        public int? FrameSeq2 { get; set; }
        public long? GrawerkaTime2 { get; set; }
        public int? GrawerkaSeq2 { get; set; }
        public long? FrameTime3 { get; set; }
        public int? FrameSeq3 { get; set; }
        public long? GrawerkaTime3 { get; set; }
        public int? GrawerkaSeq3 { get; set; }
        public string NrGrawerka2 { get; set; }
        public string TrybPracy { get; set; }
    }
}

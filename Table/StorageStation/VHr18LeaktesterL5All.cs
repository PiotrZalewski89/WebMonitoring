using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class VHr18LeaktesterL5All
    {
        public string NrShella { get; set; }
        public string NrGrawerka { get; set; }
        public string Cisnienie { get; set; }
        public string CisnienieJedn { get; set; }
        public string Wyciek { get; set; }
        public string WyciekJedn { get; set; }
        public string WynikOperacji { get; set; }
        public string TrybPracy { get; set; }
        public DateTime? DtOperacji { get; set; }
        public long? FrameTime { get; set; }
        public long? GrawerkaTime { get; set; }
        public string NrLinii { get; set; }
        public int IdHist { get; set; }
    }
}

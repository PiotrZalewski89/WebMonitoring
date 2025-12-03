using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class VHr18FinalGaugeL5All
    {
        public string NrShella { get; set; }
        public string NrGrawerka { get; set; }
        public string WynikOperacji { get; set; }
        public string TrybPracy { get; set; }
        public DateTime? DtOperacji { get; set; }
        public long? FrameTime { get; set; }
        public string NrLinii { get; set; }
        public int IdHist { get; set; }
    }
}

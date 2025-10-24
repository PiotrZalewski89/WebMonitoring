using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class VM260LeakTesterAndMarkingL4All
    {
        public string NrShella { get; set; }
        public string WynikOperacji { get; set; }
        public float? Wyciek { get; set; }
        public string WyciekJedn { get; set; }
        public float? Cisnienie { get; set; }
        public string CisnienieJedn { get; set; }
        public string TrybPracy { get; set; }
        public DateTime? DtOperacji { get; set; }
        public long? FrameTime { get; set; }
        public int IdHist { get; set; }
    }
}

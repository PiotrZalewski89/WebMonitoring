using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class M260ControlLoopL4
    {
        public string NrShella { get; set; }
        public string NrEtykiety { get; set; }
        public string NrPzzw { get; set; }
        public string WynikOperacji { get; set; }
        public string TrybPracy { get; set; }
        public DateTime? DtOperacji { get; set; }
        public string NrOperatora { get; set; }
        public string Quality { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
    }
}

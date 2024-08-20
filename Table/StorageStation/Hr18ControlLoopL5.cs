using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class Hr18ControlLoopL5
    {
        public string NrKatalizatora { get; set; }
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

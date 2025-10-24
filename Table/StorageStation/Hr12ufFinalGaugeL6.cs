using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class Hr12ufFinalGaugeL6
    {
        public string NrBasic { get; set; }
        public string TrybPracy { get; set; }
        public string WynikOperacji { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
        public string NrLinii { get; set; }
        public DateTime? DtOperacji { get; set; }
        public string InletStatus { get; set; }
        public string InletBracketStatus { get; set; }
        public float? InletBrackteValue { get; set; }
        public string OutletStatus { get; set; }
        public string OutletBracketStatus { get; set; }
        public float? OutletBrackteValue { get; set; }
    }
}

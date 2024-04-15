using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.CNH
{
    public partial class Ws1CnhVisualStationL3
    {
        public int Id { get; set; }
        public string NrKatalizatora { get; set; }
        public string TrybPracy { get; set; }
        public string WynikOperacji { get; set; }
        public string Uwagi { get; set; }
        public DateTime? DtOperacji { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
    }
}

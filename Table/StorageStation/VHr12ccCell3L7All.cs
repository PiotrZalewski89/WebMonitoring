using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class VHr12ccCell3L7All
    {
        public string NrShella { get; set; }
        public string NrClamshell { get; set; }
        public string TrybPracy { get; set; }
        public string WynikOperacji { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
        public string NrLinii { get; set; }
        public DateTime? DtOperacji { get; set; }
        public int IdHist { get; set; }
        public DateTime? OpTime { get; set; }
        public string Oper { get; set; }
    }
}

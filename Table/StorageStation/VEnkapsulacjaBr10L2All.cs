using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class VEnkapsulacjaBr10L2All
    {
        public string NrShella { get; set; }
        public string NrGrawerka { get; set; }
        public string TrybPracy { get; set; }
        public string WynikOperacji { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
        public int? IdHist { get; set; }
        public string Oper { get; set; }
        public DateTime? OpTime { get; set; }
    }
}

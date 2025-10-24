using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class VHr12ccTorqueScrewdriverL7All
    {
        public string NrGrawerka { get; set; }
        public string TorqueNakretka1 { get; set; }
        public string AngleNakretka1 { get; set; }
        public string TorqueNakretka2 { get; set; }
        public string AngleNakretka2 { get; set; }
        public string TrybPracy { get; set; }
        public string WynikOperacji { get; set; }
        public DateTime? DtOperacji { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
        public string NrLinii { get; set; }
        public int IdHist { get; set; }
        public DateTime? OpTime { get; set; }
        public string Oper { get; set; }
    }
}

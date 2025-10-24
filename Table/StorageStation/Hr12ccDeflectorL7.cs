using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class Hr12ccDeflectorL7
    {
        public string NrGrawerka { get; set; }
        public decimal? TorqueNakretka1 { get; set; }
        public decimal? AngleNakretka1 { get; set; }
        public decimal? TorqueNakretka2 { get; set; }
        public decimal? AngleNakretka2 { get; set; }
        public decimal? TorqueNakretka3 { get; set; }
        public decimal? AngleNakretka3 { get; set; }
        public string TrybPracy { get; set; }
        public string WynikOperacji { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
        public string NrLinii { get; set; }
        public DateTime? DtOperacji { get; set; }
    }
}

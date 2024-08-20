using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class Hr18VacuumL5
    {
        public string NrShella { get; set; }
        public string NrGrawerka { get; set; }
        public string WynikOperacji { get; set; }
        public string TrybPracy { get; set; }
        public DateTime? DtOperacji { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
        public float? Vacuum1 { get; set; }
        public float? Vacuum2 { get; set; }
    }
}

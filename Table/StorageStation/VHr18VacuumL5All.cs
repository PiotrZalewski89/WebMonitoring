using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class VHr18VacuumL5All
    {
        public string NrShella { get; set; }
        public string NrGrawerka { get; set; }
        public string WynikOperacji { get; set; }
        public string TrybPracy { get; set; }
        public float? Vacuum1 { get; set; }
        public float? Vacuum2 { get; set; }
        public DateTime? DtOperacji { get; set; }
        public long? FrameTime { get; set; }
        public int IdHist { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class Hr12ccHomologationL7
    {
        public string NrGrawerka { get; set; }
        public string TrybPracy { get; set; }
        public string WynikOperacji { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
        public string NrLinii { get; set; }
        public string Wady { get; set; }
        public DateTime? DtOperacji { get; set; }
    }
}

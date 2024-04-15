using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class VPetlaKontrolnaHr10L1Monitoring
    {
        public int Id { get; set; }
        public string NrGrawerka { get; set; }
        public string NrPaleta { get; set; }
        public string TrybPracy { get; set; }
        public string WynikOperacji { get; set; }
        public string NrLinii { get; set; }
        public long? FrameTime { get; set; }
        public long? FrameTime2 { get; set; }
        public long? FrameTime3 { get; set; }
    }
}

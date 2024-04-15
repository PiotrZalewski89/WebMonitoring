using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class PetlaKontrolnaBr10L2
    {
        public string NrGrawerka { get; set; }
        public string NrPaleta { get; set; }
        public string TrybPracy { get; set; }
        public string WynikOperacji { get; set; }
        public string NrOperatora { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
        public int Id { get; set; }
        public string Quality { get; set; }
    }
}

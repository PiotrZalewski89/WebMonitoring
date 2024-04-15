using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.V50
{
    public partial class V50PetlaKontrolnaL1
    {
        public int Id { get; set; }
        public string NrKatalizatora { get; set; }
        public string NrPzzw { get; set; }
        public string TrybPracy { get; set; }
        public string WynikOperacji { get; set; }
        public string NrOperatora { get; set; }
        public string Quality { get; set; }
        public DateTime? DtOperacji { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
    }
}

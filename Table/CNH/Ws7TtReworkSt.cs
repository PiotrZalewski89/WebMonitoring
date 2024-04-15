using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.CNH
{
    public partial class Ws7TtReworkSt
    {
        public int Id { get; set; }
        public string NrShella { get; set; }
        public string WadaJakosciowa { get; set; }
        public string IdOperatora { get; set; }
        public DateTime? DtOperacji { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
        public string Model { get; set; }
        public int? Stanowisko { get; set; }
    }
}

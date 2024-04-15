﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.CNH
{
    public partial class CnhEtap1
    {
        public string NrShellaDoc { get; set; }
        public string TrybPracy { get; set; }
        public string WynikOperacji { get; set; }
        public DateTime? DtOperacji { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
    }
}
